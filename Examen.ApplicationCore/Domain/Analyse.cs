using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.ApplicationCore.Domain;

public class Analyse
{
    public int AnalyseId { get; set; }
    public int DureeResultat { get; set; }
    public double PrixAnalyse { get; set; }
    public string TypeAnalyse { get; set; }
    public float ValeurAnalyse { get; set; }
    public float ValeurMaxNormale { get; set; }
    public float ValeurMinNormale { get; set; }
    [ForeignKey("Bilan")] public int BilanId { get; set; }
    public Bilan Bilan { get; set; }
    
}