namespace Gestion_De_Taches.Models
{
    public class Taches
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime Date { get; set; }

        public string AssignedTo { get; set; }//Personne assignees

        public int Priority { get; set; } //Priorite

        public DateTime CreatedAt { get; set; }//date de creation

        public DateTime UpdatedAt { get; set; }//date de la derniere mise a jours 
    }
}
