using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void CreateDatabase()
    {
        using var dbcontext = new UehEventContext();
        string dbname = dbcontext.Database.GetDbConnection().Database;

        var kq = dbcontext.Database.EnsureCreated();
        if (kq)
        {
            System.Console.WriteLine("create db successfully");
        }
        else
        {
            System.Console.WriteLine("create db fail");
        }

        Console.WriteLine(dbname);
    }
    static void DropDatabase()
    {
        using var dbcontext = new UehEventContext();
        string dbname = dbcontext.Database.GetDbConnection().Database;

        var kq = dbcontext.Database.EnsureDeleted();
        if (kq)
        {
            System.Console.WriteLine("drop db successfully");
        }
        else
        {
            System.Console.WriteLine("drop db fail");
        }

        Console.WriteLine(dbname);
    }
    static void Main()
    {
        DropDatabase();
        CreateDatabase();
        // InsertValue();
        // Delete();
        // Read();
    }
}
