using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT7
{
    [Serializable]
    public class ExpertSystemData
    {
        public List<Proposition> Propositions = new List<Proposition>();
        public List<Outcome> Outcomes = new List<Outcome>();
        public List<int> rules = new List<int>();
    }

}
