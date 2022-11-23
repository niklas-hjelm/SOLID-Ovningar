using System;

namespace WorkshopHandsOn6.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(IRobot robot);
        IAlgorithmService SetAlgorithm(AlgorithmTypes type);
    }
}
