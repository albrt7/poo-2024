namespace ProiectPoo;
class Program
{
    static void Main(string[] args)
    {
        var catalog = new Catalog();

        var student = new Student("Ion Popescu", 2);
        var disciplina = new Disciplina("Matematica", "Obligatorie");
        disciplina.Note.Add(new Nota("Activitate", 9));
        disciplina.Note.Add(new Nota("Examen", 8));

        student.InroleazaDisciplina(disciplina);
        catalog.AdaugaStudent(student);

        catalog.PublicaNote("Ion Popescu", "Matematica");
        Console.WriteLine($"Media anuala: {student.CalculeazaMediaAnuala()}");
    }
}
