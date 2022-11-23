using System;
using WorkshopHandsOn8.ValueObjects;

namespace WorkshopHandsOn8.Navigation
{
    public interface INavigationService
    {
        Boolean IsPositionFree(Guid requesterKey, Position positionToCheck);
        void RequestAccessToPosition(Guid requesterKey, Position position);
        void RequestNewPosition(Guid requesterKey, Position position);
        Position GetRandomPosition();
    }
}
