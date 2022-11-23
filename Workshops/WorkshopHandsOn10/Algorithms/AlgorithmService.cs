using System;
using System.Collections.Generic;

namespace WorkshopHandsOn10.Algorithms
{
    public class AlgorithmService : IAlgorithmService 
    {
        private IDictionary<AlgorithmTypes, Type> _actions = new Dictionary<AlgorithmTypes, Type>();
        private AlgorithmTypes _current = AlgorithmTypes.MoveBox;

        private AlgorithmService()
            : this(AlgorithmTypes.MoveBox)
        {
        }
        private AlgorithmService(AlgorithmTypes type)
        {
            this.SetupActions();
            this._current = type;
        }
        public static AlgorithmService Create()
        {
            return new AlgorithmService();
        }
        public static AlgorithmService Create(AlgorithmTypes type)
        {
            return new AlgorithmService(type);
        }
        private void SetupActions()
        {
            this._actions.Add(AlgorithmTypes.Cleaning, typeof(CleaningAlgorithm));
            this._actions.Add(AlgorithmTypes.GetBeer, typeof(GetBeerAlgorithm));
            this._actions.Add(AlgorithmTypes.MoveBox, typeof(MoveBoxAlgorithm));
        }
        public IAlgorithmService SetAlgorithm(AlgorithmTypes type)
        {
            this._current = type;
            return this;
        }     
        public void Execute(IRobot robot)
        {
            robot.SetPowerOn();

            IRobotAlgorithm strategy = (IRobotAlgorithm)Activator.CreateInstance(this._actions[_current]);
            strategy.Execute(robot);

            robot.SetPowerOff();
        }
    }
}
