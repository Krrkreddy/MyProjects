Steps to be followed :-

Assignment is developed in Microsoft Visual Studio. so, to run the Assignment you should have Visual Studio installed in your PC/Laptop.

In SQL database of your choice, run below SQL query to create required db tables in SQL server managaement studio.


<<start of query. copy from next line>>

/****** Object:  Table [dbo].[Contacts] ******/ 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
[Id] [int] DENTITY(1,1) NOT NULL,
[ContactName] [nvarchar](100) NOT NULL,
[ContactNumber] [int] NOT NULL,
[ContactEmail] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRegistration] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRegistration](
[Id] [int]  IDENTITY(1,1) NOT NULL,
[Email] [nvarchar](100) NOT NULL,
[Password] [nvarchar](50) NOT NULL,
[SecretCode] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

<<end of query. Copy until previous line>>


1. Download and Extract the zip file and navigate to the folder ContactsApp .
2.Open ContactsApp.sln. This will open the solution of the Assignment in Visual studio.
3. Once the project is loaded, Go to menu>  View > Solution explorer. Navigate to file Web.config in solution explorer and open the file.
4. Go to end of the file. In connectionStrings section modify the connectionString to reflect your database connection information.
	Here, catalog value shold be your database name. In my case it is srk. Also modify username and password to connect to your database. Save it.
5.Go to > Debug Menu > Start without Debugging or Simply press CTRL F5. This will Launch the Application in the web browser and starts with Sign In Page.
6.The rest of the appliction is self explanatory regards to navigation.
