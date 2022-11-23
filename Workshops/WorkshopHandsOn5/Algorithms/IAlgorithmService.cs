using System;

namespace WorkshopHandsOn5.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(WorkshopHandsOn5.IRobot robot);
        void SetAlgorithm(AlgorithmTypes type);
    }
}
