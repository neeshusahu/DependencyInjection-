# DependencyInjection-
 A demo MVC web application using n-tier architecture demonstrating dependency injection with Controllerfactory method.Constructor dependency is implemented for different techinque for data operation in the given application such as Azure Sql Database with RedisCache,WCF service and SQL Database

The solution consists of following
- DependencyInjection
   -  Web application
-  DependencyInjection.Data
   -  Database project with entities and collection of different repositories such as
      - SQLRepository-implementation of data operation with Entity framework
      - ServiceRepository-implementation of data operation with WCF service
       - AzureRepository-implementation of data operation with Azure SQL database and Redis Cache
 -  DependencyInjection.Domain
    -  Common interface  between application and database project
 - DependencyInjection.Service
   - WCF Service
 -  DependencyInjection.ResourceGroup
    -  ARM template for creation of Azure SQL Database and RedisCache
   
 
# GettingStarted    

Following should be in place for the solution build
- Visual studio 2015(or Visual studio 2017)
- Azure SDK
    


