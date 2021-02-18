#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY Api/DotnetCore.Api/DotnetCore.Api.csproj Api/DotnetCore.Api/
COPY Api/DotnetCore.Common/DotnetCore.Common.csproj Api/DotnetCore.Common/
COPY Api/DotnetCore.Core/DotnetCore.Core.csproj Api/DotnetCore.Core/
COPY Api/DotnetCore.Service/DotnetCore.Service.csproj Api/DotnetCore.Service/
COPY Api/DotnetCore.Repository/DotnetCore.Repository.csproj Api/DotnetCore.Repository/
COPY Api/DotnetCore.Data/DotnetCore.Data.csproj Api/DotnetCore.Data/
RUN dotnet restore "Api/DotnetCore.Api/DotnetCore.Api.csproj"
COPY . .
WORKDIR "/src/Api/DotnetCore.Api"
RUN dotnet build "DotnetCore.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetCore.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetCore.Api.dll"]
