veic_web Pages
========

使用向导建立工程:     
  ASP.NET Core Web App

# development environment
- SDK: .NET Core 3.1+    
- IDE: VS2019+    
- Database: MySQL 5.7+    
- Web Server: IIS 10.0+

# project structure
- Razor Pages    
- Front end: Bootstrap v5    
- JS library: JQuery 3.5+


# About Razor Page(CURD)
> EF Core 5.0 is compatible with MySql.Data.EntityFrameworkCore 8.0.23+.
```bash
Install-Package MySql.EntityFrameworkCore -Version 5.0.0
```

## Model
First create an entity class,
Then, add in DbContext.
## Module
Create a new folder in Pages, the folder name needs to be consistent with the module name.
```bash
Add -> Razor Page -> Razor Pages using Entity Framework(CURD)
```
## Link
Add the module link in the layout.

# Licenses
.NET Core repos typically use either the [MIT](https://github.com/dotnet/core/blob/master/LICENSE.TXT) or [Apache 2](http://www.apache.org/licenses/LICENSE-2.0) licenses for code.
