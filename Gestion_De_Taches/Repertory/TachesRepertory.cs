using Gestion_De_Taches.Data;
using Gestion_De_Taches.Models;

namespace Gestion_De_Taches.Repertory
{
    public class TachesRepertory  : ITachesRepertory
    {
        private readonly ApplicationDbContext context;

        public TachesRepertory(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Taches tache)
        {
          context.taches.Add(tache);
        }

        public void Delete(int Id)
        {
            context.Remove(Id);
            context.SaveChanges();
        }

        public IEnumerable<Taches> GetAll()
        {
            return context.taches.ToList();
        }

        public Taches GetById(int Id)
        {
            return context.taches.Find( Id);
        }

        public void Update(Taches tache)
        {
            context.taches.Update(tache);
            context.SaveChanges();
        }
    }
}
