using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Zueira.Data.Respositories;
using Zueira.Domain.Entities;
using Zueira.WebAPI.Models;

namespace Zueira.WebAPI.Controllers
{
    public class AssuntosController : ApiController
    {
        private readonly AssuntoRepository _assuntoRepository = new AssuntoRepository();
        // GET: api/assuntos
        [ResponseType(typeof(List<AssuntoModel>))]
        public IHttpActionResult GetAll()
        {
            var assuntos = Mapper.Map<IEnumerable<Assunto>, IEnumerable<AssuntoModel>>(_assuntoRepository.GetAll());
            return Ok(assuntos);
        }

        // GET: api/assuntos/1
        [ResponseType(typeof(AssuntoModel))]
        public IHttpActionResult Get(int id)
        {
            var assunto = Mapper.Map<Assunto, AssuntoModel>(_assuntoRepository.GetById(id));
            return Ok(assunto);
        }

        // PUT: api/assuntos/1
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, AssuntoModel assuntoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var assunto = Mapper.Map<AssuntoModel, Assunto>(assuntoModel);

            _assuntoRepository.Update(assunto);

            return Ok();
        }

        // POST: api/assunto
        [ResponseType(typeof(void))]
        public IHttpActionResult Post(AssuntoModel assuntoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var assunto = Mapper.Map<AssuntoModel, Assunto>(assuntoModel);

            _assuntoRepository.Add(assunto);

            return StatusCode(HttpStatusCode.Created);
        }

        // DELETE: api/assunto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            _assuntoRepository.Remove(id);
            return Ok();
        }
    }
}
