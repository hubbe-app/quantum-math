# Quantum.Math.Api

Welcome to Quantum.Math.Api! This project is a .NET Core API that provides mathematical operations..

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 7.0 or higher) or [Docker](https://www.docker.com/products/docker-desktop/) must be installed.


## Getting Started

To get started with Quantum.Math.Api, follow the instructions below.

### Running Tests - .NET Core SDK

1. Open a command prompt or terminal.
2. Navigate to the project's root directory.
3. Run the following command to execute the unit tests:

```sh
dotnet test
```

This command will compile and run the unit tests, providing you with the test results.

### Running in Development - .NET Core SDK

1. Open a command prompt or terminal.
2. Navigate to the project's root directory.
3. Run the following command to restore the project dependencies:

```sh
dotnet restore
```

4. Run the following command to build and run the project:

```sh
dotnet run --project Quantum.Math.Api
```

This command will build and start the API project. You should see output indicating that the API is running and listening for requests.

### Running in Development - Docker

1. Open a command prompt or terminal.
2. Navigate to the project's root directory.
3. Run the following commands to test (if any test fails the docker image build will stop), build and run development image locally:

```sh
docker build -f dev.dockerfile -t dev-qm .
docker run --rm -p 80:80 dev-qm
```

### API Endpoints

The following API endpoint is available:

- `GET /api/sum?x={double}&y={double}` - Calculates the sum of two doubles. Replace `{double}` with the desired double values.
- `GET /api/division?x={double}&y={double}` - Calculates the division of two doubles. Replace `{double}` with the desired double values.

- [https://qm-api-hubbe.azurewebsites.net/](https://qm-api-hubbe.azurewebsites.net/) - Healthcheck endpoint.


## CI/CD Configuration

The tool used for CI setup was GitHub, Azure DevOps, DockerHub and the hosting environment was Azure App Service, the configuration is done through azure-pipelines.yml and it works as follows:

The tool connects to the repository on GitHub and it triggers after any modifications in the main branch. After that, the build and unit tests in the application take place, in case of error, the process stops and the team is notified by email. Then if there were no errors to be corrected the build and push process of the docker image is performed and the team is notified of its conclusion.

- [DockerHub repository](https://hub.docker.com/repository/docker/caioerhart/qm-api/general)

Prerequisites:

1. Setup GitHub and DockerHub Service connections.
2. Define an agent from Azure DevOps agent pool.

Build succeeded example:
![image](https://github.com/caioerhart/quantum-math/assets/124104601/4eca3c66-f2c9-4f46-8670-6cbebb7ffc1f)

When an new image is pushed to DockerHub, a Webhook triggers the automated CD for hosting environment.
![image](https://github.com/caioerhart/quantum-math/assets/124104601/e3f93146-a406-4bfe-ac62-eba885db51a3)

Azure App Service supports application deployment from docker images and it is setup on Deployment Center:
![image](https://github.com/caioerhart/quantum-math/assets/124104601/552e089f-e172-465b-8e8a-bea0ef1b59c1)


## Contributing

Contributions are welcome! If you'd like to contribute to Quantum.Math.Api, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push your changes to your forked repository.
5. Submit a pull request to the main repository.
