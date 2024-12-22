﻿namespace ProiectPoo;
class Program
{
    static void Main(string[] args)
    {
        var catalog = new Catalog();

        var student = new Student("Ion Popescu", 2);
        var student1 = new Student("Ionut Mircescu", 3);
        var student2 = new Student("Maria Albu", 1);
        
        var disciplina = new Disciplina("Matematica", "Obligatorie",2,1);
        var disciplina1 = new Disciplina("POO", "Obligatorie",3,2);
        var disciplina2 = new Disciplina("Matematici Speciale", "Obligatorie",1,2);
        
        disciplina.Note.Add(new Nota("Activitate", 9));
        disciplina.Note.Add(new Nota("Activitate", 6));
        disciplina.Note.Add(new Nota("Activitate", 2));
        
        disciplina1.Note.Add(new Nota("Activitate", 7));
        disciplina1.Note.Add(new Nota("Activitate", 4));
        disciplina1.Note.Add(new Nota("Activitate", 9));
        
        disciplina2.Note.Add(new Nota("Activitate", 10));
        disciplina2.Note.Add(new Nota("Activitate", 3));
        disciplina2.Note.Add(new Nota("Activitate", 5));
        
        disciplina.Note.Add(new Nota("Examen", 8));
        disciplina1.Note.Add(new Nota("Examen", 5));
        disciplina2.Note.Add(new Nota("Examen", 7));

        student.InroleazaDisciplina(disciplina);
        student.InroleazaDisciplina(disciplina1);
        student.InroleazaDisciplina(disciplina2);
        
        student1.InroleazaDisciplina(disciplina);
        student1.InroleazaDisciplina(disciplina1);
        student1.InroleazaDisciplina(disciplina2);
        
        student2.InroleazaDisciplina(disciplina);
        student2.InroleazaDisciplina(disciplina1);
        
        catalog.AdaugaStudent(student);
        catalog.AdaugaStudent(student1);
        catalog.AdaugaStudent(student2);
        

        catalog.PublicaNote("Ion Popescu", "Matematica");
        catalog.PublicaNote("Ionut Mircescu", "Matematici Speciale");
        catalog.PublicaNote("Ionut Mircescu", "POO");
        
        Console.WriteLine($"Media anuala: {student.CalculeazaMediaAnuala()}");
        Console.WriteLine($"Media anuala: {student1.CalculeazaMediaAnuala()}");
        Console.WriteLine($"Media anuala: {student2.CalculeazaMediaAnuala()}");
        
        Console.WriteLine($"Media multianuala: {student1.CalculeazaMediaMultianuala()}");
        Console.WriteLine($"Media multianuala: {student1.CalculeazaMediaMultianuala()}");
        Console.WriteLine($"Media multianuala: {student2.CalculeazaMediaMultianuala()}");
        
        Console.WriteLine("\nVizualizare note pentru anul 2, semestrul 1:");
        student.VizualizeazaNoteAnSemestruDisciplina(2, 1, "Matematica");
        
        Console.WriteLine("\nVizualizare note pentru anul 3, semestrul 2:");
        student.VizualizeazaNoteAnSemestruDisciplina(3, 2, "POO");
        
        
        student.TrimiteContestatie("Matematica");
        student1.TrimiteContestatie("POO");
        
        Console.WriteLine("\nContestatii trimise:");
        student.VizualizeazaContestatii();
        student1.VizualizeazaContestatii();
        
        student.ActualizeazaContestatie("Matematica", "Aprobat", "Nota marita la 10");
        student1.ActualizeazaContestatie("POO", "Respins", "Nota a ramas aceeasi");
        
        Console.WriteLine("\nContestatii actualizate:");
        student.VizualizeazaContestatii();
        student1.VizualizeazaContestatii();
    }
}
