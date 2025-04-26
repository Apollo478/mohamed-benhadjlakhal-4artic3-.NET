using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain;

public class Infirmier
{
    [Key]
    public int InfermierId { get; set; }
    public string NomComplet { get; set; }
    [EnumDataType(typeof(Specialite))]
    public Specialite Specialite { get; set; }
    
    [ForeignKey("Laboratoire")] 
    public int LaboratoireId { get; set; }
    public Laboratoire Laboratoire { get; set; }
    public List<Bilan> Bilans { get; set; }
}