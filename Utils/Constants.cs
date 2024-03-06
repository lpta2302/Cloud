using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

public class Constants
{
    public static string connectionString = @"
        Data Source=localhost,1433;
        Initial Catalog= test;
        User Id=sa;
        Password=Heoboo@23;
        TrustServerCertificate=true;
    ";
    public static string STUDENT_ACC = "Student";
    public static string ADMIN_ACC = "Admin";
    public static string CLB_ACC = "CLB";
}
