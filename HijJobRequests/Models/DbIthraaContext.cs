using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HijJobRequests.Models;

public partial class DbIthraaContext : DbContext
{
    public DbIthraaContext()
    {
    }

    public DbIthraaContext(DbContextOptions<DbIthraaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionLog> ActionLogs { get; set; }

    public virtual DbSet<ActionType> ActionTypes { get; set; }

    public virtual DbSet<AppCompany> AppCompanies { get; set; }

    public virtual DbSet<AppPage> AppPages { get; set; }

    public virtual DbSet<AppPageMain> AppPageMains { get; set; }

    public virtual DbSet<AppPageSub> AppPageSubs { get; set; }

    public virtual DbSet<AppPermission> AppPermissions { get; set; }

    public virtual DbSet<AppPermissionPage> AppPermissionPages { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<AppUserPermission> AppUserPermissions { get; set; }

    public virtual DbSet<ChContractBasic> ChContractBasics { get; set; }

    public virtual DbSet<ChContractCamp> ChContractCamps { get; set; }

    public virtual DbSet<ChContractFood> ChContractFoods { get; set; }

    public virtual DbSet<ChContractHouse> ChContractHouses { get; set; }

    public virtual DbSet<ChContractRequest> ChContractRequests { get; set; }

    public virtual DbSet<ChFrom> ChFroms { get; set; }

    public virtual DbSet<ChFromElement> ChFromElements { get; set; }

    public virtual DbSet<ChFromStage> ChFromStages { get; set; }

    public virtual DbSet<ChOrganizer> ChOrganizers { get; set; }

    public virtual DbSet<ChOrganizersPer> ChOrganizersPers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<HrEmp> HrEmps { get; set; }

    public virtual DbSet<HrEmpBudget> HrEmpBudgets { get; set; }

    public virtual DbSet<HrEmpBudgetSer> HrEmpBudgetSers { get; set; }

    public virtual DbSet<HrEmpCourse> HrEmpCourses { get; set; }

    public virtual DbSet<HrEmpExperience> HrEmpExperiences { get; set; }

    public virtual DbSet<HrEmpOrder> HrEmpOrders { get; set; }

    public virtual DbSet<HrEmpOrderCare> HrEmpOrderCares { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Pattern> Patterns { get; set; }

    public virtual DbSet<PatternStep> PatternSteps { get; set; }

    public virtual DbSet<PatternStepAction> PatternStepActions { get; set; }

    public virtual DbSet<Pbcatcol> Pbcatcols { get; set; }

    public virtual DbSet<Pbcatedt> Pbcatedts { get; set; }

    public virtual DbSet<Pbcatfmt> Pbcatfmts { get; set; }

    public virtual DbSet<Pbcattbl> Pbcattbls { get; set; }

    public virtual DbSet<Pbcatvld> Pbcatvlds { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SysCompanyDesign> SysCompanyDesigns { get; set; }

    public virtual DbSet<SysDate> SysDates { get; set; }

    public virtual DbSet<SysDateMonth> SysDateMonths { get; set; }

    public virtual DbSet<SysDateWeek> SysDateWeeks { get; set; }

    public virtual DbSet<SysLink> SysLinks { get; set; }

    public virtual DbSet<SysOper> SysOpers { get; set; }

    public virtual DbSet<SysPict> SysPicts { get; set; }

    public virtual DbSet<SysRegister> SysRegisters { get; set; }

    public virtual DbSet<TdBank> TdBanks { get; set; }

    public virtual DbSet<TdCenter> TdCenters { get; set; }

    public virtual DbSet<TdCity> TdCities { get; set; }

    public virtual DbSet<TdCountry> TdCountries { get; set; }

    public virtual DbSet<TdCourse> TdCourses { get; set; }

    public virtual DbSet<TdDistrict> TdDistricts { get; set; }

    public virtual DbSet<TdForm> TdForms { get; set; }

    public virtual DbSet<TdFormsElement> TdFormsElements { get; set; }

    public virtual DbSet<TdHouseLicense> TdHouseLicenses { get; set; }

    public virtual DbSet<TdJob> TdJobs { get; set; }

    public virtual DbSet<TdLanguage> TdLanguages { get; set; }

    public virtual DbSet<TdMailType> TdMailTypes { get; set; }

    public virtual DbSet<TdMajor> TdMajors { get; set; }

    public virtual DbSet<TdMeasurement> TdMeasurements { get; set; }

    public virtual DbSet<TdOrderStatus> TdOrderStatuses { get; set; }

    public virtual DbSet<TdPackage> TdPackages { get; set; }

    public virtual DbSet<TdPackageService> TdPackageServices { get; set; }

    public virtual DbSet<TdPackageSite> TdPackageSites { get; set; }

    public virtual DbSet<TdPict> TdPicts { get; set; }

    public virtual DbSet<TdQuali> TdQualis { get; set; }

    public virtual DbSet<TdSeason> TdSeasons { get; set; }

    public virtual DbSet<TdSeasonStatus> TdSeasonStatuses { get; set; }

    public virtual DbSet<TdSection> TdSections { get; set; }

    public virtual DbSet<TdSupplier> TdSuppliers { get; set; }

    public virtual DbSet<TdTransport> TdTransports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=37.224.81.110;Initial Catalog=db_ithraa;User Id=sa;Password=Habis@123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<Action>(entity =>
        {
            entity.ToTable("Action");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
            entity.Property(e => e.Fx).HasMaxLength(50);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ParentId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("ParentID");
            entity.Property(e => e.Url).HasMaxLength(250);

            entity.HasOne(d => d.Module).WithMany(p => p.Actions).HasForeignKey(d => d.ModuleId);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<ActionLog>(entity =>
        {
            entity.ToTable("ActionLog");

            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
        });

        modelBuilder.Entity<ActionType>(entity =>
        {
            entity.ToTable("ActionType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(50);
        });

        modelBuilder.Entity<AppCompany>(entity =>
        {
            entity.HasKey(e => e.FCompanyId)
                .HasName("app_company_x")
                .IsClustered(false);

            entity.ToTable("app_company");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FAddress)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_address");
            entity.Property(e => e.FBankIban)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("f_bank_iban");
            entity.Property(e => e.FBankNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_bank_no");
            entity.Property(e => e.FBuildingNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_building_no");
            entity.Property(e => e.FCityNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_city_no");
            entity.Property(e => e.FCompanyName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_company_name");
            entity.Property(e => e.FEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_email");
            entity.Property(e => e.FIdNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_id_no");
            entity.Property(e => e.FJawNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_jaw_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPostalCode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_postal_code");
            entity.Property(e => e.FSecondaryNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_secondary_no");
            entity.Property(e => e.FUnifiedNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_unified_no");
            entity.Property(e => e.FVatNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_vat_no");
        });

        modelBuilder.Entity<AppPage>(entity =>
        {
            entity.HasKey(e => e.FPageNo)
                .HasName("app_page_x")
                .IsClustered(false);

            entity.ToTable("app_page");

            entity.Property(e => e.FPageNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FLinkNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_link_no");
            entity.Property(e => e.FPageName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_page_name");
            entity.Property(e => e.FPageSort)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_page_sort");
            entity.Property(e => e.FPageStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_page_status");
            entity.Property(e => e.FPageSubNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_sub_no");
        });

        modelBuilder.Entity<AppPageMain>(entity =>
        {
            entity.HasKey(e => e.FPageMainNo)
                .HasName("app_page_main_x")
                .IsClustered(false);

            entity.ToTable("app_page_main");

            entity.Property(e => e.FPageMainNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_main_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPageMainName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_page_main_name");
            entity.Property(e => e.FPageMainSort)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_page_main_sort");
            entity.Property(e => e.FPageMainStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_page_main_status");
        });

        modelBuilder.Entity<AppPageSub>(entity =>
        {
            entity.HasKey(e => e.FPageSubNo)
                .HasName("app_page_sub_x")
                .IsClustered(false);

            entity.ToTable("app_page_sub");

            entity.Property(e => e.FPageSubNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_sub_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPageMainNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_main_no");
            entity.Property(e => e.FPageSubName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_page_sub_name");
            entity.Property(e => e.FPageSubSort)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_page_sub_sort");
            entity.Property(e => e.FPageSubStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_page_sub_status");
        });

        modelBuilder.Entity<AppPermission>(entity =>
        {
            entity.HasKey(e => e.FPermNo)
                .HasName("app_permission_x")
                .IsClustered(false);

            entity.ToTable("app_permission");

            entity.Property(e => e.FPermNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_perm_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPermName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_perm_name");
            entity.Property(e => e.FPermStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_perm_status");
        });

        modelBuilder.Entity<AppPermissionPage>(entity =>
        {
            entity.HasKey(e => new { e.FPermNo, e.FPageNo })
                .HasName("app_permission_page_x")
                .IsClustered(false);

            entity.ToTable("app_permission_page");

            entity.Property(e => e.FPermNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_perm_no");
            entity.Property(e => e.FPageNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_page_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FDeleted)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_deleted");
            entity.Property(e => e.FExport)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_export");
            entity.Property(e => e.FInsert)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_insert");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPrint)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_print");
            entity.Property(e => e.FRole01)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role01");
            entity.Property(e => e.FRole02)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role02");
            entity.Property(e => e.FRole03)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role03");
            entity.Property(e => e.FRole04)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role04");
            entity.Property(e => e.FRole05)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role05");
            entity.Property(e => e.FRole06)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role06");
            entity.Property(e => e.FRole07)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role07");
            entity.Property(e => e.FRole08)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role08");
            entity.Property(e => e.FRole09)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role09");
            entity.Property(e => e.FShow)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_show");
            entity.Property(e => e.FUpdate)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_update");
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.HasKey(e => e.FUserId)
                .HasName("app_user_x")
                .IsClustered(false);

            entity.ToTable("app_user");

            entity.Property(e => e.FUserId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_user_id");
            entity.Property(e => e.FEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_email");
            entity.Property(e => e.FIdNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_id_no");
            entity.Property(e => e.FJawNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_jaw_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
            entity.Property(e => e.FUserCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_user_code");
            entity.Property(e => e.FUserName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_user_name");
            entity.Property(e => e.FUserPass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_user_pass");
            entity.Property(e => e.FUserStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_user_status");
            entity.Property(e => e.FUserType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_user_type");
            entity.Property(e => e.FVerificatOption)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_verificat_option");
        });

        modelBuilder.Entity<AppUserPermission>(entity =>
        {
            entity.HasKey(e => new { e.FUserId, e.FCompanyId })
                .HasName("app_user_permission_x")
                .IsClustered(false);

            entity.ToTable("app_user_permission");

            entity.Property(e => e.FUserId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_user_id");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPermNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_perm_no");
        });

        modelBuilder.Entity<ChContractBasic>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FContractNo })
                .HasName("ch_contract_basic_x")
                .IsClustered(false);

            entity.ToTable("ch_contract_basic");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FContractNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_no");
            entity.Property(e => e.FCenterNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_center_no");
            entity.Property(e => e.FContractAco)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_aco");
            entity.Property(e => e.FContractAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_amo");
            entity.Property(e => e.FContractRate)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_contract_rate");
            entity.Property(e => e.FContractStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_status");
            entity.Property(e => e.FContractValue)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_value");
            entity.Property(e => e.FContractVat)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("f_contract_vat");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FPackageNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_package_no");
            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
        });

        modelBuilder.Entity<ChContractCamp>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FContractNo })
                .HasName("ch_contract_camps_x")
                .IsClustered(false);

            entity.ToTable("ch_contract_camps");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FContractNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_no");
            entity.Property(e => e.FBoxNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_box_no");
            entity.Property(e => e.FCampNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_camp_no");
            entity.Property(e => e.FCenterNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_center_no");
            entity.Property(e => e.FContractAco)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_aco");
            entity.Property(e => e.FContractAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_amo");
            entity.Property(e => e.FContractStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_status");
            entity.Property(e => e.FGateNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_gate_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FPrice)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_price");
            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
            entity.Property(e => e.FScopeNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_scope_no");
            entity.Property(e => e.FStreetNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_street_no");
        });

        modelBuilder.Entity<ChContractFood>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FContractNo })
                .HasName("ch_organizers_food_x")
                .IsClustered(false);

            entity.ToTable("ch_contract_food");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FContractNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_no");
            entity.Property(e => e.FContractAco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_contract_aco");
            entity.Property(e => e.FContractAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_amo");
            entity.Property(e => e.FContractDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_contract_date");
            entity.Property(e => e.FContractDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_contract_date_from");
            entity.Property(e => e.FContractDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_contract_date_to");
            entity.Property(e => e.FContractLocation)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_location");
            entity.Property(e => e.FContractRate)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_contract_rate");
            entity.Property(e => e.FContractStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_status");
            entity.Property(e => e.FContractValue)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_value");
            entity.Property(e => e.FContractVat)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("f_contract_vat");
            entity.Property(e => e.FDelegateNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_delegate_no");
            entity.Property(e => e.FDelegateType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_delegate_type");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMealTypeNo)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_meal_type_no");
            entity.Property(e => e.FSupplierNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_supplier_no");
        });

        modelBuilder.Entity<ChContractHouse>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FContractNo })
                .HasName("ch_contract_house_x")
                .IsClustered(false);

            entity.ToTable("ch_contract_house");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FContractNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_contract_no");
            entity.Property(e => e.FContractAco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_contract_aco");
            entity.Property(e => e.FContractAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_amo");
            entity.Property(e => e.FContractRate)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_contract_rate");
            entity.Property(e => e.FContractStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_status");
            entity.Property(e => e.FContractValue)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_contract_value");
            entity.Property(e => e.FContractVat)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("f_contract_vat");
            entity.Property(e => e.FHouseCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_house_city");
            entity.Property(e => e.FHouseNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_house_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FOrganizerPerNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_organizer_per_no");
        });

        modelBuilder.Entity<ChContractRequest>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FRequestNo })
                .HasName("ch_contract_requests_x")
                .IsClustered(false);

            entity.ToTable("ch_contract_requests");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
            entity.Property(e => e.FBasicAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_basic_amo");
            entity.Property(e => e.FCampsAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_camps_amo");
            entity.Property(e => e.FFoodAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_food_amo");
            entity.Property(e => e.FHousingAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_housing_amo");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FPilgrimsAco)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_pilgrims_aco");
            entity.Property(e => e.FRequestAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_request_amo");
            entity.Property(e => e.FRequestDate)
                .HasColumnType("datetime")
                .HasColumnName("f_request_date");
            entity.Property(e => e.FRequestDateEnd)
                .HasColumnType("datetime")
                .HasColumnName("f_request_date_end");
            entity.Property(e => e.FServicesAmo)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("f_services_amo");
        });

        modelBuilder.Entity<ChFrom>(entity =>
        {
            entity.HasKey(e => e.FRequestNo)
                .HasName("ch_from_x")
                .IsClustered(false);

            entity.ToTable("ch_from");

            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FContractAco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_contract_aco");
            entity.Property(e => e.FFormNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_form_no");
            entity.Property(e => e.FHouseNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_house_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FRequestDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_request_date");
            entity.Property(e => e.FRequestStstus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_request_ststus");
            entity.Property(e => e.FRequestTime)
                .HasColumnType("datetime")
                .HasColumnName("f_request_time");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
        });

        modelBuilder.Entity<ChFromElement>(entity =>
        {
            entity.HasKey(e => new { e.FRequestNo, e.FFormNo, e.FFormSerNo })
                .HasName("ch_from_elements_x")
                .IsClustered(false);

            entity.ToTable("ch_from_elements");

            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
            entity.Property(e => e.FFormNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_form_no");
            entity.Property(e => e.FFormSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_form_ser_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMeasurementDegree)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree");
            entity.Property(e => e.FMeasurementName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name");
            entity.Property(e => e.FMeasurementNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_no");
            entity.Property(e => e.FMeasurementSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_ser_no");
        });

        modelBuilder.Entity<ChFromStage>(entity =>
        {
            entity.HasKey(e => new { e.FRequestNo, e.FSerNo })
                .HasName("ch_from_stages_x")
                .IsClustered(false);

            entity.ToTable("ch_from_stages");

            entity.Property(e => e.FRequestNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_request_no");
            entity.Property(e => e.FSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FCloseEmpSupervisior)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_close_emp_supervisior");
            entity.Property(e => e.FCloseNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("f_close_note");
            entity.Property(e => e.FCloseSupervisiorNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("f_close_supervisior_note");
            entity.Property(e => e.FCloseTime)
                .HasColumnType("datetime")
                .HasColumnName("f_close_time");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FDeadlineTime)
                .HasColumnType("datetime")
                .HasColumnName("f_deadline_time");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FTaskEmpInspector)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_task_emp_Inspector");
            entity.Property(e => e.FTaskEmpSupervisior)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_task_emp_supervisior");
            entity.Property(e => e.FTaskNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("f_task_note");
            entity.Property(e => e.FTaskTime)
                .HasColumnType("datetime")
                .HasColumnName("f_task_time");
        });

        modelBuilder.Entity<ChOrganizer>(entity =>
        {
            entity.HasKey(e => e.FOrganizerNo)
                .HasName("ch_organizers_x")
                .IsClustered(false);

            entity.ToTable("ch_organizers");

            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FCountryNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_country_no");
            entity.Property(e => e.FDateExpiry)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_date_expiry");
            entity.Property(e => e.FDateIssue)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_date_issue");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FLicenseNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_license_no");
            entity.Property(e => e.FOrganizerEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_organizer_email");
            entity.Property(e => e.FOrganizerFax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_organizer_fax");
            entity.Property(e => e.FOrganizerNameA)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_organizer_name_a");
            entity.Property(e => e.FOrganizerNameE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_organizer_name_e");
            entity.Property(e => e.FOrganizerStaus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_organizer_staus");
            entity.Property(e => e.FOrganizerSys)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_organizer_sys");
            entity.Property(e => e.FOrganizerSysEst)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_sys_est");
            entity.Property(e => e.FOrganizerTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_organizer_tel");
            entity.Property(e => e.FOrganizerWeb)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_organizer_web");
        });

        modelBuilder.Entity<ChOrganizersPer>(entity =>
        {
            entity.HasKey(e => new { e.FOrganizerNo, e.FPerNo })
                .HasName("ch_organizers_per_x")
                .IsClustered(false);

            entity.ToTable("ch_organizers_per");

            entity.Property(e => e.FOrganizerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_organizer_no");
            entity.Property(e => e.FPerNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_per_no");
            entity.Property(e => e.FBirthDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_birth_date");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FNatiNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_nati_no");
            entity.Property(e => e.FPassCity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_pass_city");
            entity.Property(e => e.FPassDateExpiry)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_pass_date_expiry");
            entity.Property(e => e.FPassDateIssue)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_pass_date_issue");
            entity.Property(e => e.FPassNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_pass_no");
            entity.Property(e => e.FPerEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_per_email");
            entity.Property(e => e.FPerJaw)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_per_jaw");
            entity.Property(e => e.FPerName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("f_per_name");
            entity.Property(e => e.FPerNameE)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("f_per_name_e");
            entity.Property(e => e.FPerType)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_per_type");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArabicName).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.EnglishName).HasMaxLength(100);
            entity.Property(e => e.Tag).HasMaxLength(50);
        });

        modelBuilder.Entity<HrEmp>(entity =>
        {
            entity.HasKey(e => e.FEmpNo)
                .HasName("hr_emp_x")
                .IsClustered(false);

            entity.ToTable("hr_emp");

            entity.Property(e => e.FEmpNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_emp_no");
            entity.Property(e => e.FAge)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_age");
            entity.Property(e => e.FBankIbanNo)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("f_bank_iban_no");
            entity.Property(e => e.FBankNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_bank_no");
            entity.Property(e => e.FBirthDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_birth_date");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_email");
            entity.Property(e => e.FEmailActivation)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_email_activation");
            entity.Property(e => e.FEmpFamily)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_family");
            entity.Property(e => e.FEmpFamilyE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_family_e");
            entity.Property(e => e.FEmpFather)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_father");
            entity.Property(e => e.FEmpFatherE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_father_e");
            entity.Property(e => e.FEmpFirst)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_first");
            entity.Property(e => e.FEmpFirstE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_first_e");
            entity.Property(e => e.FEmpGrandfather)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_grandfather");
            entity.Property(e => e.FEmpGrandfatherE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_emp_grandfather_e");
            entity.Property(e => e.FEmpName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_emp_name");
            entity.Property(e => e.FEmpNameE)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_emp_name_e");
            entity.Property(e => e.FEmpStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_emp_status");
            entity.Property(e => e.FGender)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_gender");
            entity.Property(e => e.FHomeAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_home_address");
            entity.Property(e => e.FHomeCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_home_city");
            entity.Property(e => e.FIdDateExpiry)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_id_date_expiry");
            entity.Property(e => e.FIdNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_id_no");
            entity.Property(e => e.FIdSaveNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_id_save_no");
            entity.Property(e => e.FIdType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_id_type");
            entity.Property(e => e.FJawNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_jaw_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMajorNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_major_no");
            entity.Property(e => e.FNatiNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_nati_no");
            entity.Property(e => e.FQualiNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_quali_no");
        });

        modelBuilder.Entity<HrEmpBudget>(entity =>
        {
            entity.HasKey(e => e.FBudgetNo)
                .HasName("hr_emp_budget_x")
                .IsClustered(false);

            entity.ToTable("hr_emp_budget");

            entity.Property(e => e.FBudgetNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_budget_no");
            entity.Property(e => e.FBudgetContract)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_budget_contract");
            entity.Property(e => e.FBudgetPayment)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_budget_payment");
            entity.Property(e => e.FBudgetStatus)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_budget_status");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FDayAco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_day_aco");
            entity.Property(e => e.FDepNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_dep_no");
            entity.Property(e => e.FDepSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_dep_ser_no");
            entity.Property(e => e.FJobAco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_job_aco");
            entity.Property(e => e.FJobNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_job_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FManagerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_manager_no");
            entity.Property(e => e.FSalaryAmo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("f_salary_amo");
            entity.Property(e => e.FSalaryDaily)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("f_salary_daily");
            entity.Property(e => e.FSalaryMonthly)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("f_salary_monthly");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
        });

        modelBuilder.Entity<HrEmpBudgetSer>(entity =>
        {
            entity.HasKey(e => e.FBudgetSerNo)
                .HasName("hr_emp_budget_ser_x")
                .IsClustered(false);

            entity.ToTable("hr_emp_budget_ser");

            entity.HasIndex(e => e.FOrderNo, "hr_emp_budget_ser_x1");

            entity.Property(e => e.FBudgetSerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_budget_ser_no");
            entity.Property(e => e.FBudgetNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_budget_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrderNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_order_no");
            entity.Property(e => e.FSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_ser_no");
        });

        modelBuilder.Entity<HrEmpCourse>(entity =>
        {
            entity.HasKey(e => new { e.FEmpNo, e.FSerNo })
                .HasName("hr_emp_course_x")
                .IsClustered(false);

            entity.ToTable("hr_emp_course");

            entity.Property(e => e.FEmpNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_emp_no");
            entity.Property(e => e.FSerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FCourseDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_course_date_from");
            entity.Property(e => e.FCourseDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_course_date_to");
            entity.Property(e => e.FCourseLocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_course_location");
            entity.Property(e => e.FCourseName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_course_name");
            entity.Property(e => e.FCourseNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_course_no");
            entity.Property(e => e.FCourseSeason)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_course_season");
            entity.Property(e => e.FCourseStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_course_status");
            entity.Property(e => e.FCourseType)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_course_type");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<HrEmpExperience>(entity =>
        {
            entity.HasKey(e => new { e.FEmpNo, e.FSerNo })
                .HasName("hr_emp_experience_x")
                .IsClustered(false);

            entity.ToTable("hr_emp_experience");

            entity.Property(e => e.FEmpNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_emp_no");
            entity.Property(e => e.FSerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FExperienceStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_experience_status");
            entity.Property(e => e.FJobName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_job_name");
            entity.Property(e => e.FJobSide)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_job_side");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
        });

        modelBuilder.Entity<HrEmpOrder>(entity =>
        {
            entity.HasKey(e => e.FOrderNo)
                .HasName("hr_emp_order_x")
                .IsClustered(false);

            entity.ToTable("hr_emp_order");

            entity.Property(e => e.FOrderNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_order_no");
            entity.Property(e => e.FAbsenceAco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_absence_aco");
            entity.Property(e => e.FBudgetSerNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_budget_ser_no");
            entity.Property(e => e.FCardOk)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_card_ok");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FContractDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_contract_date_from");
            entity.Property(e => e.FContractDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_contract_date_to");
            entity.Property(e => e.FContractOk)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_contract_ok");
            entity.Property(e => e.FEmpNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_emp_no");
            entity.Property(e => e.FJobOfferOk)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_job_offer_ok");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FNominationActive)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_nomination_active");
            entity.Property(e => e.FNominationDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_nomination_date");
            entity.Property(e => e.FNominationNote)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("f_nomination_note");
            entity.Property(e => e.FOrderDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_order_date");
            entity.Property(e => e.FOrderStatus)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_order_status");
            entity.Property(e => e.FPenaltyAco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_penalty_aco");
            entity.Property(e => e.FReceiptTypeNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_receipt_type_no");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
        });

        modelBuilder.Entity<HrEmpOrderCare>(entity =>
        {
            entity.HasKey(e => new { e.FOrderNo, e.FSerNo })
                .HasName("hr_emp_order_care_X")
                .IsClustered(false);

            entity.ToTable("hr_emp_order_care");

            entity.Property(e => e.FOrderNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_order_no");
            entity.Property(e => e.FSerNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FCareDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_care_date");
            entity.Property(e => e.FCareNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_care_no");
            entity.Property(e => e.FCareNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_care_note");
            entity.Property(e => e.FCareStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_care_status");
            entity.Property(e => e.FCareTime)
                .HasColumnType("datetime")
                .HasColumnName("f_care_time");
            entity.Property(e => e.FCareType)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_care_type");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FReturnDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_return_date");
            entity.Property(e => e.FReturnNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_return_note");
            entity.Property(e => e.FReturnTime)
                .HasColumnType("datetime")
                .HasColumnName("f_return_time");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.ToTable("Job");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArabicName).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.EnglishName).HasMaxLength(100);
            entity.Property(e => e.Tag).HasMaxLength(50);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.ToTable("Module");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(500);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(500);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.Tag).HasMaxLength(50);

            entity.HasOne(d => d.Project).WithMany(p => p.Modules).HasForeignKey(d => d.ProjectId);
        });

        modelBuilder.Entity<Pattern>(entity =>
        {
            entity.ToTable("Pattern");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.AutoUrl).HasMaxLength(500);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
            entity.Property(e => e.MasterTableCodeColumnName).HasMaxLength(500);
            entity.Property(e => e.MasterTableCondition).HasMaxLength(500);
            entity.Property(e => e.MasterTableIdcolumnName)
                .HasMaxLength(500)
                .HasColumnName("MasterTableIDColumnName");
            entity.Property(e => e.MasterTableName).HasMaxLength(500);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.HasOne(d => d.Project).WithMany(p => p.Patterns).HasForeignKey(d => d.ProjectId);
        });

        modelBuilder.Entity<PatternStep>(entity =>
        {
            entity.ToTable("PatternStep");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
            entity.Property(e => e.PatternId).HasColumnName("PatternID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Pattern).WithMany(p => p.PatternSteps).HasForeignKey(d => d.PatternId);

            entity.HasOne(d => d.Role).WithMany(p => p.PatternSteps)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatternStep_AspNetRoles_RoleID");
        });

        modelBuilder.Entity<PatternStepAction>(entity =>
        {
            entity.ToTable("PatternStepAction");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.ButtonClass).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
            entity.Property(e => e.PatternStepId).HasColumnName("PatternStepID");
            entity.Property(e => e.RequiredFx).HasMaxLength(50);
            entity.Property(e => e.RoleArabicDescription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoleEnglishDescription).HasMaxLength(50);
            entity.Property(e => e.TargetStepId).HasColumnName("TargetStepID");

            entity.HasOne(d => d.PatternStep).WithMany(p => p.PatternStepActions).HasForeignKey(d => d.PatternStepId);
        });

        modelBuilder.Entity<Pbcatcol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatcol");

            entity.HasIndex(e => new { e.PbcTnam, e.PbcOwnr, e.PbcCnam }, "pbcatc_x").IsUnique();

            entity.Property(e => e.PbcBmap)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbc_bmap");
            entity.Property(e => e.PbcCase).HasColumnName("pbc_case");
            entity.Property(e => e.PbcCid).HasColumnName("pbc_cid");
            entity.Property(e => e.PbcCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_cmnt");
            entity.Property(e => e.PbcCnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_cnam");
            entity.Property(e => e.PbcEdit)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_edit");
            entity.Property(e => e.PbcHdr)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_hdr");
            entity.Property(e => e.PbcHght).HasColumnName("pbc_hght");
            entity.Property(e => e.PbcHpos).HasColumnName("pbc_hpos");
            entity.Property(e => e.PbcInit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_init");
            entity.Property(e => e.PbcJtfy).HasColumnName("pbc_jtfy");
            entity.Property(e => e.PbcLabl)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_labl");
            entity.Property(e => e.PbcLpos).HasColumnName("pbc_lpos");
            entity.Property(e => e.PbcMask)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_mask");
            entity.Property(e => e.PbcOwnr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_ownr");
            entity.Property(e => e.PbcPtrn)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_ptrn");
            entity.Property(e => e.PbcTag)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_tag");
            entity.Property(e => e.PbcTid).HasColumnName("pbc_tid");
            entity.Property(e => e.PbcTnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_tnam");
            entity.Property(e => e.PbcWdth).HasColumnName("pbc_wdth");
        });

        modelBuilder.Entity<Pbcatedt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatedt");

            entity.HasIndex(e => new { e.PbeName, e.PbeSeqn }, "pbcate_x").IsUnique();

            entity.Property(e => e.PbeCntr).HasColumnName("pbe_cntr");
            entity.Property(e => e.PbeEdit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbe_edit");
            entity.Property(e => e.PbeFlag).HasColumnName("pbe_flag");
            entity.Property(e => e.PbeName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbe_name");
            entity.Property(e => e.PbeSeqn).HasColumnName("pbe_seqn");
            entity.Property(e => e.PbeType).HasColumnName("pbe_type");
            entity.Property(e => e.PbeWork)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("pbe_work");
        });

        modelBuilder.Entity<Pbcatfmt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatfmt");

            entity.HasIndex(e => e.PbfName, "pbcatf_x").IsUnique();

            entity.Property(e => e.PbfCntr).HasColumnName("pbf_cntr");
            entity.Property(e => e.PbfFrmt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbf_frmt");
            entity.Property(e => e.PbfName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbf_name");
            entity.Property(e => e.PbfType).HasColumnName("pbf_type");
        });

        modelBuilder.Entity<Pbcattbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcattbl");

            entity.HasIndex(e => new { e.PbtTnam, e.PbtOwnr }, "pbcatt_x").IsUnique();

            entity.Property(e => e.PbdFchr).HasColumnName("pbd_fchr");
            entity.Property(e => e.PbdFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbd_ffce");
            entity.Property(e => e.PbdFhgt).HasColumnName("pbd_fhgt");
            entity.Property(e => e.PbdFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbd_fitl");
            entity.Property(e => e.PbdFptc).HasColumnName("pbd_fptc");
            entity.Property(e => e.PbdFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbd_funl");
            entity.Property(e => e.PbdFwgt).HasColumnName("pbd_fwgt");
            entity.Property(e => e.PbhFchr).HasColumnName("pbh_fchr");
            entity.Property(e => e.PbhFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbh_ffce");
            entity.Property(e => e.PbhFhgt).HasColumnName("pbh_fhgt");
            entity.Property(e => e.PbhFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbh_fitl");
            entity.Property(e => e.PbhFptc).HasColumnName("pbh_fptc");
            entity.Property(e => e.PbhFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbh_funl");
            entity.Property(e => e.PbhFwgt).HasColumnName("pbh_fwgt");
            entity.Property(e => e.PblFchr).HasColumnName("pbl_fchr");
            entity.Property(e => e.PblFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbl_ffce");
            entity.Property(e => e.PblFhgt).HasColumnName("pbl_fhgt");
            entity.Property(e => e.PblFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbl_fitl");
            entity.Property(e => e.PblFptc).HasColumnName("pbl_fptc");
            entity.Property(e => e.PblFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbl_funl");
            entity.Property(e => e.PblFwgt).HasColumnName("pbl_fwgt");
            entity.Property(e => e.PbtCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbt_cmnt");
            entity.Property(e => e.PbtOwnr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbt_ownr");
            entity.Property(e => e.PbtTid).HasColumnName("pbt_tid");
            entity.Property(e => e.PbtTnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbt_tnam");
        });

        modelBuilder.Entity<Pbcatvld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatvld");

            entity.HasIndex(e => e.PbvName, "pbcatv_x").IsUnique();

            entity.Property(e => e.PbvCntr).HasColumnName("pbv_cntr");
            entity.Property(e => e.PbvMsg)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_msg");
            entity.Property(e => e.PbvName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbv_name");
            entity.Property(e => e.PbvType).HasColumnName("pbv_type");
            entity.Property(e => e.PbvVald)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_vald");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActionId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("ActionID");
            entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);

            entity.HasOne(d => d.Action).WithMany(p => p.Permissions).HasForeignKey(d => d.ActionId);

            entity.HasOne(d => d.ActionType).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.ActionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.ArabicName).HasMaxLength(100);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.EnglishName).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(10);
            entity.Property(e => e.MobileNumber).HasMaxLength(10);
            entity.Property(e => e.PhoneNumber).HasMaxLength(10);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Tag).HasMaxLength(50);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AspNetRoles");

            entity.ToTable("Role");

            entity.Property(e => e.ArabicDescription).HasMaxLength(500);
            entity.Property(e => e.EnglishDescription).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("ProjectID");
            entity.Property(e => e.Tag).HasMaxLength(50);
        });

        modelBuilder.Entity<RoleClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AspNetRoleClaims");

            entity.ToTable("RoleClaim");

            entity.Property(e => e.Discriminator).HasMaxLength(34);

            entity.HasOne(d => d.Role).WithMany(p => p.RoleClaims)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.ToTable("RolePermission");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermission_AspNetRoles_RoleId");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SysCompanyDesign>(entity =>
        {
            entity.HasKey(e => e.FCompanyId)
                .HasName("sys_company_design_x")
                .IsClustered(false);

            entity.ToTable("sys_company_design");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FDesign)
                .HasColumnType("image")
                .HasColumnName("f_design");
            entity.Property(e => e.FDesignId)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_design_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
        });

        modelBuilder.Entity<SysDate>(entity =>
        {
            entity.HasKey(e => e.FDateM)
                .HasName("sys_date_x")
                .IsClustered(false);

            entity.ToTable("sys_date");

            entity.HasIndex(e => e.FDateH, "sys_date_x1").IsUnique();

            entity.HasIndex(e => e.FYearMonthH, "sys_date_x2");

            entity.HasIndex(e => e.FYearMonthM, "sys_date_x3");

            entity.HasIndex(e => e.FWeekNo, "sys_date_x4");

            entity.Property(e => e.FDateM)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_date_m");
            entity.Property(e => e.FDateH)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_date_h");
            entity.Property(e => e.FDayH)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_day_h");
            entity.Property(e => e.FDayM)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_day_m");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FMonthH)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_month_h");
            entity.Property(e => e.FMonthM)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_month_m");
            entity.Property(e => e.FWeekNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_week_no");
            entity.Property(e => e.FYearH)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_year_h");
            entity.Property(e => e.FYearM)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_year_m");
            entity.Property(e => e.FYearMonthH)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_year_month_h");
            entity.Property(e => e.FYearMonthM)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_year_month_m");
        });

        modelBuilder.Entity<SysDateMonth>(entity =>
        {
            entity.HasKey(e => e.FMonthNo)
                .HasName("sys_date_month_x")
                .IsClustered(false);

            entity.ToTable("sys_date_month");

            entity.Property(e => e.FMonthNo)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_month_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FMonthNameA)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_month_name_a");
            entity.Property(e => e.FMonthNameE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_month_name_e");
        });

        modelBuilder.Entity<SysDateWeek>(entity =>
        {
            entity.HasKey(e => e.FWeekNo)
                .HasName("sys_date_week_x")
                .IsClustered(false);

            entity.ToTable("sys_date_week");

            entity.Property(e => e.FWeekNo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_week_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FWeekNameA)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_week_name_a");
            entity.Property(e => e.FWeekNameE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_week_name_e");
        });

        modelBuilder.Entity<SysLink>(entity =>
        {
            entity.HasKey(e => e.FLinkNo)
                .HasName("sys_link_x")
                .IsClustered(false);

            entity.ToTable("sys_link");

            entity.Property(e => e.FLinkNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_link_no");
            entity.Property(e => e.FDeleted)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_deleted");
            entity.Property(e => e.FExport)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_export");
            entity.Property(e => e.FInsert)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_insert");
            entity.Property(e => e.FLastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLinkGroup)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_link_group");
            entity.Property(e => e.FLinkName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_link_name");
            entity.Property(e => e.FLinkPage)
                .HasColumnType("text")
                .HasColumnName("f_link_page");
            entity.Property(e => e.FLinkStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_link_status");
            entity.Property(e => e.FPrint)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_print");
            entity.Property(e => e.FRole01)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role01");
            entity.Property(e => e.FRole02)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role02");
            entity.Property(e => e.FRole03)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role03");
            entity.Property(e => e.FRole04)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role04");
            entity.Property(e => e.FRole05)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role05");
            entity.Property(e => e.FRole06)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role06");
            entity.Property(e => e.FRole07)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role07");
            entity.Property(e => e.FRole08)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role08");
            entity.Property(e => e.FRole09)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_role09");
            entity.Property(e => e.FRoleName01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name01");
            entity.Property(e => e.FRoleName02)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name02");
            entity.Property(e => e.FRoleName03)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name03");
            entity.Property(e => e.FRoleName04)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name04");
            entity.Property(e => e.FRoleName05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name05");
            entity.Property(e => e.FRoleName06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name06");
            entity.Property(e => e.FRoleName07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name07");
            entity.Property(e => e.FRoleName08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name08");
            entity.Property(e => e.FRoleName09)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_role_name09");
            entity.Property(e => e.FShow)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_show");
            entity.Property(e => e.FUpdate)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_update");
        });

        modelBuilder.Entity<SysOper>(entity =>
        {
            entity.HasKey(e => e.FOperNo)
                .HasName("sys_oper_x")
                .IsClustered(false);

            entity.ToTable("sys_oper");

            entity.Property(e => e.FOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_oper_no");
            entity.Property(e => e.FLastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FOperName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_oper_name");
        });

        modelBuilder.Entity<SysPict>(entity =>
        {
            entity.HasKey(e => e.FSerNo)
                .HasName("sys_pict_x")
                .IsClustered(false);

            entity.ToTable("sys_pict");

            entity.HasIndex(e => new { e.FPictNo, e.FReferenceNo }, "sys_pict_x1").IsUnique();

            entity.Property(e => e.FSerNo)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FPict)
                .HasColumnType("image")
                .HasColumnName("f_pict");
            entity.Property(e => e.FPictNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_pict_no");
            entity.Property(e => e.FReferenceNo)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("f_reference_no");
        });

        modelBuilder.Entity<SysRegister>(entity =>
        {
            entity.HasKey(e => e.FSerNo)
                .HasName("sys_register_x")
                .IsClustered(false);

            entity.ToTable("sys_register");

            entity.Property(e => e.FSerNo)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_ser_no");
            entity.Property(e => e.FApplicantName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_applicant_name");
            entity.Property(e => e.FBirthDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_birth_date");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FEmail)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_email");
            entity.Property(e => e.FFamilyName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_family_name");
            entity.Property(e => e.FFatherName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_father_name");
            entity.Property(e => e.FFirstName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_first_name");
            entity.Property(e => e.FGrandfatherName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_grandfather_name");
            entity.Property(e => e.FIdDateExpiry)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_id_date_expiry");
            entity.Property(e => e.FIdNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_id_no");
            entity.Property(e => e.FJawNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_jaw_no");
            entity.Property(e => e.FJobNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_job_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_last_update_note");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
            entity.Property(e => e.FStatus)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_status");
        });

        modelBuilder.Entity<TdBank>(entity =>
        {
            entity.HasKey(e => e.FBankNo)
                .HasName("td_bank_x")
                .IsClustered(false);

            entity.ToTable("td_bank");

            entity.Property(e => e.FBankNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_bank_no");
            entity.Property(e => e.FBankCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_bank_code");
            entity.Property(e => e.FBankName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_bank_name");
            entity.Property(e => e.FBankStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_bank_status");
            entity.Property(e => e.FCountryNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_country_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdCenter>(entity =>
        {
            entity.HasKey(e => new { e.FCompanyId, e.FSeasonNo, e.FCenterNo })
                .HasName("td_center_x")
                .IsClustered(false);

            entity.ToTable("td_center");

            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FCenterNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_center_no");
            entity.Property(e => e.FCenterEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_center_email");
            entity.Property(e => e.FCenterJaw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_center_jaw");
            entity.Property(e => e.FCenterName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_center_name");
            entity.Property(e => e.FCenterStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_center_status");
            entity.Property(e => e.FCenterType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_center_type");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FLatitudeArafat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_latitude_arafat");
            entity.Property(e => e.FLatitudeMak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_latitude_mak");
            entity.Property(e => e.FLatitudeMona)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_latitude_mona");
            entity.Property(e => e.FLongitudeArafat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_longitude_arafat");
            entity.Property(e => e.FLongitudeMak)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_longitude_mak");
            entity.Property(e => e.FLongitudeMona)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_longitude_mona");
            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
        });

        modelBuilder.Entity<TdCity>(entity =>
        {
            entity.HasKey(e => e.FCityNo)
                .HasName("td_city_x")
                .IsClustered(false);

            entity.ToTable("td_city");

            entity.Property(e => e.FCityNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_city_no");
            entity.Property(e => e.FCityMinNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_city_min_no");
            entity.Property(e => e.FCityName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_city_name");
            entity.Property(e => e.FCityStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_city_status");
            entity.Property(e => e.FCountryNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_country_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdCountry>(entity =>
        {
            entity.HasKey(e => e.FCountryNo)
                .HasName("td_country_x")
                .IsClustered(false);

            entity.ToTable("td_country");

            entity.Property(e => e.FCountryNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_country_no");
            entity.Property(e => e.FCountryMinNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_country_min_no");
            entity.Property(e => e.FCountryName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_country_name");
            entity.Property(e => e.FCountryStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_country_status");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FNatiName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_nati_name");
        });

        modelBuilder.Entity<TdCourse>(entity =>
        {
            entity.HasKey(e => e.FCourseNo)
                .HasName("td_course_x")
                .IsClustered(false);

            entity.ToTable("td_course");

            entity.Property(e => e.FCourseNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_course_no");
            entity.Property(e => e.FCourseName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_course_name");
            entity.Property(e => e.FCourseStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_course_status");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdDistrict>(entity =>
        {
            entity.HasKey(e => e.FDistrictNo)
                .HasName("td_district_x")
                .IsClustered(false);

            entity.ToTable("td_district");

            entity.Property(e => e.FDistrictNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_district_no");
            entity.Property(e => e.FCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_city");
            entity.Property(e => e.FDistrictName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_district_name");
            entity.Property(e => e.FDistrictStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_district_status");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdForm>(entity =>
        {
            entity.HasKey(e => e.FFormNo)
                .HasName("td_forms_x")
                .IsClustered(false);

            entity.ToTable("td_forms");

            entity.Property(e => e.FFormNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_form_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FFormAco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_form_aco");
            entity.Property(e => e.FFormName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_form_name");
            entity.Property(e => e.FFormStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_form_status");
            entity.Property(e => e.FFormType)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_form_type");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdFormsElement>(entity =>
        {
            entity.HasKey(e => new { e.FFormNo, e.FFormSerNo })
                .HasName("td_forms_elements_x")
                .IsClustered(false);

            entity.ToTable("td_forms_elements");

            entity.Property(e => e.FFormNo)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_form_no");
            entity.Property(e => e.FFormSerNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_form_ser_no");
            entity.Property(e => e.FAttachment)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_attachment");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FElementName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("f_element_name");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMeasurementNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_no");
        });

        modelBuilder.Entity<TdHouseLicense>(entity =>
        {
            entity.HasKey(e => e.FHouseNo)
                .HasName("td_house_license_x")
                .IsClustered(false);

            entity.ToTable("td_house_license");

            entity.Property(e => e.FHouseNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_house_no");
            entity.Property(e => e.FAgentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_agent_name");
            entity.Property(e => e.FAgentNatiNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_agent_nati_no");
            entity.Property(e => e.FAgentPerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_agent_per_email");
            entity.Property(e => e.FAgentPerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_agent_per_id");
            entity.Property(e => e.FAgentPerIdCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_agent_per_id_city");
            entity.Property(e => e.FAgentPerJaw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_agent_per_jaw");
            entity.Property(e => e.FAgentPerTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_agent_per_tel");
            entity.Property(e => e.FBuildingNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_building_no");
            entity.Property(e => e.FDistrictNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_district_no");
            entity.Property(e => e.FElectricityNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_electricity_no");
            entity.Property(e => e.FHaramSpace)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("f_haram_space");
            entity.Property(e => e.FHomeAddress)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_home_address");
            entity.Property(e => e.FHouseAco)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_house_aco");
            entity.Property(e => e.FHouseCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_house_city");
            entity.Property(e => e.FHouseClass)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("f_house_class");
            entity.Property(e => e.FHouseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_house_name");
            entity.Property(e => e.FHouseStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_house_status");
            entity.Property(e => e.FHouseStep)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_house_step");
            entity.Property(e => e.FHouseType)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_house_type");
            entity.Property(e => e.FKitchenAco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_kitchen_aco");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FLelevatorAco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_lelevator_aco");
            entity.Property(e => e.FLicenseDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_license_date_from");
            entity.Property(e => e.FLicenseDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_license_date_to");
            entity.Property(e => e.FLicenseNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_license_no");
            entity.Property(e => e.FLoorAco)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_loor_aco");
            entity.Property(e => e.FMapLatitude)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_map_latitude");
            entity.Property(e => e.FMapLongitude)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_map_longitude");
            entity.Property(e => e.FPerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_per_email");
            entity.Property(e => e.FPerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_per_id");
            entity.Property(e => e.FPerIdCity)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_per_id_city");
            entity.Property(e => e.FPerJaw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_per_jaw");
            entity.Property(e => e.FPerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_per_name");
            entity.Property(e => e.FPerNatiNo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_per_nati_no");
            entity.Property(e => e.FPerTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_per_tel");
            entity.Property(e => e.FPostalCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_postal_code");
            entity.Property(e => e.FRoomAco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_room_aco");
            entity.Property(e => e.FRoomArea)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("f_room_area");
            entity.Property(e => e.FScondaryNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_scondary_no");
            entity.Property(e => e.FStreet)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_street");
            entity.Property(e => e.FToiletAco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_toilet_aco");
        });

        modelBuilder.Entity<TdJob>(entity =>
        {
            entity.HasKey(e => e.FJobNo)
                .HasName("td_job_x")
                .IsClustered(false);

            entity.ToTable("td_job");

            entity.Property(e => e.FJobNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_job_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FJobLevel)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_job_level");
            entity.Property(e => e.FJobName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_job_name");
            entity.Property(e => e.FJobStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_job_status");
            entity.Property(e => e.FJobType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_job_type");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdLanguage>(entity =>
        {
            entity.HasKey(e => e.FLanguageNo)
                .HasName("td_language_x")
                .IsClustered(false);

            entity.ToTable("td_language");

            entity.Property(e => e.FLanguageNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_language_no");
            entity.Property(e => e.FLanguageName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_language_name");
            entity.Property(e => e.FLanguageStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_language_status");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
        });

        modelBuilder.Entity<TdMailType>(entity =>
        {
            entity.HasKey(e => e.FMealTypeNo)
                .HasName("td_mail_type_x")
                .IsClustered(false);

            entity.ToTable("td_mail_type");

            entity.Property(e => e.FMealTypeNo)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_meal_type_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMealPrice)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_meal_price");
            entity.Property(e => e.FMealTypeName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_meal_type_name");
            entity.Property(e => e.FMealTypeStatus)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_meal_type_status");
        });

        modelBuilder.Entity<TdMajor>(entity =>
        {
            entity.HasKey(e => e.FMajorNo)
                .HasName("td_major_x")
                .IsClustered(false);

            entity.ToTable("td_major");

            entity.Property(e => e.FMajorNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_major_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMajorName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_major_name");
            entity.Property(e => e.FMajorStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_major_status");
        });

        modelBuilder.Entity<TdMeasurement>(entity =>
        {
            entity.HasKey(e => e.FMeasurementNo)
                .HasName("td_measurement_x")
                .IsClustered(false);

            entity.ToTable("td_measurement");

            entity.Property(e => e.FMeasurementNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMeasurementAco)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_measurement_aco");
            entity.Property(e => e.FMeasurementDegree1)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree1");
            entity.Property(e => e.FMeasurementDegree2)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree2");
            entity.Property(e => e.FMeasurementDegree3)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree3");
            entity.Property(e => e.FMeasurementDegree4)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree4");
            entity.Property(e => e.FMeasurementDegree5)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_measurement_degree5");
            entity.Property(e => e.FMeasurementName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name");
            entity.Property(e => e.FMeasurementName1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name1");
            entity.Property(e => e.FMeasurementName2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name2");
            entity.Property(e => e.FMeasurementName3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name3");
            entity.Property(e => e.FMeasurementName4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name4");
            entity.Property(e => e.FMeasurementName5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("f_measurement_name5");
            entity.Property(e => e.FMeasurementStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_measurement_status");
        });

        modelBuilder.Entity<TdOrderStatus>(entity =>
        {
            entity.HasKey(e => e.FOrderStatusNo)
                .HasName("td_order_status_x")
                .IsClustered(false);

            entity.ToTable("td_order_status");

            entity.Property(e => e.FOrderStatusNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("f_order_status_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FOrderStatusName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_order_status_name");
            entity.Property(e => e.FOrderStatusStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_order_status_status");
        });

        modelBuilder.Entity<TdPackage>(entity =>
        {
            entity.HasKey(e => e.FPackageNo)
                .HasName("td_package_x")
                .IsClustered(false);

            entity.ToTable("td_package");

            entity.Property(e => e.FPackageNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_package_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPackageName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_package_name");
            entity.Property(e => e.FPackageStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_package_status");
        });

        modelBuilder.Entity<TdPackageService>(entity =>
        {
            entity.HasKey(e => e.FServiceNo)
                .HasName("td_package_service_x")
                .IsClustered(false);

            entity.ToTable("td_package_service");

            entity.Property(e => e.FServiceNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_service_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FServiceName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_service_name");
            entity.Property(e => e.FServiceStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_service_status");
        });

        modelBuilder.Entity<TdPackageSite>(entity =>
        {
            entity.HasKey(e => e.FSiteNo)
                .HasName("td_package_site_x")
                .IsClustered(false);

            entity.ToTable("td_package_site");

            entity.Property(e => e.FSiteNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_site_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSiteName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("f_site_name");
            entity.Property(e => e.FSiteStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_site_status");
        });

        modelBuilder.Entity<TdPict>(entity =>
        {
            entity.HasKey(e => e.FPictNo)
                .HasName("td_pict_x")
                .IsClustered(false);

            entity.ToTable("td_pict");

            entity.Property(e => e.FPictNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_pict_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FPictGroup)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_pict_group");
            entity.Property(e => e.FPictName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("f_pict_name");
            entity.Property(e => e.FPictOptional)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_pict_optional");
            entity.Property(e => e.FPictStaus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_pict_staus");
            entity.Property(e => e.FPictTable)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_pict_table");
            entity.Property(e => e.FPictType)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("f_pict_type");
        });

        modelBuilder.Entity<TdQuali>(entity =>
        {
            entity.HasKey(e => e.FQualiNo)
                .HasName("td_quali_x")
                .IsClustered(false);

            entity.ToTable("td_quali");

            entity.Property(e => e.FQualiNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_quali_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FQualiName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_quali_name");
            entity.Property(e => e.FQualiStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_quali_status");
        });

        modelBuilder.Entity<TdSeason>(entity =>
        {
            entity.HasKey(e => e.FSeasonNo)
                .HasName("td_season_x")
                .IsClustered(false);

            entity.ToTable("td_season");

            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FHajDateFromH)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_haj_date_from_h");
            entity.Property(e => e.FHajDateFromM)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_haj_date_from_m");
            entity.Property(e => e.FHajDateToH)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_haj_date_to_h");
            entity.Property(e => e.FHajDateToM)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_haj_date_to_m");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSeasonDateFromH)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_date_from_h");
            entity.Property(e => e.FSeasonDateFromM)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_date_from_m");
            entity.Property(e => e.FSeasonDateToH)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_date_to_h");
            entity.Property(e => e.FSeasonDateToM)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_date_to_m");
            entity.Property(e => e.FSeasonName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("f_season_name");
            entity.Property(e => e.FSeasonOrderDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_order_date_from");
            entity.Property(e => e.FSeasonOrderDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_order_date_to");
            entity.Property(e => e.FSeasonOrderStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_order_status");
            entity.Property(e => e.FSeasonStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_status");
        });

        modelBuilder.Entity<TdSeasonStatus>(entity =>
        {
            entity.HasKey(e => e.FSeasonNo)
                .HasName("td_season_status_x")
                .IsClustered(false);

            entity.ToTable("td_season_status");

            entity.Property(e => e.FSeasonNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_season_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSeasonOrderDateFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_order_date_from");
            entity.Property(e => e.FSeasonOrderDateTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_season_order_date_to");
            entity.Property(e => e.FSeasonOrderStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_order_status");
            entity.Property(e => e.FSeasonStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_season_status");
        });

        modelBuilder.Entity<TdSection>(entity =>
        {
            entity.HasKey(e => e.FSectionNo)
                .HasName("td_section_x")
                .IsClustered(false);

            entity.ToTable("td_section");

            entity.Property(e => e.FSectionNo)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("f_section_no");
            entity.Property(e => e.FCompanyId)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_company_id");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FSectionEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_section_email");
            entity.Property(e => e.FSectionJaw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_section_jaw");
            entity.Property(e => e.FSectionName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_section_name");
            entity.Property(e => e.FSectionNameShort)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("f_section_name_short");
            entity.Property(e => e.FSectionStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_section_status");
            entity.Property(e => e.FSectionType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_section_type");
        });

        modelBuilder.Entity<TdSupplier>(entity =>
        {
            entity.HasKey(e => e.FSupplieNo)
                .HasName("td_suppliers_x")
                .IsClustered(false);

            entity.ToTable("td_suppliers");

            entity.Property(e => e.FSupplieNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_supplie_no");
            entity.Property(e => e.FAddress)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_address");
            entity.Property(e => e.FBankIbanNo)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("f_bank_iban_no");
            entity.Property(e => e.FBankNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_bank_no");
            entity.Property(e => e.FBuildingNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_building_no");
            entity.Property(e => e.FCityNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_city_no");
            entity.Property(e => e.FDistrictNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_district_no");
            entity.Property(e => e.FEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("f_email");
            entity.Property(e => e.FFaxNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("f_fax_no");
            entity.Property(e => e.FIdDateExpiry)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_id_date_expiry");
            entity.Property(e => e.FIdDateIssue)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("f_id_date_issue");
            entity.Property(e => e.FIdNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_id_no");
            entity.Property(e => e.FJawNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("f_jaw_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FMapLatitude)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_map_latitude");
            entity.Property(e => e.FMapLongitude)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_map_longitude");
            entity.Property(e => e.FPostalCode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("f_postal_code");
            entity.Property(e => e.FScondaryNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_scondary_no");
            entity.Property(e => e.FSpecialNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_special_no");
            entity.Property(e => e.FStreet)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_street");
            entity.Property(e => e.FSupplieName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_supplie_name");
            entity.Property(e => e.FSupplieStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_supplie_status");
            entity.Property(e => e.FTelNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("f_tel_no");
            entity.Property(e => e.FUnifiedNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_unified_no");
            entity.Property(e => e.FVatNo)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("f_vat_no");
            entity.Property(e => e.FVatType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_vat_type");
        });

        modelBuilder.Entity<TdTransport>(entity =>
        {
            entity.HasKey(e => e.FTransportNo)
                .HasName("td_transport_x")
                .IsClustered(false);

            entity.ToTable("td_transport");

            entity.Property(e => e.FTransportNo)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_transport_no");
            entity.Property(e => e.FLastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("f_last_update");
            entity.Property(e => e.FLastUpdateOper)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_last_update_oper");
            entity.Property(e => e.FLastUpdateOperNo)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("f_last_update_oper_no");
            entity.Property(e => e.FLastUpdateSum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("f_last_update_sum");
            entity.Property(e => e.FLastUpdateUser)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("f_last_update_user");
            entity.Property(e => e.FTransportMin)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("f_transport_min");
            entity.Property(e => e.FTransportName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("f_transport_name");
            entity.Property(e => e.FTransportStatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("f_transport_status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
