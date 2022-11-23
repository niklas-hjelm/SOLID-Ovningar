using System;
using System.Collections.Generic;
using WorkshopHandsOn8.Messages;
using WorkshopHandsOn8.ValueObjects;
using System.Drawing.Drawing2D;

namespace WorkshopHandsOn8.Navigation
{
    class NavigationService : INavigationService
    {
        private IServiceBus _servicebus;
        private Tuple<Guid, Position> _currentRequesterInfo;
        private Tuple<Guid, Position> _currentPlaceHolderInfo;
        private Boolean _positionIsFree;
        private ParkingLot _parkingLot;
        private IPlayingBoard _playingBoard;

        public static INavigationService Create(IServiceBus servicebus, ParkingLot parkingLot, IPlayingBoard playingBoard)
        {
            return new NavigationService(servicebus, parkingLot, playingBoard);
        }
        private NavigationService(IServiceBus servicebus, ParkingLot parkingLot, IPlayingBoard playingBoard)
        {
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
            
            this.RequestNewPosition(this._currentPlaceHolderInfo.Item1,this.GetRandomPosition());        
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
        private void MyPositionEventHandler(RobotPositionEvent e)
        {
            Boolean positionTaken = e.Data.Equals(this._currentRequesterInfo.Item2);
            this._positionIsFree = !this._positionIsFree ? false: !positionTaken; // Stay NOT free if already set
            if (positionTaken)
                this._currentPlaceHolderInfo = e.GetInformation();     
        }       
    }
}
