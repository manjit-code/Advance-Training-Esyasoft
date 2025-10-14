using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public abstract class AlarmRule
    {
        public string Name { get; }

        protected AlarmRule(string name)
        {
            Name = name;
        }

        public abstract bool IsTriggered(LoadProfileDay day);

        public virtual string Message(LoadProfileDay day)
        {
            return $"{Name} triggered on {day.Date:yyyy-MM-dd}";
        }
    }

}
