using System.Collections.Generic;
using System.Linq;
using WorkshopHandsOn11;
using WorkshopHandsOn11.Rules;

namespace WorkshopHandsOn11.Validation
{
    public class RobotValidator : IValidator<IRobot>
    {
        private IEnumerable<IRule<IRobotState>> _rules;

        protected RobotValidator(IEnumerable<IRule<IRobotState>> rules)
        {
            this._rules = rules;
        }
        public static IValidator<IRobot> Create()
        {
            return new RobotValidator(SetupRules());
        }
        public bool IsValid(IRobot robot)
        {
            return this.BrokenRules(robot).Count() == 0;
        }
        public IEnumerable<string> BrokenRules(IRobot robot)
        {
            foreach (IRule<IRobotState> r in this._rules)
            {
                if (!r.Condition.Compile().Invoke(robot))
                    yield return r.Message;
            };
        }
        private static IEnumerable<IRule<IRobotState>> SetupRules()
        {
            IList<IRule<IRobotState>> rules = new List<IRule<IRobotState>>();
            rules.Add(new PowerOnRule());
            rules.Add(new NotAllowedToWalkRule());
            return rules;
        }
    }
}