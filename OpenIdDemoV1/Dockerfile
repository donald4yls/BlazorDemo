#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OpenIdDemoV1/OpenIdDemoV1.csproj", "OpenIdDemoV1/"]
RUN dotnet restore "OpenIdDemoV1/OpenIdDemoV1.csproj"
COPY . .
WORKDIR "/src/OpenIdDemoV1"
RUN dotnet build "OpenIdDemoV1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenIdDemoV1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenIdDemoV1.dll"]