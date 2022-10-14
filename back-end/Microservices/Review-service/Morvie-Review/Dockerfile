#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Microservices/Review-service/Morvie-Review/Morvie-Review.API.csproj", "Microservices/Review-service/Morvie-Review/"]
COPY ["Microservices/Review-service/Morvie-Review.Application/Morvie-Review.Application.csproj", "Microservices/Review-service/Morvie-Review.Application/"]
COPY ["Microservices/Review-service/Morvie-Review.Domain/Morvie-Review.Domain.csproj", "Microservices/Review-service/Morvie-Review.Domain/"]
COPY ["Microservices/Review-service/Morvie-Review.Infrastructure/Morvie-Review.Infrastructure.csproj", "Microservices/Review-service/Morvie-Review.Infrastructure/"]
RUN dotnet restore "Microservices/Review-service/Morvie-Review/Morvie-Review.API.csproj"
COPY . .
WORKDIR "/src/Microservices/Review-service/Morvie-Review"
RUN dotnet build "Morvie-Review.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Morvie-Review.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Morvie-Review.API.dll"]