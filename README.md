# ConceptaApi

Welcome to Concepta .NET Api test project

## Documentation

1) Open `docs` folder to learn more about the API endpoints and the request's formats.

## Testing

1) Submit a POST request to `https://concepta-api.herokuapp.com/api/Tickets`, considering the following properties:
   
   a) Header:
        
        * Content-Type  application/json
 
    
    b) Body (request payload):
        
        * Raw json example:
        
           {
                "Language": "ENG",
                "Currency": "USD",
                "Destination": "MCO",
                "DateFrom": "11/26/2018",
                "DateTO": "11/29/2018",
                "Occupancy": {
                    "AdultCount": "1",
                    "ChildCount": "1",
                    "ChildAges": ["10"]
                }
           }

2) Alternatively you can load and run the Postman collection:

    `ConceptaApi.postman_collection.json`

## Running the server

1) You can launch the app from the Terminal:


    > C:\Program Files\dotnet\dotnet build C:\ConceptaAPI\ConceptaAPI.csproj
    
    > C:\Program Files\dotnet\dotnet C:\ConceptaAPI\bin\Debug\netcoreapp2.0\ConceptaAPI.dll
   
  
## License

2018 - By Lorena Lira
