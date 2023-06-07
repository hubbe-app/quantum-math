# Quantum.Math.Api

Welcome to Quantum.Math.Api! This project is a .NET Core API that provides mathematical operations..

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 7.0 or higher) must be installed.

## Getting Started

To get started with Quantum.Math.Api, follow the instructions below.

### Running Tests

1. Open a command prompt or terminal.
2. Navigate to the project's root directory.
3. Run the following command to execute the unit tests:

```sh
dotnet test
```

This command will compile and run the unit tests, providing you with the test results.

### Running in Development

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

### API Endpoints

The following API endpoint is available:

- `GET /api/sum?x={double}&y={double}` - Calculates the sum of two doubles. Replace `{double}` with the desired double values.
- `GET /api/division?x={double}&y={double}` - Calculates the division of two doubles. Replace `{double}` with the desired double values.

## Contributing

Contributions are welcome! If you'd like to contribute to Quantum.Math.Api, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push your changes to your forked repository.
5. Submit a pull request to the main repository.