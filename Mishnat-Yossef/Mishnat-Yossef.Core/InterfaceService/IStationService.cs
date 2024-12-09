using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceService
{
    public interface IStationService
    {
        public List<Station> GetAll();
        public Station Get(int id);
        public bool Add(Station station);
        public bool Update(int id, Station   station);
        public bool Delete(int id);
    }
}
