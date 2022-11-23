using System;

namespace WorkshopHandsOn9.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(IRobot robot);
        IAlgorithmService SetAlgorithm(AlgorithmTypes type);
    }
}
