namespace Examen.ApplicationCore.Domain;

public class Patient
{
    private int Codeatient { get; set; }
    private string EmailPatient { get; set; }
    private string Informations { get; set; }
    private string NomComplet { get; set; }
    private string NumeroTel { get; set; }
    private List<Bilan> Bilans { get; set; }
}