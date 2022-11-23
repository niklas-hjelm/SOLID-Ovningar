using System;
using WorkshopHandsOn7.Messages;
using WorkshopHandsOn7.ValueObjects;
using System.Drawing.Drawing2D;

namespace WorkshopHandsOn7.Navigation
{
    class NavigationService : INavigationService
    {
        private IServiceBus _servicebus;
        private Tuple<Guid, Position> _currentRequesterInfo;
        private Tuple<Guid, Position> _currentPlaceHolderInfo;
        private Boolean _positionIsFree;
        private IPlayingBoard _playingBoard;

        public static INavigationService Create(IServiceBus servicebus, IPlayingBoard playingBoard)
        {
            return new NavigationService(servicebus, playingBoard);
        }
        private NavigationService(IServiceBus servicebus, IPlayingBoard playingBoard)
        {
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
