namespace Code1st_De2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class De2Code1st : DbContext
    {
        // Your context has been configured to use a 'De3Code1st' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Code1st_De3.DAL.De3Code1st' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'De3Code1st' 
        // connection string in the application configuration file.
        public De2Code1st()
            : base("name=De2Code1st")
        {
            Database.SetInitializer<De2Code1st>(new DataBase());
        }
        public class DataBase : CreateDatabaseIfNotExists<De2Code1st>
        {
            protected override void Seed(De2Code1st context)
            {
                //base.Seed(context);
                DocGia dg1 = new DocGia
                {
                    Ten = "Doc Gia 1",
                    GioiTinh = true,
                    NgaySinh = Convert.ToDateTime("9/6/1998"),
                    DiaChi = "195 Nguyen Luong Bang",
                    CoQuan = "Pornhub"           
                };
                LoaiSach ls1 = new LoaiSach
                {
                    TenLoai = "Giáo dục giới tính",
                    ViTri = "Khu D"
                };
                MuonTra mt1 = new MuonTra
                {
                    NgayMuon = Convert.ToDateTime("6/9/2018"),
                    NgayHenTra = Convert.ToDateTime("5/5/2019"),
                    NgayTra = Convert.ToDateTime("5/10/2019")
                };
                NhanVien nv1 = new NhanVien
                {
                    GioiTinh = true,
                    Ten = "Nhan Vien"
                };
                Sach s1 = new Sach
                {
                    TenSach = "Kamasutra",
                    SoTrang = 6969,
                    TacGia = "Indianoy",
                    NXB = "Kim Dong",
                    SoLuong = 69,
                };
                ls1.Sachs.Add(s1);
                dg1.MuonTras.Add(mt1);
                nv1.MuonTras.Add(mt1);
                s1.MuonTras.Add(mt1);
                context.DocGias.Add(dg1);
                context.LoaiSachs.Add(ls1);
                context.NhanViens.Add(nv1);
                context.SaveChanges();
            }

        }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<LoaiSach> LoaiSachs { get; set; }
        public virtual DbSet<MuonTra> MuonTras { get; set; }
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