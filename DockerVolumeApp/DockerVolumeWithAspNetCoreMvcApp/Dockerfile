FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish "DockerVolumeWithAspNetCoreMvcApp.csproj" -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS="http://*:4500"
ENTRYPOINT ["dotnet","DockerVolumeWithAspNetCoreMvcApp.dll"]
