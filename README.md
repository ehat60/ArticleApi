# ArticleApi

docker build -t articleapiimage .
docker run -d -p 8080:80 --name articleapi articleapiimage