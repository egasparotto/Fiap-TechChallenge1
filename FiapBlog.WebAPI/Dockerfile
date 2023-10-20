#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FiapBlog.WebAPI/FiapBlog.WebAPI.csproj", "FiapBlog.WebAPI/"]
COPY ["FiapBlog.Data/FiapBlog.Data.csproj", "FiapBlog.Data/"]
COPY ["FiapBlog.Domain/FiapBlog.Domain.csproj", "FiapBlog.Domain/"]
RUN dotnet restore "FiapBlog.WebAPI/FiapBlog.WebAPI.csproj"
COPY . .
WORKDIR "/src/FiapBlog.WebAPI"
RUN dotnet build "FiapBlog.WebAPI.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "FiapBlog.WebAPI.csproj" -c Debug -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FiapBlog.WebAPI.dll"]