using Mishnat.DTO;
using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class StationService
    {
        
        private static int id = 1;
        public List<Station> GetStations() { return DataContext.Stations; }

        public Station GetStationById(int stationId)
        {
            if (DataContext.Stations == null) { return null; }
            return DataContext.Stations.Where(s => s.StationId==stationId).FirstOrDefault<Station>();
        }
        public bool UpdateStationById(int stationId, Station  station)
        {
            if (DataContext.Stations == null) { return false; }
            Station s = DataContext.Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            s.Address = station.Address;
            s.Manager=station.Manager;
            s.Name = station.Name;
            s.Time = station.Time;  
            return true;
        }
        public bool AddStation(Station station)
        {
            if(DataContext.Stations == null) { return false; }
            station.StationId = id++;
            DataContext.Stations.Add(station);
            return true;
        }
        public bool DeleteStation(int stationId)
        {
            if (DataContext.Stations == null) { return false; }
            Station s = DataContext.Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            DataContext.Stations.Remove(s);
            return true;
        }
    }
}
