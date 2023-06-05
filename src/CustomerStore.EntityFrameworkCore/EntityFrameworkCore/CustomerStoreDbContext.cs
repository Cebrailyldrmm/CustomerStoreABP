using CustomerStore.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace CustomerStore.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CustomerStoreDbContext :
    AbpDbContext<CustomerStoreDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    public DbSet<Customer> Customers { get; set; }

    public DbSet<IdentityUser> Users => throw new System.NotImplementedException();

    public DbSet<IdentityRole> Roles => throw new System.NotImplementedException();

    public DbSet<IdentityClaimType> ClaimTypes => throw new System.NotImplementedException();

    public DbSet<OrganizationUnit> OrganizationUnits => throw new System.NotImplementedException();

    public DbSet<IdentitySecurityLog> SecurityLogs => throw new System.NotImplementedException();

    public DbSet<IdentityLinkUser> LinkUsers => throw new System.NotImplementedException();

    public DbSet<Tenant> Tenants => throw new System.NotImplementedException();

    public DbSet<TenantConnectionString> TenantConnectionStrings => throw new System.NotImplementedException();

    

    public CustomerStoreDbContext(DbContextOptions<CustomerStoreDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Customer>(b =>
        {
            b.ToTable(name:CustomerStoreConsts.DbTablePrefix + "Customers", CustomerStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.FirstName).IsRequired().HasMaxLength(128);
        });
    }
}
