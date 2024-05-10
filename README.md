Hello Mac users,
aren't you tired of Microsoft's lack of proper documentation for Mac users and how horrible the DX is?

I know I am. Here you can have my ready to go template.  


The connection string is included in appsettings.json on purpose. 

This is the docker Image I'm running on Docker
https://hub.docker.com/_/microsoft-azure-sql-edge

install it, run it. 

mine is running at 
Port 1433:1433 

My connection string is set to 
Server=tcp:127.0.0.1,1433;

If you need to change the name of the database created, edit this
Database=NetDemo
---
The username and password from the connection string refer to the Docker image
User=sa;Password=Admin@123
---
This setup is not production-ready. You can use it to start a new project, test your ideas and what not. 
When your project is ready to be deployed, you will need to adjust it accordingly.
