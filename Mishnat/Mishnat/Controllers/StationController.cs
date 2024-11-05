using Microsoft.AspNetCore.Mvc;
using Mishnat.DTO;
using Mishnat.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mishnat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        readonly StationService _stationService;
        private object result;
        // GET: api/<StationController>
        [HttpGet]
        public ActionResult<List<Station>> GetStations()
        {
            result = _stationService.GetStations();
            if (result == null) return NotFound();
            return Ok(result);
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public ActionResult<Station> GetStationById(string stationId)
        {
            result = _stationService.GetStationById(stationId);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<StationController>
        [HttpPost]
        public ActionResult<bool> AddStation([FromBody] Station station)
        {
            return _stationService.AddStation(station);
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateStation(string id, [FromBody] Station station)
        {
            return _stationService.UpdateStationById(id, station);
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteStation(string id)
        {
            return _stationService.DeleteStation(id);
        }
    }
}
