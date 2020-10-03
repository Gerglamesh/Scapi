
using System.ComponentModel.DataAnnotations;

namespace SCAPI_Frontend.Models
{
    public class ChordModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BaseNote { get; set; }
        [Required]
        public int FretPosition { get; set; }
        [Required]
        public int StartString { get; set; }
        [Required]
        public string TriadType { get; set; }

        public string ColorNote { get; set; }
        [Required]
        public ChordDiagramModel ChordDiagram { get; set; }
    }
}
