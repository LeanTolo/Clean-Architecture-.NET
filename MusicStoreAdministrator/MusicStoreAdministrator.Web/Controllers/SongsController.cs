using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Services;
using MusicStoreAdministrator.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicStoreAdministrator.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISongService _songService;

        public SongsController(ISongService songService, IMapper mapper)
        {
            _songService = songService;
            _mapper = mapper;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SongViewModel>>> Get()
        {
            var songs =
                        await _songService.GetAll();

            var mappedSongs =
                        _mapper.Map<IEnumerable<Song>, IEnumerable<SongViewModel>>(songs);

            return Ok(mappedSongs);
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SongsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
