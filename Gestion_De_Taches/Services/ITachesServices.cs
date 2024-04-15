using Gestion_De_Taches.Models;

namespace Gestion_De_Taches.Services
{
    public interface ITachesServices
    {
        IEnumerable<Taches> GetAll();

        Taches GetById (int id);

        void Create (Taches tache);

        void Update (Taches tache);

        void Delete (int Id);
    }
}
