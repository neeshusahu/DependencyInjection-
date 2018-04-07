CREATE TABLE [dbo].[Employee]
(
	[Id] INT Identity(1,1),
	Name varchar(255) not null,
	Email varchar(500) not null
	primary key(Email)
)
