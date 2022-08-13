# ResidentEvilInventoryApp

## Getting Started
- VS 2022
- [Inventory Database](Inventory.sql) installed
- .NET 6

You may need to change the DB connection string located in the InventoryContext class.
By default it points to mssqllocaldb. If your Inventory script is not installed on mssqllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Inventory");
```

### Some useful links
[Adding to existing database](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database?redirectedfrom=MSDN)
