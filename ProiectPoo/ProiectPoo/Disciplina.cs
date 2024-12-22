namespace ProiectPoo;

public class Disciplina
{
    public string Nume { get; set; }
    public string Tip { get; set; }
    public List<Nota>Note { get; set; }

    public Disciplina(string nume, string tip)
    {
        Nume = nume;
        Tip = tip;
        Note = new List<Nota>();
    }

    public double CalculeazaMedia()
    {
        if(Note.Count == 0)
            return 0;
        return Note.Average(n => n.Valoare);
    }
}