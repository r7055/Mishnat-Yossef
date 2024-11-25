
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mishnat_Yossef.Data.Repository
{
    internal class StationRepositoryj : IRepository<Station>
    {
        readonly IdataContext _idataContext;
        public StationRepositoryj(IdataContext idataContext)
        {
            _idataContext = idataContext;
        }
        public bool Add(Station station)
        {
            _idataContext.Stations.Add(station);
            return _idataContext.SaveDada(_idataContext.Stations);
        }
        public bool Delete(string id)
        {
           return _idataContext.Stations.Remove(_idataContext.Stations.Find(s=>s.StationId == id))&&
           _idataContext.SaveDada(_idataContext.Stations);
        }
        public Station Get(string id)
        {
            return _idataContext.Stations.Find(s=>s.StationId==id);
        }
        public List<Station> GetAll()
        {
           return _idataContext.Stations;
        }
        public bool Update(string id, Station station)
        {
            Station s = _idataContext.Stations.Find(s => s.StationId == id);
            if (s != null)
            {
                s.Address = station.Address;
                s.Manager = station.Manager;
                s.Name = station.Name;
                s.Time = station.Time;
                return _idataContext.SaveDada(_idataContext.Stations);
            }
            return false;
        }
    }
}
