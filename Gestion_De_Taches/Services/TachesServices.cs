using Gestion_De_Taches.Models;
using Gestion_De_Taches.Repertory;

namespace Gestion_De_Taches.Services
{
    public class TachesServices : ITachesServices
    {
        private readonly ITachesRepertory repertory;

        public TachesServices(ITachesRepertory repertory)
        {
            this.repertory = repertory;
        }

        public void Create(Taches tache)
        {
          repertory.Create(tache);
        }

        public void Delete(int Id)
        {
            repertory.Delete(Id);
        }

        public IEnumerable<Taches> GetAll()
        {
            return repertory.GetAll();
        }

        public Taches GetById(int id)
        {
           return repertory.GetById(id);
        }

        public void Update(Taches tache)
        {
            repertory.Update(tache);
        }
    }
}
