using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace PresseMots.Models
{
    public class StoryTag
    {
        public int Id { get; set; }

        public int TagId { get; set; }
        public int StoryId { get; set; }

        // Ajout de "virtual" pour le LazyLoading
        public virtual Tag Tag { get; set; }
        public virtual Story Story { get; set; }
    }
}