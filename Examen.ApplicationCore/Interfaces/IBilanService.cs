namespace Examen.ApplicationCore.Interfaces;

public interface IBilanService
{
    public double MontantBilan(int codePatient, int infirmierId, DateTime datePrelevement);
}