# Containerized .Net Core 8 API with Postgres DB
![](https://img.shields.io/github/stars/Jorgemdss/DemoApiPostgres)
![](https://img.shields.io/github/watchers/Jorgemdss/DemoApiPostgres)
![](https://img.shields.io/github/forks/Jorgemdss/DemoApiPostgres)
![](https://img.shields.io/github/issues/Jorgemdss/DemoApiPostgres)

Intro
=============
This is a project that can be used as startup if you're building an API with a PostgresDB.
Can be used whenever a quick "blank" startup project is needed.
Currently using .Net 8 and Entity framework.

This initial version simply has 2 Models, being User and Role, with a many to many navigation between them. And the context is using Lazy loading.



### Planned features

- [ ] Authentication (Using new  [Identity Auth](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-api-authorization?view=aspnetcore-8.0 "Identity Auth"))
- [ ] Authorization
- [ ] Create repositories
- [ ] Create services
- [ ] Add more models

---

Running the docker container
=============
### Run API and DB

`docker compose up --build`
This command runs both the API and DB images inside a docker container.

### Stoping API and DB
`docker compose down`
This command stops the docker container.

### Stoping and removing volumes
`docker compose down -v`
This command stops and removes the docker container and volumes. ***Attention, this command will delete your DB data!***

### Run API or DB individually
`docker compose up app_db`
This command launches the DB (add the ***--build*** argument if you need to apply migrations)

`docker compose up demo-app`
This command launches the api.

---
Running the api locally (and debugging)
=============
For a faster workflow, I recomend running the API locally while the DB is running on docker.

You can achieve this by running
`docker compose up app_db` and then  `dotnet run`. This way you can save your API code changes and test the results without having to run and build the api docker image.

### Debugging
For debugging all you need to do is to click on the Run and Debug VsCode extention and select the DemoApp, place your breakpoints and that's it.
