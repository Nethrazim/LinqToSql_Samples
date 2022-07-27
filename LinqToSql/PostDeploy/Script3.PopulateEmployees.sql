IF NOT EXISTS(SELECT 1 FROM [dbo].[Employee])
BEGIN 
    INSERT INTO [dbo].[Employee]([FirstName], [LastName])
    SELECT 'Vlad', 'Branzei'
END
