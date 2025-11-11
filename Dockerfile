# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only project file first
COPY RezervacniSystem/RezervacniSystem.csproj ./RezervacniSystem/

# Restore dependencies
RUN dotnet restore RezervacniSystem/RezervacniSystem.csproj

# Copy full source
COPY RezervacniSystem ./RezervacniSystem

# Build and publish
RUN dotnet publish RezervacniSystem/RezervacniSystem.csproj -c Release -o /app/publish


# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "RezervacniSystem.dll"]
