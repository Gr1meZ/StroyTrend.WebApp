FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["StroyTrend.WebApp/StroyTrend.WebApp.csproj", "StroyTrend.WebApp/"]
COPY ["StroyTrend.Application/StroyTrend.Application.csproj", "StroyTrend.Application/"]
COPY ["StroyTrend.Domain/StroyTrend.Domain.csproj", "StroyTrend.Domain/"]
RUN dotnet restore "StroyTrend.WebApp/StroyTrend.WebApp.csproj"
COPY . .
WORKDIR "/src/StroyTrend.WebApp"
RUN dotnet build "StroyTrend.WebApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "StroyTrend.WebApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StroyTrend.WebApp.dll"]
