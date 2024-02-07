
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ocpp.Reporting/Ocpp.Reporting.csproj", "Ocpp.Reporting/"]
COPY ["Ocpp.Database/Ocpp.Database.csproj", "Ocpp.Database/"]
COPY ["Ocpp.Repository/Ocpp.Repository.csproj", "Ocpp.Repository/"]
COPY ["Ocpp.Messages/Ocpp.Messages.csproj", "Ocpp.Messages/"]
RUN dotnet restore "Ocpp.Reporting/Ocpp.Reporting.csproj"
COPY . .
WORKDIR "/src/Ocpp.Reporting"
RUN dotnet build "Ocpp.Reporting.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocpp.Reporting.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ocpp.reporting.dll"]