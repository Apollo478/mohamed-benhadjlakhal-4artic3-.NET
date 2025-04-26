using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain;

public class Patient
{
    [Length(5,5,ErrorMessage = "Code Patient needs to be 5 characters long")]
    [DataType(DataType.MultilineText)]
    [Key]
    public int CodePatient { get; set; }
    public string EmailPatient { get; set; }
    [DisplayName("")]
    public string Informations { get; set; }
    public string NomComplet { get; set; }
    public string NumeroTel { get; set; }
    public List<Bilan> Bilans { get; set; }
}