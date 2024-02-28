using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class UehEventContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<KeyAnswer> KeyAnswers { get; set; }
    public DbSet<Sight> Sights { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<PlayHis> PlayHises { get; set; }
    public DbSet<SightHis> SightHises { get; set; }
    public DbSet<TPointHis> TPointHises { get; set; }

    private string connectionString = @"
        Data Source=localhost,1433;
        Initial Catalog="
        + Constants.Dbname +
        @";User Id=sa;
        Password=Heoboo@23;
        TrustServerCertificate=true;
    ";
    private ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
    {
        builder
            // .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information)
            // .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information)
            .AddConsole();
    });
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseLoggerFactory(loggerFactory)
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasIndex(s => s.Mssv)
            .IsUnique();
    }
}