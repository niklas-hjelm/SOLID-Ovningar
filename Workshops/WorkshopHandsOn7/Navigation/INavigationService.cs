using System;
using WorkshopHandsOn7.ValueObjects;

namespace WorkshopHandsOn7.Navigation
{
    public interface INavigationService
    {
        Boolean IsPositionFree(Guid requesterKey, Position positionToCheck);
        void RequestNewPosition(Guid requesterKey, Position position);
        Position GetRandomPosition();
    }
}
