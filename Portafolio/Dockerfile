# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia solo el csproj para cachear restore
COPY *.csproj ./
RUN dotnet restore

# Copia todo el código
COPY . ./

# Publica la app con Release y output a /app/out
RUN dotnet publish -c Release -o out

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia los archivos publicados desde la etapa build
COPY --from=build /app/out ./

# Comando para ejecutar la app
ENTRYPOINT ["dotnet", "Portafolio.dll"]
