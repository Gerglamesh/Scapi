using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SCAPI_Frontend.Models
{
    [Owned]
    public class ChordDiagramModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
    }
}
