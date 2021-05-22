
IF  NOT EXISTS (SELECT object_id FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Contact]') AND type = 'U')

BEGIN
CREATE TABLE [dbo].[Contact](
    FirstName VARCHAR(255) NOT NULL, 
    LastName VARCHAR(255) NOT NULL, 
    Address VARCHAR(255) NOT NULL,
) 

END