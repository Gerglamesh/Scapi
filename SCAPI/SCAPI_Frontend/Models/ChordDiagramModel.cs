using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCAPI_Frontend.Models
{
    public class ChordDiagramModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ChordId")]
        public int ChordId { get; set; }
        public ChordModel Chord { get; set; }

        [Required]
        public string Path { get; set; }
    }
}
