using System;
using WorkshopHandsOn2.Log_Strategies;
using WorkshopHandsOn2.ValueObjects;

namespace WorkshopHandsOn2
{
    public class Robot : IRobot
    {
        private ILogService _logger;
        private Position _position = Position.Create();

        public static IRobot Create(ILogService logger)
        {
            return new Robot(logger);
        }
        private Robot(ILogService logger)
        {
            this._logger = logger;
        }
        public void MoveTo(Position position)
        {
            this._position = Position.Create(position);
            string message = string.Format("Robot moved to Position({0},{1}).", this._position.X, this._position.Y);
            this._logger.Log(message);
        }
        public void Release()
        {
            string message = string.Format("Robot sat down the box on Position({0},{1}).", this._position.X, this._position.Y);
            this._logger.Log(message);
        }
        public void Grab()
        {
            string message = string.Format("Robot picked up the box on Position({0},{1}).", this._position.X, this._position.Y);
            this._logger.Log(message);
        }
        public Position CurrentPosition()
        {
            return this._position;
        }
    }
}
