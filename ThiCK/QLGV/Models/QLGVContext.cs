namespace QLGV.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QLGVContext : DbContext
    {
        // Your context has been configured to use a 'QLGVContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QLGV.Models.QLGVContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLGVContext' 
        // connection string in the application configuration file.
        public QLGVContext()
            : base("name=QLGVContext")
        {
            Database.SetInitializer<QLGVContext>(new DB());
        }

        public class DB : DropCreateDatabaseAlways<QLGVContext>
        {
            protected override void Seed(QLGVContext context)
            {
                CoSo CS1 = new CoSo { TenCoSo = "Co So 1" };
                CoSo CS2 = new CoSo { TenCoSo = "Co So 2" };
                DVDT DT1 = new DVDT { TenDVDT = "Don Vi 1" };
                DVDT DT2 = new DVDT { TenDVDT = "Don Vi 2" };
                DVDT DT3 = new DVDT { TenDVDT = "Don Vi 3" };
                GV GV1 = new GV
                {
                    HoTen = "Tran Van A",
                    NgaySinh = new DateTime(1980, 7, 12),
                    SDT = 0796475632,
                    GioiTinh = true,
                    GhiChu = "Nothing"
                };
                GV GV2 = new GV
                {
                    HoTen = "Tran Van B",
                    NgaySinh = new DateTime(1976, 4, 02),
                    SDT = 0832175632,
                    GioiTinh = false,
                    GhiChu = "Nothing"
                };
                GV GV3 = new GV
                {
                    HoTen = "Tran Van C",
                    NgaySinh = new DateTime(1985, 7, 20),
                    SDT = 0296463432,
                    GioiTinh = true,
                    GhiChu = "Nothing"
                };
                DT1.GVs.Add(GV1);
                DT1.GVs.Add(GV2);
                DT2.GVs.Add(GV3);
                CS1.DVDTs.Add(DT1);
                CS1.DVDTs.Add(DT3);
                CS2.DVDTs.Add(DT2);
                context.CoSos.Add(CS1);
                context.CoSos.Add(CS2);
                context.SaveChanges();
            }
        }

        public virtual DbSet<CoSo> CoSos { get; set; }
        public virtual DbSet<DVDT> DVDTs { get; set; }
        public virtual DbSet<GV> GVs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}