namespace De1CuoiKy
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class De1DB : DbContext
    {

        public De1DB()
            : base("name=De1DB")
        {
            Database.SetInitializer<De1DB>(new DB());
        }
        public class DB : CreateDatabaseIfNotExists<De1DB>
        {
            protected override void Seed(De1DB db)
            {
                LOAISACH a = new LOAISACH()
                {
                    Maloai = "LS001",
                    TenLoai = "Trinh Thám",
                    Vitri = "XA001"
                };
                LOAISACH b = new LOAISACH()
                {
                    Maloai = "LS002",
                    TenLoai = "Tiểu Thuyết",
                    Vitri = "XA002"
                };
                SACH s1 = new SACH()
                {
                    Masach = "MS001",
                    Tensach = "Sherlock Homles",
                    Sotrang = 3000,
                    Maloai = "LS001",
                    Tacgia = "Conan Doyle",
                    NXB = "Kim Đồng",
                    Soluong = 100
                };
                a.SACHs.Add(s1);
                SACH s2 = new SACH()
                {
                    Masach = "MS002",
                    Tensach = "Titanic",
                    Sotrang = 1000,
                    Maloai = "LS002",
                    Tacgia = "James",
                    NXB = "Kim Đồng",
                    Soluong = 30
                };
                b.SACHs.Add(s2);
                DOCGIA d1 = new DOCGIA()
                {
                    Madg = "DG001",
                    Hoten = "Nguyễn Văn A",
                    Gioitinh = true,
                    Coquan = "Fahasa",
                    Ngaysinh = DateTime.Parse("12/21/1998"),
                    Diachi = "Danang",
                };
                DOCGIA d2 = new DOCGIA()
                {
                    Madg = "DG002",
                    Hoten = "Nguyễn Thị C",
                    Gioitinh = false,
                    Coquan = "Phương Nam",
                    Ngaysinh = DateTime.Parse("12/2/1998"),
                    Diachi = "Quảng Nam",
                };
                NHANVIEN nv1 = new NHANVIEN()
                {
                    Manv = "NV001",
                    Hoten = "Nguyễn Văn Nhân",
                    Gioitinh = true
                };
                NHANVIEN nv2 = new NHANVIEN()
                {
                    Manv = "NV002",
                    Hoten = "Nguyễn Thị Viên",
                    Gioitinh = false
                };
                MUONTRA m1 = new MUONTRA()
                {
                    Id = 1,
                    Madg = "DG001",
                    Manv = "NV001",
                    Masach = "MS001",
                    Ngaymuon = Convert.ToDateTime("5/10/2019"),
                    Ngaytra = Convert.ToDateTime("5/17/2019"),
                    Ngayhentra = Convert.ToDateTime("5/15/2019")
                };
                s1.MUONTRAs.Add(m1);
                //d1.MUONTRAs.Add(m1);
                //nv1.MUONTRAs.Add(m1);
                MUONTRA m2 = new MUONTRA()
                {
                    Id = 1,
                    Madg = "DG002",
                    Manv = "NV002",
                    Masach = "MS002",
                    Ngaymuon = Convert.ToDateTime("5/12/2019"),
                    Ngaytra = Convert.ToDateTime("5/19/2019"),
                    Ngayhentra = Convert.ToDateTime("5/17/2019")
                };
                s2.MUONTRAs.Add(m2);
                //d2.MUONTRAs.Add(m2);
                //nv2.MUONTRAs.Add(m2);

                db.LoaiSachs.Add(a);
                db.LoaiSachs.Add(b);

                db.NhanViens.Add(nv1);
                db.NhanViens.Add(nv2);

                db.DocGias.Add(d1);
                db.DocGias.Add(d2);

                db.SaveChanges();
            }
        }
        public DbSet<DOCGIA> DocGias { get; set; }
        public DbSet<NHANVIEN> NhanViens { get; set; }
        public DbSet<LOAISACH> LoaiSachs { get; set; }
        public DbSet<SACH> Sachs { get; set; }
        public DbSet<MUONTRA> MuonTras { get; set; }
    }
}