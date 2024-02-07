
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ocpp.Api/Ocpp.Api.csproj", "Ocpp.Api/"]
COPY ["Ocpp.Database/Ocpp.Database.csproj", "Ocpp.Database/"]
COPY ["Ocpp.Interfaces/Ocpp.Interfaces.csproj", "Ocpp.Interfaces/"]
COPY ["Ocpp.OpenTelemetry/Ocpp.OpenTelemetry.csproj", "Ocpp.OpenTelemetry/"]
COPY ["Ocpp.Repository/Ocpp.Repository.csproj", "Ocpp.Repository/"]
COPY ["Ocpp.Messages/Ocpp.Messages.csproj", "Ocpp.Messages/"]
RUN dotnet restore "Ocpp.Api/Ocpp.Api.csproj"
COPY . .
WORKDIR "/src/Ocpp.Api"
RUN dotnet build "Ocpp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocpp.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ocpp.api.server.dll"]