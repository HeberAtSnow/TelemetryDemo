#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["JokeSvc/JokeSvc.csproj", "JokeSvc/"]
COPY ["SharedLibrary/SharedLibrary.csproj", "SharedLibrary/"]
RUN dotnet restore "JokeSvc/JokeSvc.csproj"
COPY . .
WORKDIR "/src/JokeSvc"
RUN dotnet build "JokeSvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JokeSvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JokeSvc.dll"]
