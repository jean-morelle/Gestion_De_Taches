using Gestion_De_Taches.Models;
using Gestion_De_Taches.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_De_Taches.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TachesController : ControllerBase
    {
        private readonly ITachesServices services;

        public TachesController(ITachesServices services)
        {
            this.services = services;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var GetTaches = services.GetAll();

            if (GetTaches is null || !GetTaches.Any())
            {
                throw new Exception("Aucune donnee dans la base de donnees Taches");
            }

            return Ok (GetTaches);
        }

        [HttpGet("{id}")]

        public IActionResult GetId(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var GetTachesById = services.GetById(id);

            if (GetTachesById is null)
            {
                return NotFound();
            }

            return Ok(GetTachesById);

        }
        [HttpPost]

       public IActionResult Post (Taches newTache)
        {
            if (!ModelState.IsValid)
            {
                // Si les données ne sont pas valides, renvoyer une réponse BadRequest avec les erreurs de validation
                return BadRequest(ModelState);
            }
            var getTacheId = services.GetById(newTache.Id);

            if (getTacheId != null)
            {
                // Si l'utilisateur existe déjà, renvoyer une réponse Conflict avec un message approprié
                return Conflict("Un utilisateur avec ce nom d'utilisateur existe déjà.");
            }
            services.Create(newTache);
            return CreatedAtAction(nameof(getTacheId), new { id = newTache.Id }, newTache);
        }

        [HttpDelete]

        public IActionResult Delete (int id)
        {
            var existingTache = services.GetById(id);
            if (existingTache == null)
            {
                return NotFound();
            }

            services.Delete(id);
            return NoContent();
        }

        [HttpPatch]

        public IActionResult Update(int id ,Taches newTache)
        {
            if (id <= 0)
            {
                BadRequest("L Id fournie pas l utilisateur n est pas valide");
            }
            // Recuperer l utilisateur dans la base de donner 
            var existingTaches = services.GetById(id);
            //Si l utilisateur n existe pas il me renvoie l 
            //erreur 404 aucun utilisateur trouver avec l Id specifier
            if (existingTaches is null)
            {
                NotFound("Aucun utilisateur trouver avec l Id specifier");
            }


            services.Update(newTache);

            //retourne une reponse que la mise a jours a reussie
            return Ok();

        }
    
    }
}
 