using System.Collections.Generic;

namespace Develop05 {

    public abstract class Goal {

        protected string _name;
        protected string _description;
        protected int _pointsPer;

        public Goal(string name, string description, int pointsPer) {
            _name = name;
            _description = description;
            _pointsPer = pointsPer;

        }

        public string GetName() {
            return _name;
        }

        public virtual int GetPoints() {
            return _pointsPer;
        }

        public abstract int CalculateScore();

        public abstract void Complete();

        public abstract string GetInfo();

        public abstract string Serialize();

    }
}