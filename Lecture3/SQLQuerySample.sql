-- Iteration 1
--SELECT [ID]
--      ,[Name]
--  FROM [dbo].[Country];

-- Iteration 2
--SELECT * FROM Country;
--Select * From City;

-- Iteration 3
--Select Country.Name, City.Name 
--	From Country inner join City 
--	on Country.ID = City.CountryID;

-- Iteration 4
--INSERT INTO [dbo].[Country]
--           ([Name])
--     VALUES
--           ('Afghanistan');

-- Iteration 5
--UPDATE [dbo].[Country]
--   SET [Name] = 'Afghani'
-- WHERE ID = 5;

-- Iteration 6
--DELETE FROM [dbo].[Country]
--      WHERE ID = 4;

-- Iteration 7
Select * from Country Where [Name] Like '%Pak%';


