using System;
using System.Linq;
using System.Collections.Generic;
using WorkshopHandsOn9.Messages;
using WorkshopHandsOn9.ValueObjects;
using System.Drawing.Drawing2D;
using WorkshopHandsOn9.Routes;

namespace WorkshopHandsOn9.Navigation
{
    class NavigationService : INavigationService
    {
        private IRouteService _routeService;
        private IServiceBus _servicebus;
        private Tuple<Guid, Position> _currentRequesterInfo;
        private Tuple<Guid, Position> _currentPlaceHolderInfo;
        private Boolean _positionIsFree;
        private ParkingLot _parkingLot;
        private IPlayingBoard _playingBoard;

        public static INavigationService Create(IServiceBus servicebus, ParkingLot parkingLot, IPlayingBoard playingBoard)
        {
            return new NavigationService(servicebus, parkingLot, playingBoard, RouteService.Create());
        }
        public static INavigationService Create(IServiceBus servicebus, ParkingLot parkingLot, IPlayingBoard playingBoard, IRouteService routeService)
        {
            return new NavigationService(servicebus, parkingLot, playingBoard, routeService);
        }
        private NavigationService(IServiceBus servicebus, ParkingLot parkingLot, IPlayingBoard playingBoard, IRouteService routeService)
        {
            this._routeService = routeService;
            this._parkingLot = parkingLot;
            this._playingBoard = playingBoard;
            this._servicebus = servicebus;
            this._servicebus.Register<RobotPositionEvent>(e => this.MyPositionEventHandler(e));
        }
        public void RequestNewPosition(Guid requesterKey, Position position)
        {
            Position current = Position.Create(position);
            while (!this.IsPositionFree(requesterKey, position))
            {
                position = this.GetRandomPosition();
            }
            this._servicebus.Publish<PositionIsFreeEvent>(new PositionIsFreeEvent(position, requesterKey));
        }
        public void RequestAccessToPosition(Guid requesterKey, Position position)
        {
            Position current = Position.Create(position);

            if (this.IsPositionFree(requesterKey, position))
            {
                this._servicebus.Publish<PositionIsFreeEvent>(new PositionIsFreeEvent(position, requesterKey));
                return;
            }

            this._servicebus.Publish<PositionIsFreeEvent>(new PositionIsFreeEvent(this._parkingLot.Position, this._currentPlaceHolderInfo.Item1));
            this._servicebus.Publish<PositionIsFreeEvent>(new PositionIsFreeEvent(position, requesterKey));

            this.RequestNewPosition(this._currentPlaceHolderInfo.Item1, this.GetRandomPosition());
        }
        public Boolean IsPositionFree(Guid requesterKey, Position positionToCheck)
        {
            this._playingBoard.CheckBoardPosition(positionToCheck);

            this._positionIsFree = true;
            this._currentRequesterInfo = Tuple.Create(requesterKey, positionToCheck);
            this._servicebus.Publish<CheckPositionCommand>(new CheckPositionCommand(positionToCheck, requesterKey));
            return this._positionIsFree;
        }
        public Position GetRandomPosition()
        {
            return this._playingBoard.GetRandomPosition();
        }
        public Position GetFreeRandomPosition(IList<Position> exclude)
        {
            bool equal = false;
            Position pos = this.GetFreeRandomPosition();
            while (!equal)
            {
                pos = this.GetFreeRandomPosition();
                equal = exclude.FirstOrDefault(p => p.Equals(pos)) == null;
            }
            return pos;
        }
        public Position GetFreeRandomPosition()
        {
            Guid fake = Guid.NewGuid();
            Position position = this._playingBoard.GetRandomPosition();
            while (!this.IsPositionFree(fake, position))
            {
                position = this.GetRandomPosition();
            }
            return position;
        }
        public IList<Position> GetRoute(Guid requesterKey, Position positionRobot, Position positionGoal)
        {
            this._playingBoard.ClearBlocked();
            IList<Position> positions = this._playingBoard.GetPositions();
            for (int index = 0; index < positions.Count; index++)
            {
                if (!this.IsPositionFree(requesterKey, positions[index]))
                {
                    this._playingBoard.BlockPosition(positions[index]);
                }
            }
            return this._routeService.GetRoute(this._playingBoard.Board[positionRobot.X - 1, positionRobot.Y - 1], this._playingBoard.Board[positionGoal.X - 1, positionGoal.Y - 1]);
        }
        public INavigationService SetPlayingBoard(IPlayingBoard board)
        {
            this._playingBoard = board;
            return this;
        }
        private void MyPositionEventHandler(RobotPositionEvent e)
        {
            Boolean positionTaken = e.Data.Equals(this._currentRequesterInfo.Item2);
            this._positionIsFree = !this._positionIsFree ? false : !positionTaken; // Stay NOT free if already set
            if (positionTaken)
                this._currentPlaceHolderInfo = e.GetInformation();
        }
    }
}
