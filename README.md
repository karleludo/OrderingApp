# About The Project
"OrderingApp" is a simple ordering kiosk/POS/CRUD windows application.

## Built with
* .Net
* Windows Forms
* RDLC - for generating reports/receipt
* SQL Server

## Installation

### Database Setup
*Below are the steps on how to replicate the database used for this project. `OrderingAppDBSQLmanage` is the target database name on the script, change this in `OrderingAppDatabaseSchemaScript.sql` if you want, although you might have to change `App.config` connection strings and everything else in the code that uses this name.*

1. Create database with name `OrderingAppDBSQLmanage`
2. Execute full SQL script on [`OrderingAppDatabaseSchemaScript.sql`](OrderingApp/Database%20Script/OrderingAppDatabaseSchemaScript.sql)

*from sql script*
```TSQL
USE [OrderingAppDBSQLmanage]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 26/01/2022 19:00:16 ******/
.
.
.
/* and so on... */

```

  *change `OrderingAppDBSQLmanage` if you want to change the target database name.*
  
 
### Establish database connection and changing configurations. `App.config`

- [ ] make installation system agnostic.
- [ ] Finish installation tutorial

## Authors
* Karl Glenn Eludo - [GitHub](https://github.com/karleludo)
