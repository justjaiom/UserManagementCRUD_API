# User Management API
=======================

## Overview
------------

This is a User Management API built using ASP.NET Core and C#. The API provides a set of endpoints for managing users, including creating, reading, updating, and deleting users. The API also includes middleware for logging, error handling, and authentication.

### Features

* Create, read, update, and delete users
* Logging middleware to log incoming requests and outgoing responses
* Error handling middleware to catch unhandled exceptions and return consistent error responses
* Authentication middleware to validate tokens from incoming requests and allow access only to users with valid tokens

### API Endpoints

#### Users

* `GET /users`: Returns a list of all users
* `GET /users/{id}`: Returns a single user by ID
* `POST /users`: Creates a new user
* `PUT /users/{id}`: Updates a single user by ID
* `DELETE /users/{id}`: Deletes a single user by ID

### Usage

1. Clone the repository to your local machine
2. Open the project in Visual Studio
3. Build and run the project
4. Use a tool like Postman to send requests to the API endpoints

### Authentication

To authenticate with the API, you need to include a valid token in the `Authorization` header of your request. The token should be in the format `Bearer <token>`.

### Logging

The API logs all incoming requests and outgoing responses using the logging middleware. You can view the logs in the console output.

### Error Handling

The API catches unhandled exceptions and returns consistent error responses using the error handling middleware.

### Certificate

This project was completed as part of the [Coursera - ASP.NET Core API Development](https://www.coursera.org/learn/back-end-development-with-dotnet) course. You can view my certificate [here](https://www.coursera.org/user/69b8f74521178e1b3c2af0a530fdaad4).

### License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

### Acknowledgments

I would like to thank Coursera and the instructors of the ASP.NET Core API Development course for providing the opportunity to learn and complete this project.