using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain;

public class Patient
{
    [Length(5,5,ErrorMessage = "Code Patient needs to be 5 characters long")]
    [DataType(DataType.MultilineText)]
    private int CodePatient { get; set; }
    private string EmailPatient { get; set; }
    [DisplayName("")]
    private string Informations { get; set; }
    private string NomComplet { get; set; }
    private string NumeroTel { get; set; }
    private List<Bilan> Bilans { get; set; }
}