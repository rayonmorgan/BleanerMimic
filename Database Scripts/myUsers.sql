use gleanerReplicate
go

create table MyUsers(
		myId int identity(1,1) not null primary key,     
        myUserName nvarchar(60),   
        myPassword nvarchar(60)  
)