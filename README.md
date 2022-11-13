# Authors_and_Books_API
C# API using .net 6

To run:

```
dotnet build

```

---

For the appsettings.json:

```javascript
{
  "ConnectionStrings": {
    "WebApiDatabase": "your database credentials"
},

  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```

---

## ENDPOINTS

<ul>
    <li>/api/author</li>
    <li>/api/author/{id}</li>
    <li>/api/book</li>
    <li>/api/book/{id}</li>
</ul>
