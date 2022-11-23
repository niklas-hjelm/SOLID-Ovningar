using System;

namespace WorkshopHandsOn11.Algorithms
{
    public interface IAlgorithmService
    {
        void Execute(IRobot robot);
        IAlgorithmService SetAlgorithm(AlgorithmTypes type);
    }
}
