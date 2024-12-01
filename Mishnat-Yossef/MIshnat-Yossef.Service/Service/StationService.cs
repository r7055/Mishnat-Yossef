using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIshnat_Yossef.Service.Service
{
    public class StationServicse : IStationService
    {
        readonly IRepository<Station> _stationRepository;
        public StationServicse(IRepository<Station> repository)
        {
            _stationRepository = repository;
        }
        public bool Add(Station station)
        {
            if (station == null) { return false; }
            return _stationRepository.Add(station);
        }

        public bool Delete(string id)
        {
            return _stationRepository.Delete(id);
        }

        public Station Get(string id)
        {
            return _stationRepository.Get(id); 
        }

        public List<Station> GetAll()
        {
           if(_stationRepository.GetAll() == null) { return new List<Station>(); }
           return _stationRepository.GetAll();
        }

        public bool Update(string id, Station station)
        {
           if(station  == null) { return false; }   
           return _stationRepository.Update(id, station);
        }

        
    }
}
