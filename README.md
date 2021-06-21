# Blogs App

<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#azure-sql-database-creation">Azure SQL Database Creation(Optional)</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

### Built With

* [Bootstrap](https://getbootstrap.com)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
* [Azure Microsoft SQL Server](https://azure.microsoft.com/en-us/services/sql-database/campaign)



<!-- GETTING STARTED -->
## Getting Started

To get debug a local copy, follow these simple example steps.

### Prerequisites

* [Visual Studio 2019 16.10.2](https://visualstudio.microsoft.com/downloads/) 
    * Make sure to mark the following workloads during installation:
        *  **ASP.NET and Web Development**
        *  **Azure Development**
        *  **.Net Cross Platform Development**

![image](https://user-images.githubusercontent.com/11657124/122759328-6c8f7880-d25f-11eb-91b0-8a223abd4e86.png)

![image](https://user-images.githubusercontent.com/11657124/122759402-8204a280-d25f-11eb-9112-4acbbb3aa562.png)

* [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
* [SQL Server Developer Edition](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Optional, a SQL Cloud instance can be used)
* Azure Account (If you don't have one, [Click Here](https://azure.microsoft.com/en-us/free/))(Optional, a local SQL instance can be used)

### Azure SQL Database Creation
1. This an optional step, you can just create a database called **Blogs** in your local SQL Server Dev Edition, after having it installer in the previous step.
2. Go to [Create Azure SQL Database](https://portal.azure.com/#create/Microsoft.SQLDatabase) to start the database creation
![image](https://user-images.githubusercontent.com/11657124/122762450-f0972f80-d262-11eb-9bf4-62627a22dbef.png)
3. Under the **Server** option, click **Create New** and typed the information required. Be sure to save the **login** and **password**, since you will use those later on.
![image](https://user-images.githubusercontent.com/11657124/122763903-7cf62200-d264-11eb-8c18-ce55f5251378.png)
4. Once that's done , review and create the database
![image](https://user-images.githubusercontent.com/11657124/122764123-c34b8100-d264-11eb-8e69-e29b920a9e2e.png)
![image](https://user-images.githubusercontent.com/11657124/122764175-cf374300-d264-11eb-8272-f204841fda7a.png)
5. When deployment is finished, click on **Go to resource** and you will see your new Sql database
![image](https://user-images.githubusercontent.com/11657124/122764718-600e1e80-d265-11eb-9381-490d77c17448.png)
![image](https://user-images.githubusercontent.com/11657124/122764947-9ea3d900-d265-11eb-82b0-b36664467279.png)
6. Click on **Show database connection strings**
![image](https://user-images.githubusercontent.com/11657124/122765018-ad8a8b80-d265-11eb-95ed-2acc1ce18583.png)
7. Copy the connection string from the ADO.NET Tab and add it your password and user. This will be the connection string that you will use in the App.
8. Now go back to overview and click on **Set Server Firewall**
![image](https://user-images.githubusercontent.com/11657124/122765463-2558b600-d266-11eb-825c-7106c654bf3e.png)
9. This step is important , otherwise your application won't be able to communicate the database. Mark as yes the option "**Allow Azure services and resources to access this server**" and click on **Add Client API** to a add new IP rule name that includes your current public API (so that so can connect from your local computer). Then click on Save

![image](https://user-images.githubusercontent.com/11657124/122765744-6cdf4200-d266-11eb-8d69-8632631d0398.png)
10. That's it. You are ready to go.



<!-- USAGE EXAMPLES -->
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Best README Template](https://github.com/othneildrew/Best-README-Template)
