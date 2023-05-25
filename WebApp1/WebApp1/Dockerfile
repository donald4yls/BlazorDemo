#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApp1/WebApp1/WebApp1.csproj", "WebApp1/"]
RUN dotnet restore "WebApp1/WebApp1.csproj" -r linux-musl-x64
COPY . .
WORKDIR "/src/WebApp1"
RUN dotnet build "WebApp1.csproj" -c Release -r linux-musl-x64 -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish "WebApp1.csproj" -c Release -r linux-musl-x64 -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp1.dll"]