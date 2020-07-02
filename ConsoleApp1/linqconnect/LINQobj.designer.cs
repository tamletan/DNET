﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linqconnect
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WinFormDB")]
	public partial class LINQobjDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFaculty(Faculty instance);
    partial void UpdateFaculty(Faculty instance);
    partial void DeleteFaculty(Faculty instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public LINQobjDataContext() : 
				base(global::linqconnect.Properties.Settings.Default.WinFormDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQobjDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQobjDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQobjDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQobjDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Faculty> Faculties
		{
			get
			{
				return this.GetTable<Faculty>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Faculty")]
	public partial class Faculty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FID;
		
		private string _Fname;
		
		private EntitySet<Student> _Students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFIDChanging(int value);
    partial void OnFIDChanged();
    partial void OnFnameChanging(string value);
    partial void OnFnameChanged();
    #endregion
		
		public Faculty()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FID
		{
			get
			{
				return this._FID;
			}
			set
			{
				if ((this._FID != value))
				{
					this.OnFIDChanging(value);
					this.SendPropertyChanging();
					this._FID = value;
					this.SendPropertyChanged("FID");
					this.OnFIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fname", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Fname
		{
			get
			{
				return this._Fname;
			}
			set
			{
				if ((this._Fname != value))
				{
					this.OnFnameChanging(value);
					this.SendPropertyChanging();
					this._Fname = value;
					this.SendPropertyChanged("Fname");
					this.OnFnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Faculty_Student", Storage="_Students", ThisKey="FID", OtherKey="FID")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Faculty = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Faculty = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MSSV;
		
		private string _Sname;
		
		private System.Nullable<System.DateTime> _Sbirth;
		
		private int _FID;
		
		private System.Nullable<double> _DTB;
		
		private System.Nullable<bool> _Gender;
		
		private EntityRef<Faculty> _Faculty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMSSVChanging(int value);
    partial void OnMSSVChanged();
    partial void OnSnameChanging(string value);
    partial void OnSnameChanged();
    partial void OnSbirthChanging(System.Nullable<System.DateTime> value);
    partial void OnSbirthChanged();
    partial void OnFIDChanging(int value);
    partial void OnFIDChanged();
    partial void OnDTBChanging(System.Nullable<double> value);
    partial void OnDTBChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    #endregion
		
		public Student()
		{
			this._Faculty = default(EntityRef<Faculty>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSSV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MSSV
		{
			get
			{
				return this._MSSV;
			}
			set
			{
				if ((this._MSSV != value))
				{
					this.OnMSSVChanging(value);
					this.SendPropertyChanging();
					this._MSSV = value;
					this.SendPropertyChanged("MSSV");
					this.OnMSSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sname", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Sname
		{
			get
			{
				return this._Sname;
			}
			set
			{
				if ((this._Sname != value))
				{
					this.OnSnameChanging(value);
					this.SendPropertyChanging();
					this._Sname = value;
					this.SendPropertyChanged("Sname");
					this.OnSnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sbirth", DbType="Date")]
		public System.Nullable<System.DateTime> Sbirth
		{
			get
			{
				return this._Sbirth;
			}
			set
			{
				if ((this._Sbirth != value))
				{
					this.OnSbirthChanging(value);
					this.SendPropertyChanging();
					this._Sbirth = value;
					this.SendPropertyChanged("Sbirth");
					this.OnSbirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FID", DbType="Int NOT NULL")]
		public int FID
		{
			get
			{
				return this._FID;
			}
			set
			{
				if ((this._FID != value))
				{
					if (this._Faculty.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFIDChanging(value);
					this.SendPropertyChanging();
					this._FID = value;
					this.SendPropertyChanged("FID");
					this.OnFIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTB", DbType="Float")]
		public System.Nullable<double> DTB
		{
			get
			{
				return this._DTB;
			}
			set
			{
				if ((this._DTB != value))
				{
					this.OnDTBChanging(value);
					this.SendPropertyChanging();
					this._DTB = value;
					this.SendPropertyChanged("DTB");
					this.OnDTBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Faculty_Student", Storage="_Faculty", ThisKey="FID", OtherKey="FID", IsForeignKey=true)]
		public Faculty Faculty
		{
			get
			{
				return this._Faculty.Entity;
			}
			set
			{
				Faculty previousValue = this._Faculty.Entity;
				if (((previousValue != value) 
							|| (this._Faculty.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Faculty.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._Faculty.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._FID = value.FID;
					}
					else
					{
						this._FID = default(int);
					}
					this.SendPropertyChanged("Faculty");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591