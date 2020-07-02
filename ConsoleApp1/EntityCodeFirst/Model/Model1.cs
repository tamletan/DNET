namespace EntityCodeFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityCodeFirst.Model.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new DB());
        }

        public class DB : DropCreateDatabaseAlways<Model1>
        {
            protected override void Seed(Model1 context)
            {
                //base.Seed(context);
                Faculty ITFaculty = new Faculty()
                {
                    Fname = "Cong nghe thong tin"
                };
                Faculty TeleFaculty = new Faculty()
                {
                    Fname = "Dien tu vien thong"
                };
                Student sv1 = new Student()
                {
                    Sname = "sinhvien1",
                    Sbirth = DateTime.Today,
                    Gender = true,
                    DTB = 7.5
                };
                Student sv2 = new Student()
                {
                    Sname = "sinhvien2",
                    Sbirth = DateTime.Today,
                    Gender = false,
                    DTB = 9.0
                };
                ITFaculty.Students.Add(sv1);
                TeleFaculty.Students.Add(sv2);
                context.Faculties.Add(ITFaculty);
                context.Faculties.Add(TeleFaculty);
                context.SaveChanges();
            }
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}