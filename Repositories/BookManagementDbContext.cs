using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Entities;

namespace Repositories;

public partial class BookManagementDbContext : DbContext
{
    //CLASS NAY DAI DIEN CHO SQL SERVER, LA CLASS CON CUA CLASS GOC TEN LA DbContext
    //Class Cha co tat ca cac ham lien quan den viec CRUD table, minh chi viec dung, goi ham cua class Cha ma dung trong Class Con nay
    //class nayy no xuat phat tu EF CORE parkage minh da cai (4 mon)
    //neu muon choi voi MySQL thi cai them driver/class EF core ung voi MySQL
    //DAC BIET LUU Y CLASS NAY CHUA SAN 3 CAI PROPERTIES UNG VOI 3 TABLE CUA DATABASE
    //DbSet<Book> Books
    //DbSet<BookCategory> BookCategories
    //DbSet<UserAccout> UserAccouts
    //TA . 3 THANG NAY TUONG DUONG SELECT *
    //TA . 3 THANG NAY ROI GOI HAM TUONG UNG THEO STYLE LAMBDA EXPRESION/SQL STYLE LINQ
    //GIUP TA TINH TOAN (SUM, AVG, GROUP BY) VA FILTER (WHERE) DAM DATA TU TABLE

    //CLASS NAY VI CHOI TRUC TIEP DATA BASE NEN NO SE CHUA BEN TRONG CAU LENH KET NOI CSDL/SQLSERVER
    //CAU LENH KET NOI DB SQL SERVER DC GOI LA CHUOI KET NOI  - CONNECTION STRING
    //TRUC TIEP TRONG CLASS NAY GOI LA HARD CODE CONECCTION STRING VA DIEU NAY NGUY HIEM, KO TOT VI CHUOI CONNECTION STRING SE DC NHUNG VAO DLL VA NEU TA DUNG TOOL DICH NGUOC LA LOI RA DC THONG TIN SERVER

    //SOLUTION: MOVE, CAT CAI CHUOI HARD CODE NAY DE O CHO KHAC, BEN NGOAI DLL
    //DE O 1 TAP TIN DC GOI LA TAP TIN CAU HINH: CONFIGURATION FILE
    //                  TAP TIN CHUA CAC THONG SO HOAT DONG CUA APP
    //          THUONG SE LA .JSON HOAC .XML 
    //TA DE CHUOI KET NOI CSDL TRONG TAP TIN LE KO PHAI SORCE CODE NEN NO KO DC NHUNG TRONG .DLL
    //NHO KI THUAT TACH THONG TIN KET NOI CSDL RA NGOAI CODE -> TA HUONG THEM 1 LOI ICH: APP CO THE CHOI VOI CAC SERVER KHAC NHAU, CAC CAP USER/PASS KHAC NHAU

    //KHAO THI CHAM BAI SUA FILE JSON DE PHU HOP VOI SERVER CUA HO
    //FILE NAY CAU TRUC THE NAO, DAT O DAU???
    //DE O GUI PROJECT
    //TUYET CHIEU: COPY TO OUTPUT FOLDER
    //CONTENT CUA FILE DE THI SE CHO
    //GSON, JACKSON LIB
    public BookManagementDbContext()
    {
    }

    public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    //ham doc chuoi ket noi DB tu phai json/appsetting.json
    //private vi chi can dung noi bo
    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C20788862183");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_BookCategory");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.BookCategoryId).HasName("PK__BookCate__6347EC040B1EDE49");

            entity.ToTable("BookCategory");

            entity.Property(e => e.BookCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BookGenreType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__UserAcco__0CF04B18A356DA43");

            entity.ToTable("UserAccount");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
