using System;

namespace WorkshopHandsOn10.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(IRobot robot);
        IAlgorithmService SetAlgorithm(AlgorithmTypes type);
    }
}
