
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
    public class StationRepository : IRepository<Station>
    {
        readonly DataContext _idataContext;
        public StationRepository(DataContext idataContext)
        {
            _idataContext = idataContext;
        }
        public bool Add(Station station)
        {
            try
            {
                _idataContext.Stations.Add(station);
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Delete(int id)
        {
            try
            {
                _idataContext.Stations.Remove(Get(id));
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Station Get(int id)
        {
            return _idataContext.Stations.Find(id);
        }
        public List<Station> GetAll()
        {
            return _idataContext.Stations.ToList();
        }
        public bool Update(int id, Station station)
        {
            Station s = _idataContext.Stations.Find(id);
            if (s == null) return false;
            try
            {
                s.Address = station.Address == null ? s.Address : station.Address;
                s.Manager = station.Manager == null ? s.Manager : station.Manager;
                s.Name = station.Name == null ? s.Name : station.Name;
                s.Time = station.Time == null ? s.Time : station.Time;
                _idataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }

    }
}

