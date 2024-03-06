using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

class Program
{
    static void DisStudent()
    {
        List<Student> students = Query.GetAllStudent();
        foreach (var item in students)
        {
            System.Console.WriteLine($"{item.Mssv} - {item.Mssv} - {item.Name} - {item.TPoint}");
        }
    }
    static void DisAccount()
    {
        List<Account> accounts = Query.GetAllAccount();
        foreach (var item in accounts)
        {
            System.Console.WriteLine($"{item.Id} - {item.Username} - {item.Password}");
        }
    }
    static void DisSight()
    {
        List<Sight> sights = Query.GetAllSight();
        foreach (var item in sights)
        {
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Preview);
        }
        Sight? sight = Query.GetSpecificSight(1);
        if (sight == null) return;
        Console.WriteLine(sight.Name);
        Console.WriteLine(sight.Preview);
        if (sight.Questions == null)
        {
            System.Console.WriteLine("No questions here");
            return;
        }
        foreach (var item in sight.Questions)
        {
            System.Console.WriteLine(item.Content);
            var question = Database.Query<Question>(item.Id);
            if (question == null)
            {
                System.Console.WriteLine("question no here");
                return;
            }
            foreach (var answer in question.Answers)
            {
                System.Console.WriteLine(">>" + answer.Content);
                Console.WriteLine($"Đáp án đúng là: {answer.IsKeyAnswer}");
            }
        }
    }
    static void SignIn()
    {
        var acc = Query.SignIn("31221020084", "");
        if (acc == null) System.Console.WriteLine("not found"); ;
        System.Console.WriteLine(acc.Name);
    }
    static void DisSightHis()
    {
        List<SightHis> sightHises = Query.GetAllSightHis();
        foreach (var item in sightHises)
        {
            System.Console.WriteLine("Student: "+item.Student.Name);
            System.Console.WriteLine("Point: "+item.Point);
            System.Console.WriteLine("Sight: "+item.Sight.Name);
        }
    }
    static void DisGameHis()
    {
        List<PlayHis> playHis = Query.GetAllPlayHis();
        foreach (var item in playHis)
        {
            System.Console.WriteLine("Student: "+item.Student.Name);
            System.Console.WriteLine("Point: "+item.Point);
            System.Console.WriteLine("Sight: "+item.Game.Name);
        }
    }

    static void DisTPointHis()
    {
        List<TPointHis> tpoints = Query.GetAllTPointHis();
        foreach (var item in tpoints)
        {
            System.Console.WriteLine("Student: "+item.Student.Name);
            System.Console.WriteLine("Point: "+item.Point);
            System.Console.WriteLine("Sight: "+item.Content);
        }
    }
    
    public static void Main()
    {
        MyFakeData.Init();
        // DisStudent();
        // DisAccount();
        // DisSight();
        // SignIn();
        // DisSightHis();
        // DisGameHis();
        // DisTPointHis();
    }
}
