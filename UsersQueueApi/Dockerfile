#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DOTNET_ENVIRONMENT="Development"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UsersQueueApi/WebUI/WebUI.csproj", "WebUI/"] 
COPY ["UsersQueueApi/Application/Application.csproj" , "Application/"]
COPY ["UsersQueueApi/Domain/Domain.csproj", "Domain/"]
COPY ["UsersQueueApi/Infrastructure/Infrastructure.csproj" , "Infrastructure/"]
COPY ["UsersQueueApi/Infrastructure/Proto", "Infrastructure/Proto/"]
RUN dotnet restore "WebUI/WebUI.csproj"
COPY . .
WORKDIR "/src/UsersQueueApi/WebUI"
RUN dotnet build "WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UsersQueueApi.WebUI.dll"]
