using AutoMapper;
using FarmaciaFinal.Dtos;
using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace FarmaciaFinal.Controllers.api
{
    public class OrdenVentasController : ApiController
    {
        private ApplicationDbContext _context;

        public OrdenVentasController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/ordenventas
        public IEnumerable<OrdenVentaDto> GetOrdenVentas()
        {
            return _context.OrdenesVenta.ToList().Select(Mapper.Map<OrdenVenta, OrdenVentaDto>);
        }

        // GET /api/ordenesventas/1
        public IHttpActionResult GetOrdenVenta(int id)
        {
            var orden = _context.OrdenesVenta.SingleOrDefault(c => c.Id == id);

            if (orden == null)
                return NotFound();

            return Ok(Mapper.Map<OrdenVenta, OrdenVentaDto>(orden));
        }

        // POST /api/ordenesventas
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateOrdenVenta(OrdenVentaDto ordenVentaDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var orden = Mapper.Map<OrdenVentaDto, OrdenVenta>(ordenVentaDto);
            _context.OrdenesVenta.Add(orden);
            _context.SaveChanges();

            ordenVentaDto.Id = orden.Id;
            return Created(new Uri(Request.RequestUri + "/" + orden.Id), ordenVentaDto);
        }

        // PUT /api/OrdenVentas/1
        [System.Web.Http.HttpPut]
        public void UpdateOrdenVenta(int id, OrdenVentaDto OrdenVentaDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var OrdenVentaInDb = _context.OrdenesVenta.SingleOrDefault(c => c.Id == id);

            if (OrdenVentaInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(OrdenVentaDto, OrdenVentaInDb);

            _context.SaveChanges();
        }

        // DELETE /api/OrdenVentas/1
        [System.Web.Http.HttpDelete]
        public void DeleteOrdenVenta(int id)
        {
            var OrdenVentaInDb = _context.OrdenesVenta.SingleOrDefault(c => c.Id == id);

            if (OrdenVentaInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.OrdenesVenta.Remove(OrdenVentaInDb);
            _context.SaveChanges();
        }

    }
}