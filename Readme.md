### Install ef-core tool
```
dotnet tool install --global dotnet-ef
```
Then do the instructions to add it to the profile

# Migrations

### Create Migration
```
dotnet-ef migrations add InitialRequests --project  ../../broker-data/src/OregonNexus.Broker.Data.Migrations.PostgreSQL
```
### Remove Last Migration
```
dotnet-ef migrations remove --project  ../../broker-data/src/OregonNexus.Broker.Data.Migrations.PostgreSQL
```
### Apply to latest migration
```
dotnet ef database update
```
### Unapply migrations back to specified migration name
```
dotnet ef database update [Migration]
```
### Restore to applied first migration
```
dotnet ef database update 0
```