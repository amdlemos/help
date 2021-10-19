# DOCKER

## basic commands
```bash
# build image
$ docker build -t image name .

# run image
$ docker run -dp 3000:3000 image_name:tag 

# remove one or more images
$ docker image rm [OPTIONS] IMAGE [IMAGE...]

# remove all stopped containers 
$ docker container prune

# list all containers
$ docker ps -a

# watch logs
$ docker logs -f <container-id> 
```

