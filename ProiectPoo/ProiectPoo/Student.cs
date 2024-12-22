namespace ProiectPoo;

public class Student
{
    public string Nume { get; set; }
    public int An { get; set; }
    public List<Disciplina> Discipline { get; set; }
    public List<Contestatie> Contestatii { get; set; }

    public Student(string nume, int an)
    {
        Nume = nume;
        An = an;
        Discipline = new List<Disciplina>();
        Contestatii = new List<Contestatie>();
    }

    public void InroleazaDisciplina(Disciplina disciplina)
    {
        Discipline.Add(disciplina);
    }

    public void TrimiteContestatie(string disciplina)
    {
        Contestatii.Add(new Contestatie(disciplina));
    }

    public double CalculeazaMediaAnuala()
    {
        var disciplineObligatoriiSiOptionale = Discipline.Where(d => d.Tip != "Facultativa");
        if (!disciplineObligatoriiSiOptionale.Any()) return 0;

        return disciplineObligatoriiSiOptionale.Average(d => d.CalculeazaMedia());
    }

    public double CalculeazaMediaMultianuala()
    {
        return Discipline.Where(d => d.Tip != "Facultativa").Average(d => d.CalculeazaMedia());
    }
}