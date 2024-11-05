using Mishnat.DTO;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class StationService
    {
        public List<Station> Stations { get; set; }
        public List<Station> GetStations() { return Stations; }
        public Station GetStationById(string stationId)
        {
            if (Stations == null) { return null; }
            return Stations.Where(s => s.StationId.Equals(stationId)).FirstOrDefault<Station>();
        }
        public bool UpdateStationById(string stationId, Station  station)
        {
            if (Stations == null) { return false; }
            Station s = Stations.Find(s => s.StationId.Equals(stationId));
            if (s == null) { return false; }
            s = station;
            return true;
        }
        public bool AddStation(Station station)
        {
            Stations.Add(station);
            return true;
        }
        public bool DeleteStation(string stationId)
        {
            if (Stations == null) { return false; }
            Station s = Stations.Find(s => s.StationId.Equals(stationId));
            if (s == null) { return false; }
            Stations.Remove(s);
            return true;
        }
    }
}
