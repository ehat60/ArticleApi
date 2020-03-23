# ArticleApi

To run the project in docker first build an image:  
`docker build -t articleapiimage https://github.com/ehat60/ArticleApi.git`

Then run a container:  
`docker run -d -p 8080:80 --name articleapi articleapiimage`

Now you can browse the Swagger documentation at:  
http://localhost:8080