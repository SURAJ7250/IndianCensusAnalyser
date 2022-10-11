using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser.Using_Census
{
    public class StateCensusDAO
    {
        public string State;
        public long Population;
        public long AreaInSqKm;
        public long DensityPerSqKm;

        public StateCensusDAO(string State, string Population, string AreaInSqKm, string DensityPerSqKm)
        {
            this.State = State;
            this.Population = Convert.ToInt32(Population);
            this.AreaInSqKm = Convert.ToInt32(AreaInSqKm);
            this.DensityPerSqKm = Convert.ToInt32(DensityPerSqKm);
        }
    }
}
