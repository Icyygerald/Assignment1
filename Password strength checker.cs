dotnet new sln -n PasswordStrengthSolution
dotnet new classlib -n PasswordChecker
dotnet new xunit -n PasswordChecker.Tests
dotnet sln PasswordStrengthSolution.sln add PasswordChecker/PasswordChecker.csproj
dotnet sln PasswordStrengthSolution.sln add PasswordChecker.Tests/PasswordChecker.Tests.csproj
dotnet add PasswordChecker.Tests/PasswordChecker.Tests.csproj reference PasswordChecker/PasswordChecker.csproj
