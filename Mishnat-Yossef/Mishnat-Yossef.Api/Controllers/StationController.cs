using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceService;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        readonly IStationService _stationService;
        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }
        // GET: api/<StationController>
        [HttpGet]
        public ActionResult<List<Station>> GetStations()
        {
            var result = _stationService.GetAll();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public ActionResult<Station> GetStationById(int stationId)
        {
            if (stationId == null)
                return BadRequest();
            var result = _stationService.Get(stationId);
            if (result == null)
                return NotFound();
            return result;
        }

        // POST api/<StationController>
        [HttpPost]
        public ActionResult<bool> AddStation([FromBody] Station station)
        {
            return _stationService.Add(station);
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateStation(int id, [FromBody] Station station)
        {
            if (id == null) return BadRequest();
            return _stationService.Update(id, station);
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteStation(int id)
        {
            if (id == null)
                return BadRequest();
            return _stationService.Delete(id);
        }
    }
}
