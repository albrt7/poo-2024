namespace ProiectPoo;
class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();
            var studentPredefinit = new Student("beto", 2);

            var disciplina1 = new Disciplina("Matematica", "Obligatorie", 1, 1);
            disciplina1.Note.Add(new Nota("Activitate", 4));
            disciplina1.Note.Add(new Nota("Examen",5));
            disciplina1.Note.Add(new Nota("Activitate",10));

            var disciplina2 = new Disciplina("Programare", "Obligatorie", 1, 2);
            disciplina2.Note.Add(new Nota("Activitate", 5));
            disciplina2.Note.Add(new Nota("Examen",9));
            disciplina2.Note.Add(new Nota("Activitate",3));
            
            var disciplina3 = new Disciplina("POO", "Obligatorie", 2, 1);
            disciplina3.Note.Add(new Nota("Activitate", 5));
            disciplina3.Note.Add(new Nota("Examen",5));
            disciplina3.Note.Add(new Nota("Activitate",7));

            var disciplina4 = new Disciplina("PCDD", "Obligatorie", 2, 2);
            disciplina4.Note.Add(new Nota("Activitate", 5));
            disciplina4.Note.Add(new Nota("Examen",7));
            disciplina4.Note.Add(new Nota("Activitate",8));


            studentPredefinit.InroleazaDisciplina(disciplina1);
            studentPredefinit.InroleazaDisciplina(disciplina2);
            studentPredefinit.InroleazaDisciplina(disciplina3);
            studentPredefinit.InroleazaDisciplina(disciplina4);

            catalog.AdaugaStudent(studentPredefinit);
            

            while (true)
            {
                Console.WriteLine("\n===== Meniu Principal =====");
                Console.WriteLine("1. Adauga student");
                Console.WriteLine("2. Inroleaza disciplina pentru un student");
                Console.WriteLine("3. Publica notele unui student pentru o disciplina");
                Console.WriteLine("4. Vizualizeaza note");
                Console.WriteLine("5. Trimite contestatie");
                Console.WriteLine("6. Vizualizeaza contestatii");
                Console.WriteLine("7. Actualizeaza contestatie");
                Console.WriteLine("8. Calculeaza media anuala");
                Console.WriteLine("9. Calculeaza media multianuala");
                Console.WriteLine("10. Calculează media la o disciplină.");

                Console.WriteLine("0. Iesire");

                Console.Write("Alege o optiune: ");
                var optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        Console.Write("Numele studentului: ");
                        var nume = Console.ReadLine();
                        Console.Write("Anul studentului: ");
                        var an = int.Parse(Console.ReadLine());
                        catalog.AdaugaStudent(new Student(nume, an));
                        Console.WriteLine("Student adaugat cu succes!");
                        break;

                    case "2":
                        Console.Write("Numele studentului: ");
                        var numeStudent = Console.ReadLine();
                        var student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.Write("Numele disciplinei: ");
                            var numeDisciplina = Console.ReadLine();
                            Console.Write("Tipul disciplinei (Obligatorie/Optionala/Facultativa): ");
                            var tipDisciplina = Console.ReadLine();
                            Console.Write("Anul disciplinei: ");
                            var anDisciplina = int.Parse(Console.ReadLine());
                            Console.Write("Semestrul disciplinei: ");
                            var semestruDisciplina = int.Parse(Console.ReadLine());
                            var disciplina = new Disciplina(numeDisciplina, tipDisciplina, anDisciplina, semestruDisciplina);
                            student.InroleazaDisciplina(disciplina);
                            Console.WriteLine("Disciplina inrolata cu succes!");
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "3":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        Console.Write("Numele disciplinei: ");
                        var numeDisciplinaPublicare = Console.ReadLine();
                        catalog.PublicaNote(numeStudent, numeDisciplinaPublicare);
                        break;

                    case "4":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.Write("Anul (0 pentru toti anii): ");
                            var anVizualizare = int.Parse(Console.ReadLine());
                            Console.Write("Semestrul (0 pentru toti semestrii): ");
                            var semestruVizualizare = int.Parse(Console.ReadLine());
                            Console.Write("Disciplina (lasati gol pentru toate disciplinele): ");
                            var disciplinaVizualizare = Console.ReadLine();
                            student.VizualizeazaNoteAnSemestruDisciplina(anVizualizare, semestruVizualizare, disciplinaVizualizare);
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "5":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.Write("Numele disciplinei: ");
                            var disciplinaContestatie = Console.ReadLine();
                            student.TrimiteContestatie(disciplinaContestatie);
                            Console.WriteLine("Contestatie trimisa cu succes!");
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "6":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            student.VizualizeazaContestatii();
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "7":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.Write("Numele disciplinei: ");
                            var disciplinaContestatieUpdate = Console.ReadLine();
                            Console.Write("Statusul contestației (Aprobat/Respins): ");
                            var status = Console.ReadLine();
                            Console.Write("Rezultatul contestației: ");
                            var rezultat = Console.ReadLine();
                            student.ActualizeazaContestatie(disciplinaContestatieUpdate, status, rezultat);
                            Console.WriteLine("Contestatie actualizata cu succes!");
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "8":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.WriteLine($"Media anuala: {student.CalculeazaMediaAnuala()}");
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;

                    case "9":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.WriteLine($"Media multianuala: {student.CalculeazaMediaMultianuala()}");
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost gasit.");
                        }
                        break;
                    case "10":
                        Console.Write("Numele studentului: ");
                        numeStudent = Console.ReadLine();
                        student = catalog.GasesteStudent(numeStudent);
                        if (student != null)
                        {
                            Console.Write("Numele disciplinei: ");
                            string numeDisciplina = Console.ReadLine();
                            var disciplina = student.Discipline.FirstOrDefault(d => d.Nume.Equals(numeDisciplina, StringComparison.OrdinalIgnoreCase));
                            if (disciplina != null)
                            {
                                Console.WriteLine($"Media la disciplina {numeDisciplina} este: {disciplina.CalculeazaMedia()}");
                            }
                            else
                            {
                                Console.WriteLine("Disciplina nu a fost găsită.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Studentul nu a fost găsit.");
                        }
                        break;


                    case "0":
                        Console.WriteLine("Iesire din aplicatie.");
                        return;

                    default:
                        Console.WriteLine("Optiune invalida. Te rog sa incerci din nou.");
                        break;
                }
            }
        }
    }