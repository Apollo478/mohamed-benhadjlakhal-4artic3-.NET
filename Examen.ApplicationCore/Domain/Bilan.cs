using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain;

public class Bilan
{
    private DateTime DatePrievement { get; set; }
    private string EmailMedecin { get; set; }
    private bool Paye { get; set; }
    [ForeignKey("Patient")] private int CodePatient { get; set; }
    [ForeignKey("Infirmier")] private int InfirmierId { get; set; }

    private Patient Patient { get; set; }
    private Infirmier Infirmier { get; set; }
}