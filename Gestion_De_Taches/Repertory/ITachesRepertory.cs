using Gestion_De_Taches.Models;

namespace Gestion_De_Taches.Repertory
{
    public interface ITachesRepertory
    {
        IEnumerable<Taches> GetAll();

        Taches GetById(int Id);

        void Create (Taches tache);

        void Update (Taches tache);

        void Delete (int Id);
    }
}
