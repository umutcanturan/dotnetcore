# dotnetcore

# Dockerize
in solution directory, run "docker build -t dotnetcore -f Api/DotnetCore.Api/Dockerfile ." command to build image.

docker run -d -p 8087:5000 --name dotnetcore dotnetcore
