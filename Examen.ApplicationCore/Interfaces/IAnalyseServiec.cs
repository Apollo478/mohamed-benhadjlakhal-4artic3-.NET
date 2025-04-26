using Examen.ApplicationCore.Domain;

namespace Examen.ApplicationCore.Interfaces;

public interface IAnalyseServiec
{
   public Dictionary<Bilan, List<Analyse>> GetAbnormalAnalyseByPatientThisYear(int codePatient);
}