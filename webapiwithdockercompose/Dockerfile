# See https://aka.ms/customizecontainer to learn how to customize your debug container
# and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj first
COPY ["webapiwithdockercompose/webapiwithdockercompose.csproj", "webapiwithdockercompose/"]

# Restore dependencies
RUN dotnet restore "webapiwithdockercompose/webapiwithdockercompose.csproj"

# Copy all files
COPY . .

# Move into project folder
WORKDIR /src/webapiwithdockercompose

# Build project
RUN dotnet build "webapiwithdockercompose.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "webapiwithdockercompose.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "webapiwithdockercompose.dll"]