
namespace SCAPI_Frontend.Models
{
    public class ChordModel
    {
        public int Id { get; set; }
        public string BaseNote { get; set; }
        public int FretPosition { get; set; }
        public int StartString { get; set; }
        public string TriadType { get; set; }
        public string ColorNote { get; set; }
        public ChordDiagramModel ChordDiagram { get; set; }
    }
}
