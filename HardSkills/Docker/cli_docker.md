docker ps                # Lista contêineres em execução
docker ps -a             # Lista todos os contêineres (ativos, parados, criados)
docker ps -q             # Mostra apenas IDs dos contêineres ativos
docker ps -aq            # Mostra apenas IDs de todos os contêineres
docker ps -a --filter "status=exited"   # Filtrar por status específico (exemplo: parados)


docker rm <ID-ou-nome>              # Remove um contêiner
docker rm <ID1> <ID2> <ID3>         # Remove vários contêineres
docker container prune              # Remove todos os contêineres parados
docker rm -f <ID-ou-nome>           # Força remoção mesmo se estiver rodando


docker start <ID-ou-nome>           # Inicia um contêiner parado
docker stop <ID-ou-nome>            # Para um contêiner em execução
docker restart <ID-ou-nome>         # Reinicia um contêiner
docker pause <ID-ou-nome>           # Pausa um contêiner
docker unpause <ID-ou-nome>         # Despausa um contêiner

docker inspect <ID-ou-nome>         # Mostra detalhes do contêiner
docker inspect -f '{{range.NetworkSettings.Networks}}{{.IPAddress}}{{end}}' <ID-ou-nome>  # Mostra IP

docker logs <ID-ou-nome>            # Exibe logs do contêiner
docker logs -f <ID-ou-nome>         # Segue logs em tempo real
docker top <ID-ou-nome>             # Mostra processos do contêiner

docker stats                        # Mostra uso de CPU, memória e rede em tempo real

docker exec -it <ID-ou-nome> /bin/bash   # Acessa o shell do contêiner
docker exec -it <ID-ou-nome> /bin/sh     # Alternativa se não tiver bash
docker exec <ID-ou-nome> <comando>       # Executa comando dentro do contêiner

docker images                            # Lista imagens
docker rmi <imagem>                      # Remove uma imagem
docker rmi $(docker images -q)          # Remove todas as imagens
docker image prune                       # Remove imagens não utilizadas

docker volume ls                         # Lista volumes
docker volume rm <volume>                # Remove volume específico
docker volume prune                      # Remove volumes não utilizados

docker system prune                      # Remove contêineres parados, redes, volumes e cache
docker system prune -a                   # Remove TUDO que não está em uso (inclui imagens)

docker --version                         # Mostra versão do Docker
docker info                              # Exibe informações do sistema Docker

docker network ls                        # Lista redes
docker network inspect <rede>            # Mostra detalhes da rede
docker network rm <rede>                 # Remove rede

docker build -t nome-imagem .            # Cria imagem a partir do Dockerfile
docker run nome-imagem                   # Executa contêiner da imagem
docker run -it nome-imagem /bin/bash     # Executa com terminal interativo
docker run -d nome-imagem                # Executa em background
docker run -p 8080:80 nome-imagem        # Mapeia porta 8080 do host para 80 do contêiner
