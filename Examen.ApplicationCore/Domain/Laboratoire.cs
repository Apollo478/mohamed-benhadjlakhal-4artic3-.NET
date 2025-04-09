namespace Examen.ApplicationCore.Domain;

public class Laboratoire
{
    public string Intitule { get; set; }
    public int LaboratoireId { get; set; }
    public string Localisation { get; set; }

    public List<Infirmier> Infirmiers { get; set; }
    
}               