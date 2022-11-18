# Get .NET Core runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime-env
WORKDIR /app
EXPOSE 443
EXPOSE 80

# Get .NET SDK, set dev environment and restore project
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /src
COPY *.csproj .
RUN dotnet restore --use-current-runtime

# Build/publish project
FROM build-env AS publish
COPY . .
RUN dotnet publish -c Development -o /app/publish --use-current-runtime --self-contained false --no-restore

# Create final image using runtime (smaller) and run
FROM runtime-env AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Checklists.API.dll"]