if not exists (select * from [dbo].[User])
Begin
	Insert into dbo.[User] (FirstName, LastName, Email)
	Values ('John', 'Smith', 'js@gmail.com'),
	('Eli', 'Jones', 'Ej@gmail.com'),
	('Tim', 'Storm', 'TS@gmail.com'),
	('Mary', 'Lopez', 'ML@gmail.com')
End