# Usar Nginx para servir o site
FROM nginx:alpine

# Apagar config default e adicionar o site
COPY . /usr/share/nginx/html

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
