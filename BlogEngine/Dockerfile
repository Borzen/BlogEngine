FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53579
EXPOSE 44328

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY BlogEngine/BlogEngine.csproj BlogEngine/
RUN dotnet restore BlogEngine/BlogEngine.csproj
COPY . .
WORKDIR /src/BlogEngine
RUN dotnet build BlogEngine.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish BlogEngine.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BlogEngine.dll"]
