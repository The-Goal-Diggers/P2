FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /GoalDiggerAPI
COPY . .
COPY ["GoalDiggerAPI.csproj", "GoalDiggerAPI/"]
RUN dotnet build
RUN dotnet publish --configuration Release -o out GoalDiggerAPI.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR dist/
COPY --from=build GoalDiggerAPI/out/ ./
CMD ["dotnet", "GoalDigger.dll"]

