# Create new migration
dotnet ef migrations add migration$1 -s GoalDigger/GoalDigger.API/GoalDigger.API.csproj -c GoalDiggerDBContext -p GoalDigger/GoalDigger.API/GoalDigger.API.csproj
# Apply migration to the database
dotnet ef database update migration$1 -s GoalDigger/GoalDigger.API/GoalDigger.API.csproj -c GoalDiggerDBContext -p GoalDigger/GoalDigger.API/GoalDigger.API.csproj

