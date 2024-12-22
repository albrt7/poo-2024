namespace ProiectPoo;

public class Catalog
{
    private List<Student> studenti;

    public Catalog()
    {
        studenti = new List<Student>();
    }

    public void AdaugaStudent(Student student)
    {
        studenti.Add(student);
    }

    public Student GasesteStudent(string nume)
    {
        return studenti.FirstOrDefault(s => s.Nume == nume);
    }

    public void PublicaNote(string numeStudent, string numeDisciplina)
    {
        var student = GasesteStudent(numeStudent);
        if (student != null)
        {
            var disciplina = student.Discipline.FirstOrDefault(d => d.Nume == numeDisciplina);
            if (disciplina != null)
            {
                Console.WriteLine($"Note publicate pentru {numeDisciplina}:\n");
                foreach (var nota in disciplina.Note)
                {
                    Console.WriteLine($"{nota.Tip}: {nota.Valoare}");
                }
            }
            else
            {
                Console.WriteLine("Disciplina nu a fost gasita.");
            }
        }
        else
        {
            Console.WriteLine("Studentul nu a fost gasit.");
        }
    }
}
