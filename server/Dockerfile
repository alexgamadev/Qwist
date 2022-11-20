# Get .NET Core runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime-env
WORKDIR /app
EXPOSE 443
EXPOSE 80

# Get .NET SDK and restore projects
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /build
COPY Qwist.sln ./Qwist.sln
COPY src/Checklists.API/Checklists.API.csproj ./src/Checklists.API/Checklists.API.csproj
COPY src/Checklists.Tests/Checklists.Tests.csproj ./src/Checklists.Tests/Checklists.Tests.csproj
# Use local nuget packages for now because bad internet
RUN dotnet restore --source C:\Users\alex.gama\.nuget\packages\ --use-current-runtime --verbosity diagnostic

# Test and publish project
FROM build-env AS publish
COPY . .
RUN dotnet test ./src/Checklists.Tests/Checklists.Tests.csproj -c Development
RUN dotnet publish ./src/Checklists.API/Checklists.API.csproj -c Development -o /app/publish --self-contained false --no-restore --use-current-runtime 

# Create final image using runtime (smaller) and run
FROM runtime-env AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Checklists.API.dll"]