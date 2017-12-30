using System.ComponentModel.DataAnnotations;

namespace S.model
{
    public class Features
    {
         public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}