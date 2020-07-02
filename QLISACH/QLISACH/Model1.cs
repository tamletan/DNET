namespace QLISACH
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QLISACH.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new DB());
        }

        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<LoaiSach> LoaiSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<MuonTra> MuonTras { get; set; }

        public class DB : CreateDatabaseIfNotExists<Model1>
        {
            protected override void Seed(Model1 context)
            {
                base.Seed(context);

                MuonTra m1 = new MuonTra
                {
                    ID = 1,
                    MaDG = "dg1",
                    MaNV = "nv1",
                    MaSach = "s1",
                    NgayMuon = new DateTime(2018, 12, 30),
                    NgayTra = new DateTime(2019, 1, 15),
                    NgayHenTra = new DateTime(2019, 1, 18)
                };
               
                DocGia a = new DocGia
                {
                    MaDG = "dg1",
                    HoTenDG = "Nguyen Van A",
                    DiaChi = "123 Nui Thanh",
                    NgaySinhDG = new DateTime(1990, 03, 02),
                    GioiTinhDG = true,
                    CoQuan = "Chinh phu"
                };
                a.MuonTras.Add(m1);
                context.DocGias.Add(a);

                context.DocGias.Add(new DocGia
                {
                    MaDG = "dg2",
                    HoTenDG = "Nguyen Van B",
                    DiaChi = "124 Nui Thanh",
                    NgaySinhDG = new DateTime(1991, 03, 02),
                    GioiTinhDG = true,
                    CoQuan = "Cong ty dien luc"
                });
                context.DocGias.Add(new DocGia
                {
                    MaDG = "dg3",
                    HoTenDG = "Nguyen Van C",
                    DiaChi = "255 Nui Thanh",
                    NgaySinhDG = new DateTime(1992, 03, 02),
                    GioiTinhDG = false,
                    CoQuan = "Cong ti nuoc"
                });
                NhanVien nv1 = new NhanVien
                {
                    MaNV = "nv1",
                    HoTenNV = "Le Van A",
                    GioiTinhNV = true,
                };
                context.NhanViens.Add(nv1);
                context.NhanViens.Add(new NhanVien
                {
                    MaNV = "nv2",
                    HoTenNV = "Le Van B",
                    GioiTinhNV = false,
                });
                context.NhanViens.Add(new NhanVien
                {
                    MaNV = "nv3",
                    HoTenNV = "Le Van C",
                    GioiTinhNV = true,
                });

                context.LoaiSachs.Add(new LoaiSach
                {
                    MaLoai = "ls1",
                    TenLoai = "Van hoc",
                    ViTri = "vt1"
                });
                context.LoaiSachs.Add(new LoaiSach
                {
                    MaLoai = "ls2",
                    TenLoai = "Doi Song",
                    ViTri = "vt2"
                });
                context.LoaiSachs.Add(new LoaiSach
                {
                    MaLoai = "ls3",
                    TenLoai = "Khoa Hoc",
                    ViTri = "vt3"
                });

                context.Sachs.Add(new Sach
                {
                    MaSach = "s1",
                    TenSach = "Nhung ngay dep troi",
                    SoTrang = 100,
                    TacGia = "Bang Kieu",
                    MaLoai = "ls1",
                    NXB = "NXB Kim Dong",
                    SoLuong = 100
                });
                context.Sachs.Add(new Sach
                {
                    MaSach = "s2",
                    TenSach = "Nhung ngay dep troi phan 2",
                    SoTrang = 100,
                    TacGia = "Bang Kieu",
                    MaLoai = "ls1",
                    NXB = "NXB Kim Dong",
                    SoLuong = 100
                });
                context.Sachs.Add(new Sach
                {
                    MaSach = "s3",
                    TenSach = "Nhung ngay dep troi phan 3",
                    SoTrang = 100,
                    TacGia = "Bang Kieu",
                    MaLoai = "ls1",
                    NXB = "NXB Kim Dong",
                    SoLuong = 100
                });

                context.SaveChanges();
            }
        } 
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