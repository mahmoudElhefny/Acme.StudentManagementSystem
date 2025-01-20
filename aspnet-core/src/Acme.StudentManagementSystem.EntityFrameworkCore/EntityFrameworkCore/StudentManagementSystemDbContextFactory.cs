using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.StudentManagementSystem.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StudentManagementSystemDbContextFactory : IDesignTimeDbContextFactory<StudentManagementSystemDbContext>
{
    public StudentManagementSystemDbContext CreateDbContext(string[] args)
    {
        StudentManagementSystemEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<StudentManagementSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new StudentManagementSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.StudentManagementSystem.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
