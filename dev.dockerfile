FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /source

COPY . ./

RUN dotnet restore "./Quantum.Math.Api/Quantum.Math.Api.csproj"
RUN dotnet test "./Quantum.Math.Api.Tests/Quantum.Math.Api.Tests.csproj"
RUN dotnet publish "./Quantum.Math.Api/Quantum.Math.Api.csproj" -c debug -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80

ENTRYPOINT ["dotnet", "Quantum.Math.Api.dll"]