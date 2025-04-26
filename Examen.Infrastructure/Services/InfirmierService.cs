using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.Infrastructure.Services;

public class InfirmierService: IInfirmierService
{
    private readonly ExContext _exContext;

    public InfirmierService(ExContext exContext)
    {
        _exContext = exContext;
    }

    public double SpecPercentage(Specialite specialite)
    {
        int totInf = _exContext.Infirmiers.Count();
        int specInfo = _exContext.Infirmiers.Where(i => i.Specialite.Equals(specialite)).ToList().Count();
        return (specInfo * 100) / totInf;
    }
}