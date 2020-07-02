create table Room
(
	MaLoaiPhong int primary key not null,
	LoaiPhong nvarchar(max)
)
create table CSVC
(
	MaPhong int identity primary key not null,
	TenPhong nvarchar(max),
	Tang int,
	MaLoaiPhong int foreign key (MaLoaiPhong) references Room on delete cascade on update cascade,
	TrangThai bit,
	NgaySuDung date
)

drop table CSVC
insert into dbo.CSVC values ('Phong 1',1,1,1,'2/19/2019')
insert into dbo.CSVC values ('Phong 2',3,2,1,'1/4/2019')
insert into dbo.CSVC values ('Phong 3',2,3,0,'2/30/2019')

insert into dbo.Room values (1,'Phong Hoc')
insert into dbo.Room values (2,'Phong Thuc Hanh')
insert into dbo.Room values (3,'Phong Lam Viec')