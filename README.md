# Programacion distribuida 2

## :computer: Tecnologías

- .NET v6.0
- MediatR v10.0.1
- FluentValidation v10.3.6
- Swashbuckle v6.2.3
- Protobuf  v3.21.5
- Grpc v2.52.0
- Serilog v2.12.0

## Requisitos

#### Docker

Abrir la consola y ejecutar el siguiente comando:

``` 
docker -v
```

La salida debe ser algo similar a "Docker version 20.10.14", donde indica la version de docker instalada, en caso contrario se debe instalar docker. En los siguientes links pueden encontrar un tutarial de la documentacion oficial como guia.
- [Linux](https://docs.docker.com/desktop/install/linux-install/)
- [Windows](https://docs.docker.com/desktop/install/windows-install/)

### GitHub

Abrir la consola y ejecutar el siguiente comando:

``` 
git --version
```

La salida debe ser similar a "git version 2.35.1.windows.2", indicando la version de git instalada, en caso de no tener instalado git, seguir el tutorial que corresponda segun tu Sistema operativo.

- [Linux](https://git-scm.com/download/linux)
- [Windows](https://git-scm.com/download/win)

## :rocket: Ejecución del proyecto

Clonar proyecto ejecutando el siguiente comando en la consola:

``` 
git clone https://github.com/AilenGomez/Programacion-distribuida-2
```


### :zap: Ejecución



- Una vez instalado docker, abrir terminal en la carpeta donde se clono el repositorio /Programacion-distribuida-2 y ejecutar el siguiente comando:

``` 
docker compose up -d 
```

- Abrir en un browser la siguiente URL: 

http://localhost:8070/swagger/index.html

## :alembic:Test 

### Swagger

Donde se abrira un swagger UI, con los dos enpoints de la api rest.

<img width="719" alt="image" src="https://user-images.githubusercontent.com/32937466/234098543-f240dad8-ccaa-4ffe-bb95-c7e3a4d4118b.png">


Haciendo click en "Try it out"

<img width="718" alt="image" src="https://user-images.githubusercontent.com/32937466/234092402-75e8dd51-4be2-43e7-afb3-ca5f41045e0a.png">

Luego en Execute:

<img width="715" alt="image" src="https://user-images.githubusercontent.com/32937466/234092632-cdd40ce5-2a0c-4efc-810e-27b680682e0a.png">

Lo mismo para el otro endpoint

<img width="716" alt="image" src="https://user-images.githubusercontent.com/32937466/234098976-e6439841-fd1e-4150-afb5-bc54bbc949ce.png">


### Postman

Tambien se puede probar importando la collection de postman UsersQueueApi.postman_collection.json.

En la opcion "Import"

<img width="152" alt="image" src="https://user-images.githubusercontent.com/32937466/234100781-130af463-93f3-46c2-b7c1-a299d601e940.png">

Seleccionando el archivo .json desde el explorador de archivos

<img width="340" alt="image" src="https://user-images.githubusercontent.com/32937466/234100830-92615f98-d20f-4258-9cea-2a2de656846a.png">



<img width="742" alt="image" src="https://user-images.githubusercontent.com/32937466/234101423-fee424d2-3a6d-486a-b196-98f7e6c7ff0e.png">

<img width="743" alt="image" src="https://user-images.githubusercontent.com/32937466/234100325-07b53f5c-f838-494d-93fb-d33e25968e65.png">









