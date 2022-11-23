using System;
using WorkshopHandsOn11.ValueObjects;
using System.Collections.Generic;

namespace WorkshopHandsOn11.Navigation
{
    public interface INavigationService
    {
        Boolean IsPositionFree(Guid requesterKey, Position positionToCheck);
        void RequestAccessToPosition(Guid requesterKey, Position position);
        void RequestNewPosition(Guid requesterKey, Position position);
        Position GetRandomPosition();
        Position GetFreeRandomPosition();
        Position GetFreeRandomPosition(IList<Position> exclude);
        INavigationService SetPlayingBoard(IPlayingBoard board);
        IList<Position> GetRoute(Guid requesterKey, Position positionRobot, Position positionGoal);
    }
}
