using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class StationService
    {
        public List<Station> Stations { get; set; }
        private static int id = 1;
        public List<Station> GetStations() { return Stations; }

        public Station GetStationById(int stationId)
        {
            if (Stations == null) { return null; }
            return Stations.Where(s => s.StationId==stationId).FirstOrDefault<Station>();
        }
        public bool UpdateStationById(int stationId, Station  station)
        {
            if (Stations == null) { return false; }
            Station s = Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            s = station;
            return true;
        }
        public bool AddStation(Station station)
        {
            if(Stations == null) { return false; }
            station.StationId = id++;
            Stations.Add(station);
            return true;
        }
        public bool DeleteStation(int stationId)
        {
            if (Stations == null) { return false; }
            Station s = Stations.Find(s => s.StationId==stationId);
            if (s == null) { return false; }
            Stations.Remove(s);
            return true;
        }
    }
}
