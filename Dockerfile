# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file
COPY RezervacniSystem.sln ./

# Copy project file
COPY RezervacniSystem/RezervacniSystem.csproj ./RezervacniSystem/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the source code
COPY RezervacniSystem ./RezervacniSystem

# Publish
RUN dotnet publish RezervacniSystem/RezervacniSystem.csproj -c Release -o /app/publish


# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "RezervacniSystem.dll"]
