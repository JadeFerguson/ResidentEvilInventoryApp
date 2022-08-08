# ResidentEvilInventoryApp

## Getting Started
- VS 2022
- Inventory Database installed
- .NET 6

You may need to change the DB connection string located in the InventoryContext class.
By default it points to mssqllocaldb. If your Inventory script is not installed on mssqllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Inventory");
```
