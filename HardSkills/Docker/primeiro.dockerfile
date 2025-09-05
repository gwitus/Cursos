# Imagem base
FROM ubuntu:22.04

# Autor
LABEL maintainer="seuemail@dominio.com"

# Instalar pacotes
RUN apt-get update && apt-get install -y curl

# Copiar arquivos
COPY . /app

# Definir diretório de trabalho
WORKDIR /app

# Comando padrão ao iniciar o container
CMD ["echo", "Olá, Docker!", "npm", "start"]

# Define volume
VOLUME /var/lib/postgresql/data

# Var's de Build
ARG NODE_VERSION=18
FROM node:$NODE_VERSION

#Var's de ambiente
ENV ASPNETCORE_ENVIRONMENT=Development

#Porta para o container escutar
EXPOSE 5000



## ---- MULTI STAGE

# Stage 1: build
FROM node:18-alpine AS build
WORKDIR /app
COPY package*.json ./
RUN npm ci
COPY . .
RUN npm run build

# Stage 2: runtime Nginx
FROM nginx:alpine
COPY --from=build /app/build /usr/share/nginx/html
EXPOSE 80


#### EXEMPLO COM .NET ####
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MinhaApi.dll"]
EXPOSE 5000


## Comandos úteis

# Buildar a imagem
docker build -t minhaorg/app:1.0 .

# Rodar o container
docker run -d -p 5000:5000 minhaorg/app:1.0

# Inspecionar a imagem
docker image inspect minhaorg/app:1.0

# Ver logs do container
docker logs <container_id>
