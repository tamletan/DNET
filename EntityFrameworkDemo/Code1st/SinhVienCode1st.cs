namespace Code1st
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SinhVienCode1st : DbContext
    {
        // Your context has been configured to use a 'SinhVienCode1st' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Code1st.SinhVienCode1st' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SinhVienCode1st' 
        // connection string in the application configuration file.
        public SinhVienCode1st()
            : base("name=SinhVienCode1st")
        {
            Database.SetInitializer<SinhVienCode1st>(new DB());
        }
        public class DB : CreateDatabaseIfNotExists<SinhVienCode1st>
        {
            protected override void Seed(SinhVienCode1st context)
            {
                /*Khoa Faculty1 = new Khoa()
                {
                    TenKhoa = "Cong Nghe Thong Tin"
                };
                Khoa Faculty2 = new Khoa()
                {
                    TenKhoa = "Dien Tu Vien Thong"
                };
                SinhVien A1 = new SinhVien()
                {
                    TenSV = "TuyetPython",
                    Diem = 10,
                    Gioitinh = false,
                    Ngaysinh = Convert.ToDateTime("6/9/1998")

                };
                SinhVien A2 = new SinhVien()
                {
                    TenSV = "ThangC#",
                    Diem = 10,
                    Gioitinh = true,
                    Ngaysinh = Convert.ToDateTime("6/9/1998")
                };
                SinhVien A3 = new SinhVien()
                {
                    TenSV = "PhongAI",
                    Diem = 10,
                    Gioitinh = true,
                    Ngaysinh = Convert.ToDateTime("6/9/1998")
                };
                SinhVien A4 = new SinhVien()
                {
                    TenSV = "TriJS",
                    Diem = 10,
                    Gioitinh = true,
                    Ngaysinh = Convert.ToDateTime("6/9/1998")
                };
                Faculty1.SinhViens.Add(A1);
                Faculty2.SinhViens.Add(A2);
                Faculty2.SinhViens.Add(A3);
                Faculty2.SinhViens.Add(A4);
                context.Khoas.Add(Faculty1);
                context.Khoas.Add(Faculty2);
                context.SaveChanges();*/
            }
        }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
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