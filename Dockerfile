FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY RezervacniSystem/RezervacniSystem.csproj RezervacniSystem/

RUN dotnet restore RezervacniSystem/RezervacniSystem.csproj

COPY . .

WORKDIR /src/RezervacniSystem
RUN dotnet build -c Release -o /app/build

FROM build AS publish
WORKDIR /src/RezervacniSystem
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RezervacniSystem.dll"]
