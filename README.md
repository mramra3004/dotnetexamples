# Ứng dụng mẫu .NET 6

- Cài đặt portainer (quản lý docker)
```shell
version: '2'
services:
  portainer:
    image: portainer/portainer
    command: -H unix:///var/run/docker.sock
    restart: always
    ports:
      - 9000:9000
      - 8000:8000
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - portainer_data:/data
volumes:
  portainer_data:
```

```shell
docker volume create --name=blog-data
docker network create netcore-example
docker-compose up -d
```