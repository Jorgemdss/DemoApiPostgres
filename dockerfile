# Ge the .net sdk image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# create directory to hold our built source code
WORKDIR /app
EXPOSE 80
EXPOSE 443

# copy everything from csproj
COPY *.csproj ./
COPY *.sln .

# restore for any missing packages
RUN dotnet restore

# copy the rest of the app
COPY . ./
RUN dotnet publish -c Release -o out

COPY /Migrations /app/Migrations


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS final-env
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DemoApp.dll"]
