using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain;

public class Infirmier
{
    private int InfermierId { get; set; }
    private string NomComplet { get; set; }
    [EnumDataType(typeof(Specialite))]
    private Specialite Specialite { get; set; }
    
    [ForeignKey("Laboratoire")] 
    private int LaboratoireId { get; set; }
    private Laboratoire Laboratoire { get; set; }
}