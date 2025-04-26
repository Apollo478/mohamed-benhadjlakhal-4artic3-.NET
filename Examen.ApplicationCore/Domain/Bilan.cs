using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain;

public class Bilan
{
    public DateTime DatePrievement { get; set; }
    public string EmailMedecin { get; set; }
    public bool Paye { get; set; }
    [ForeignKey("Patient")] public int CodePatient { get; set; }
    [ForeignKey("Infirmier")] public int InfirmierId { get; set; }

    public Patient Patient { get; set; }
    public Infirmier Infirmier { get; set; }
}