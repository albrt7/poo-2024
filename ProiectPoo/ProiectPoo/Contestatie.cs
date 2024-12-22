namespace ProiectPoo;
public class Contestatie
{
    public string Disciplina { get; set; }
    public string Status { get; set; } // In asteptare, Aprobat, Respins
    public string Rezultat { get; set; }

    public Contestatie(string disciplina)
    {
        Disciplina = disciplina;
        Status = "In asteptare";
        Rezultat = "";
    }
}