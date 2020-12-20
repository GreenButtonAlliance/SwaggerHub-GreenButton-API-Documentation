# IO.Swagger - ASP.NET Core 2.0 Server

The ApplicationInformation resource contains information used by Data Custodians and Third Party applications to communicate with each other.  The ApplicationInformation resource is created when a Third Party Application registers with a Data Custodian.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
