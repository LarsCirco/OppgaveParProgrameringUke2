using LarsTest;
using System.ComponentModel.Design;
using System.Data;
using System.Xml.Linq;
using LarsTest;



var persons = new List<Student>
        {
            new("Ola", "20", "Fotball"),
            new("Nora", "30", "Håndball"),
            new("Espen", "20", "Tennis"),
            new("Tore", "26", "Tennis"),
            new("Geir", "42", "Fotball")
        };

Console.WriteLine("Skriv Fotball, Håndball eller Tennis for å vise påmeldte:");

while (true)
{
    var menyvalg = GoToMeny();

    if (menyvalg == "2")
    {
        FilterCourse(persons);
    }
    else if (menyvalg == "1")
    {
        AddStudent(persons);
    }
    else if (menyvalg == "3")
    {
        DisplayStudents(persons);
    }
}



static string GoToMeny()
{
    Console.WriteLine("Trykk 1 for å legge til bruker");
    Console.WriteLine("Trykk 2 for å filtrere kurs for brukere");
    Console.WriteLine("Trykk 3 for å se alle brukere");
    var menyvalg = Console.ReadLine();
    return menyvalg;
}



static void FilterCourse(List<Student> persons)
{
    var valg = Console.ReadLine();
    Console.WriteLine($"\nDette er de påmeldte for {valg} kurset:");
    foreach (var x in persons)
        if (x.Course == valg)
            Console.WriteLine("- " + x.Name);

    Console.WriteLine("\n\nSkriv Fotball, Håndball eller Tennis for å vise påmeldte,\n" +
                      "eller trykk ENTER for å starte på nytt:");

    if (valg == "")
    {
        Console.Clear();
        Console.WriteLine("Skriv Fotball, Håndball eller Tennis for å vise påmeldte:");
    }
}

static void AddStudent(List<Student> persons)
{
    Console.WriteLine("Skriv inn Navn på ny bruker :");
    var navn = Console.ReadLine();
    Console.WriteLine("Skriv inn Alder : ");
    var age = Console.ReadLine();
    Console.WriteLine("Skriv inn Kurs :");
    var course = Console.ReadLine();
    if (navn != null && age != null && course != null)
    {
        persons.Add(new Student(navn, age, course));

    }
}



static void DisplayStudents(List<Student> persons)
{
    foreach (var student in persons)
    {
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
    }
}
