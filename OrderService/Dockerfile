# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Copiar el csproj (ruta correcta)
COPY OrderService/OrderService.csproj OrderService/
RUN dotnet restore OrderService/OrderService.csproj

# Copiar el resto del código
COPY OrderService/. OrderService/
WORKDIR /src/OrderService

RUN dotnet publish -c Release -o /app/publish

# Etapa runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "OrderService.dll"]