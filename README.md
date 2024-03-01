# StroyTrend Test Application

## Features

- Docker support
- CQRS Pattern
- A bit of clean architecture
- Used: c#, ASP NET MVC, HTML, Bootstrap, JQuery, Javascript

# How to run in docker
- First, get docker image from DockerHub:

```sh
docker pull gr1mez/stroytrend       
```

- You can use my docker-compose file and use it to run container:

```sh
docker-compose up -d 
```

-If you want to build your own image use this command:
```sh
docker build -f .\StroyTrend.WebApp\Dockerfile -t imageName .
```

# Screenshots
  ![Screenshot](https://github.com/Gr1meZ/StroyTrend.WebApp/assets/24815286/4815f0fd-84f4-4a23-8376-a521d004f465)

  
  ![Screenshot](https://github.com/Gr1meZ/StroyTrend.WebApp/assets/24815286/edad54b7-7c23-48a3-b721-9b6b2bac9fdd)




