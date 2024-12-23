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
            student.PublicaNoteInCarnet(numeDisciplina);
        }
        else
        {
            Console.WriteLine("Studentul nu a fost gasit.");
        }
    }
}
