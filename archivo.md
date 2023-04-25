
#  ¿Cómo resolvió la conexión entre los contenedores? ¿Cómo se ven entre sí ambos contenedores? ¿Utilizó algún modo de restricción?

La conexion entre contenedores la administro a traves del docker compose con el atributo network. Configurando una red interna que contiene los dos contenedores. 
Creando una subred llamada programacion-distribuida-2_red_interna 

# Comparar REST sobre HTTP con gRPC y/o Apache Avro. Definir en qué contexto una tecnología es conveniente por sobre la otra o si no existen diferencias de uso.

REST, gRPC y Apache Avro son tres tecnologías diferentes que se utilizan para la comunicación entre aplicaciones distribuidas. A continuación, 
se presenta una comparación entre REST y gRPC/Apache Avro:

## REST sobre HTTP:

### REST (Representational State Transfer) 
 - Es una arquitectura de software que se utiliza para construir servicios web.
 - Se basa en el protocolo HTTP para la comunicación entre el cliente y el servidor.
 - Utiliza los verbos HTTP (GET, POST, PUT, DELETE) para realizar operaciones CRUD (crear, leer, actualizar y eliminar) en los recursos del servidor.
 - Es una tecnología muy popular debido a su facilidad de uso y su amplia adopción en la industria.
 - Es compatible con la mayoría de los lenguajes de programación y plataformas.

### gRPC:

- Es un sistema de comunicación de alta velocidad y de baja latencia que se utiliza para construir aplicaciones distribuidas.
- Se basa en el protocolo HTTP/2 para la comunicación entre el cliente y el servidor.
- Utiliza la serialización de mensajes para enviar datos entre el cliente y el servidor.
- Utiliza el lenguaje de definición de servicios (protobuf) para definir los servicios y los mensajes que se envían entre ellos.
- Es compatible con varios lenguajes de programación, incluyendo C++, Java, Python, Go, Ruby y otros.
- 
El gRPC es recomendado para su uso en microservicios o para integraciones de APIs internas gracias a que ofrece una mayor escalabilidad y una optimizada respuesta por 
su baja latencia en el envío de mensajes por el formato binario de HTTP/2.

Por otro lado, REST es recomendado para integraciones con clientes y APIs públicas, muy fácil de usar y con unas restricciones de protocolo sencillas de implementar,
además JSON es un lenguaje fácilmente interpretable por el humano. También posee una gran comunidad detrás que alimenta la documentación y las buenas prácticas del método de comunicación. 
Como desventaja hay que recalcar que por su formato es más pesado que gRPC (pero para los casos de uso donde es recomendado no es un gran factor a tener en cuenta).


En resumen, REST es una arquitectura de software que se basa en HTTP para la comunicación entre el cliente y el servidor, mientras que gRPC y 
Apache Avro son sistemas de comunicación de alta velocidad que utilizan protocolos diferentes y técnicas de serialización de datos para enviar datos entre aplicaciones
distribuidas. La elección entre estas tecnologías dependerá de cada proyecto, tienen necesidades y requisitos diferentes por lo que la arquitectura API elegida debería depender del uso que vaya a tener.

<img width="300" alt="image" src="https://user-images.githubusercontent.com/32937466/234299761-3f6aa5bd-1052-49ac-b7be-0fbe407a0154.png">
