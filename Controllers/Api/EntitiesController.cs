using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using StoresManagement.Dtos;
using StoresManagement.Models;

namespace StoresManagement.Controllers.Api
{
    public class EntitiesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET /api/Entities
        public IHttpActionResult GetEntities(string query = null)
        {
            var EntitiesQuery = db.Entities
                .Include(c => c.Branches);

            if (!String.IsNullOrWhiteSpace(query))
                EntitiesQuery = EntitiesQuery.Where(c => c.Name.Contains(query));

            var entityDtos = EntitiesQuery
                .ToList()
                .Select(Mapper.Map<Entity, EntityDto>);

            return Ok(entityDtos);
        }

        // GET /api/Entities/1
        public IHttpActionResult GetEntity(int id)
        {
            var entity = db.Entities.SingleOrDefault(c => c.Id == id);

            if (entity == null)
                return NotFound();

            return Ok(Mapper.Map<Entity, EntityDto>(entity));
        }

        // POST /api/Entities
        [HttpPost]
        public IHttpActionResult CreateEntity(EntityDto entityDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var entity = Mapper.Map<EntityDto, Entity>(entityDto);
            db.Entities.Add(entity);
            db.SaveChanges();

            entityDto.Id = entity.Id;
            return Created(new Uri(Request.RequestUri + "/" + entity.Id), entityDto);
        }

        // PUT /api/Entities/1
        [HttpPut]
        public IHttpActionResult UpdateEntity(int id, EntityDto entityDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var entityInDb = db.Entities.SingleOrDefault(c => c.Id == id);

            if (entityInDb == null)
                return NotFound();

            Mapper.Map(entityDto, entityInDb);

            db.SaveChanges();

            return Ok();
        }

        // DELETE /api/Entities/1
        [HttpDelete]
        public IHttpActionResult DeleteEntity(int id)
        {
            var entityInDb = db.Entities.SingleOrDefault(c => c.Id == id);

            if (entityInDb == null)
                return NotFound();

            db.Entities.Remove(entityInDb);
            db.SaveChanges();

            return Ok();
        }

        //// GET: api/Entities
        //public IEnumerable<EntityDto> GetEntities()
        //{
        //    return db.Entities.AsQueryable().Select(Mapper.Map<Entity, EntityDto>);
        //}

        //// GET: api/Entities/5
        //[ResponseType(typeof(Entity))]
        //public IHttpActionResult GetEntity(int id)
        //{
        //    Entity entity = db.Entities.Find(id);
        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(Mapper.Map<Entity, EntityDto>(entity));
        //}

        //// Edit/Update Entity
        //// PUT: api/Entities/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutEntity(int id, Entity entity)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != entity.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(entity).State = Entitiestate.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EntityExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// Create Entity
        //// POST: api/Entities
        //[ResponseType(typeof(EntityDto))]
        //public async Task<IHttpActionResult> PostBook(Entity entity)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Entities.Add(entity);
        //    await db.SaveChangesAsync();

        //    // New code:
        //    // Load author name
        //    // db.Entry(entity).Reference(x => x.Author).Load();

        //    var dto = new EntityDto()
        //    {
        //        Id = entity.Id,
        //        Name = entity.Name
        //    };

        //    return CreatedAtRoute("DefaultApi", new { id = entity.Id }, dto);
        //}

        //// DELETE: api/Entities/5
        //[ResponseType(typeof(Entity))]
        //public IHttpActionResult DeleteEntity(int id)
        //{
        //    Entity entity = db.Entities.Find(id);
        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Entities.Remove(entity);
        //    db.SaveChanges();

        //    return Ok(entity);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EntityExists(int id)
        {
            return db.Entities.Count(e => e.Id == id) > 0;
        }
    }
}