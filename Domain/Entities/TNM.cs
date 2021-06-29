
namespace Domain.Entities
{
    public class TNM
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string ShortNameOfTopography { get; set; }
        public string Icdotopography { get; set; }
        public string Morphology { get; set; }
        public string Stage { get; set; }
        public string Tumor { get; set; }
        public string Nodus { get; set; }
        public int TumorId { get; set; }
        
        public string Metastasis { get; set; }
        public int MetastasisId { get; set; }
        public int Version { get; set; }
        public int Classification { get; set; }
        #nullable enable 
        public int? NodusId { get; set; }

        
    }
}