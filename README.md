# Hotel-App
 
## Overview
This API serves hotel data stored in a JSON file. It provides endpoints to fetch a list of hotels or a single hotel's details by ID.

## Features
- **GET `/api/hotels`**: Fetch all hotels.
- **GET `/api/hotels/{id}`**: Fetch hotel details by ID.
- Error handling with appropriate HTTP status codes.

## Requirements
- .NET 8.0 or later
- A terminal (e.g., Command Prompt or Bash)

## Setup

### 1. Clone the Repository
```bash
git clone https://github.com/slezyradosti/Hotel-App.git
cd hotel-api
```

### 2. Install Dependencies
```bash
dotnet restore
```

### 3. Run the Application
```bash
dotnet run
```

### 4. Test the API
- Get All Hotels: GET [http://localhost:7140/hotels](https://localhost:7140/hotels)
- Get Hotel by ID: GET [http://localhost:7140/hotels/{id}](https://localhost:7140/hotels/1) 

### 5. Error Handling
- 404 Not Found: Hotel ID not found
- 400 Bad Request: Invalid input
- 500 Internal Server Error: Server Error
