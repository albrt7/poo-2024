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

        public void ActualizeazaContestatie(string disciplina, string status, string rezultat)
        {
            var contestatie = Contestatii.FirstOrDefault(c => c.Disciplina == disciplina && c.Status == "In asteptare");
            if (contestatie != null)
            {
                contestatie.Status = status;
                contestatie.Rezultat = rezultat;
            }
        }

        public void VizualizeazaContestatii()
        {
            Console.WriteLine("Lista contestatii:");
            foreach (var contestatie in Contestatii)
            {
                Console.WriteLine($"Disciplina: {contestatie.Disciplina}, Status: {contestatie.Status}, Rezultat: {contestatie.Rezultat}");
            }
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

        public void VizualizeazaNoteAnSemestruDisciplina(int an, int semestru, string disciplina)
        {
            var disciplineFiltrate = Discipline.Where(d => (an == 0 || d.An == an) && (semestru == 0 || d.Semestru == semestru) && (string.IsNullOrEmpty(disciplina) || d.Nume == disciplina));

            foreach (var disc in disciplineFiltrate)
            {
                Console.WriteLine($"Disciplina: {disc.Nume}, An: {disc.An}, Semestru: {disc.Semestru}");
                foreach (var nota in disc.Note)
                {
                    Console.WriteLine($"  {nota.Tip}: {nota.Valoare}");
                }
            }
        }

        public void PublicaNoteInCarnet(string numeDisciplina)
        {
            var disciplina = Discipline.FirstOrDefault(d => d.Nume == numeDisciplina);
            if (disciplina != null)
            {
                Console.WriteLine($"Note publicate pentru {numeDisciplina}:");
                foreach (var nota in disciplina.Note)
                {
                    Console.WriteLine($"  {nota.Tip}: {nota.Valoare}");
                }
            }
            else
            {
                Console.WriteLine("Disciplina nu a fost gasita.");
            }
        }
        public double CalculeazaMediaDisciplina(string numeDisciplina)
        {
            var disciplina = Discipline.FirstOrDefault(d => d.Nume == numeDisciplina);
            if (disciplina != null)
            {
                return disciplina.CalculeazaMedia();
            }
            return 0;
        }
    }
    