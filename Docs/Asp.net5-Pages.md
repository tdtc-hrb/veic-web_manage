---
title: "ASP.net Core 的Pages应用"
description: "Pro ASP.NET Core 3.1+"
date: 2021-03-23T12:08:08+08:00
---

# Create project
![Project 1](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323080348.png)
![Project 2](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323081111.png)

## Set Namespace
![Project 3](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323081325.png)

# Models
Create Models and Data folders.
![Project 4](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323081652.png)

Install Pagakes:
```bash
Install-Package Microsoft.EntityFrameworkCore -Version 5.0.6
Install-Package MySql.EntityFrameworkCore -Version 5.0.3.1
```

## DB Context
add class
> add -> New Item
![Project 5](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323081902.png)
Implement DbContext:
```c#
public class CarnumberDbContext : DbContext
{
    public CarnumberDbContext(DbContextOptions<CarnumberDbContext> options) : base(options)
    {
    }
}
```

## DB Connection String
> appsettings.json
```c#
"Data": {
  "VeicWeb": {
    "ConnectionString": "server=127.0.0.1; user id=DBAdmin; password=xbfirst; database=carnumber; pooling=false; Convert Zero Datetime=True;"
  }
}
```

## Add DB Service
> Startup.cs
>> ConfigureServices()
```c#
services.AddDbContext<CarnumberDbContext>(options =>
        options.UseMySQL(Configuration["Data:VeicWeb:ConnectionString"])
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(MyLoggerFactory)
);
```

## add Entity class
> User.cs
```c#
public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public Boolean Flag { get; set; }
    public DateTime Created { get; set; }
}
```

## add DbSets
> CarnumberDbContext.cs

```c#
public DbSet<User> Users { get; set; }
```

# Modules

## Users
Create a new folder in Pages and name it "Users".
![project 6](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323083910.png)

right click,
```bash
Add -> Razor Page -> Razor Pages using Entity Framework(CRUD)
```
![project 7](https://raw.githubusercontent.com/tdtc-hrb/veic-web_manage/master/Docs/20210323084309.png)

# Link
> Shared/_Layout.cshtml

```html
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-page="/Users/Index">Users</a>
</li>
```
