using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetCore.model;

namespace dotnetCore.model
{
    [Table("Makes")]
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IList<Model> Models { get; set; }

        public Make()
        {
            Models = new List<Model>();
        }
    }
}