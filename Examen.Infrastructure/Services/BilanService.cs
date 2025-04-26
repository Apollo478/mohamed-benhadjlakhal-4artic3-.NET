using System.Runtime.InteropServices.ComTypes;
using Examen.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure.Services;

public class BilanService : IBilanService
{
    private readonly ExContext _exContext;

    public BilanService(ExContext exContext)
    {
        _exContext = exContext;
    }

    public double MontantBilan(int codePatient, int infirmierId, DateTime datePrelevement)
    {
        var bilan = _exContext.Bilans
            .FirstOrDefault(b =>
                b.DatePrievement == datePrelevement && b.CodePatient == codePatient && b.InfirmierId == infirmierId);
        var analyse = _exContext.Analyses
            .Where(a => a.Bilan.CodePatient == codePatient && a.Bilan.InfirmierId == infirmierId &&
                        a.Bilan.DatePrievement == datePrelevement).ToList();
        if (!analyse.Any())
            return 0;
        double sum = 0;
        analyse.ForEach(e => sum+= e.PrixAnalyse);
        if (analyse.Count() >= 5)
        {
            return sum * 0.9;
        }

        return sum;
    }
}