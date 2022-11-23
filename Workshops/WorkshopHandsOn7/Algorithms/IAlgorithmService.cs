using System;

namespace WorkshopHandsOn7.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(IRobot robot);
        IAlgorithmService SetAlgorithm(AlgorithmTypes type);
    }
}
