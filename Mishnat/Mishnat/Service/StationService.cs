using Mishnat.DTO;
using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class StationService
    {
        
        private static int id = 1;
        public List<Station> GetStations() { return DataContextManager.Manager.Stations; }

        public Station GetStationById(int stationId)
        {
            if (DataContextManager.Manager.Stations == null) { return null; }
            return DataContextManager.Manager.Stations.Where(s => s.StationId==stationId).FirstOrDefault<Station>();
        }
        public bool UpdateStationById(int stationId, Station  station)
        {
            if (DataContextManager.Manager.Stations == null) { return false; }
            Station s = DataContextManager.Manager.Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            s.Address = station.Address;
            s.Manager=station.Manager;
            s.Name = station.Name;
            s.Time = station.Time;  
            return true;
        }
        public bool AddStation(Station station)
        {
            if(DataContextManager.Manager.Stations == null) { return false; }
            station.StationId = id++;
            DataContextManager.Manager.Stations.Add(station);
            return true;
        }
        public bool DeleteStation(int stationId)
        {
            if (DataContextManager.Manager.Stations == null) { return false; }
            Station s = DataContextManager.Manager.Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            DataContextManager.Manager.Stations.Remove(s);
            return true;
        }
    }
}
