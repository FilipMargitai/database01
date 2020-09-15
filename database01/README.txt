entityFrameworkCore.Tools
entityFrameworkCore.SqlServer

struktura: Databázový_Server/Databáze/tabulky

Kroky připojení SQL databáze
1.nový appsettings.json a zkopírovat ConnectionString do původního appsettings.json
2.google asp.net core entity framework startup.cs
    services.AddDbContext<SchoolContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("SchoolContext")));
3.vytvořit DbContext do Modelu(například ZooDbContext), přidat do něj using Microsoft.EntityFrameworkCore; a musí dědit z classy : DbContext
  přidat do něj konstruktor public ZooDbContext([NotNullAttribute] DbContextOptions options) : base(options)
4.vytvoření tabulek do databáze => Animal => ID, musí být [Key]
5.do ZooDbContext přidáme virtuální list DbSet<animal> name { get; set; }
6.zapnout tools/nuget/console add-migration 01Initial // vytvoření migrací
  update-database // vytvoří databázy na základu migrací
7. view/sql viewer/najít databázy