FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

COPY . ./

RUN dotnet restore "./Quantum.Math.Api/Quantum.Math.Api.csproj"
RUN dotnet publish "./Quantum.Math.Api/Quantum.Math.Api.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80

ENTRYPOINT ["dotnet", "Quantum.Math.Api.dll"]