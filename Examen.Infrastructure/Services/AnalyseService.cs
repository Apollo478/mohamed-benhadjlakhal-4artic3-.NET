using System.Runtime.InteropServices.JavaScript;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure.Services;

public class AnalyseService : IAnalyseServiec
{
    private readonly ExContext _exContext;

    public AnalyseService(ExContext exContext)
    {
        _exContext = exContext;
    }

    public Dictionary<Bilan, List<Analyse>> GetAbnormalAnalyseByPatientThisYear(int codePatient)
    {
        var currentYear = DateTime.Now.Year;
        var result = _exContext.Analyses.Include(a => a.Bilan)
            .Where(a => a.Bilan.CodePatient == codePatient
                        && a.Bilan.DatePrievement.Year == currentYear && (a.ValeurAnalyse > a.ValeurMaxNormale ||
                                                                          a.ValeurAnalyse < a.ValeurMinNormale))
            .GroupBy(a => a.Bilan)
            .ToDictionary(g => g.Key, g => g.ToList());
        return result;
    }
}