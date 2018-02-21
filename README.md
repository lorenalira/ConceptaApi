# ConceptaApi

Welcome to Concepta .NET Api test project!

## Documentation

1) Open `Docs` folder to learn more about the API endpoints and the request's formats.

## Testing

1) Submit a POST request to `http://localhost:5000/api/Tickets`, considering the following properties:
   
   a) Header:
        
        * Content-Type  application/json
 
    
    b) Body (request payload):
        
        * Raw json example: 
        ```{
                "Language": "ENG",
                "Currency": "USD",
                "Destination": "MCO",
                "DateFrom": "11/26/2016",
                "DateTO": "11/29/2016",
                "Occupancy": {
                    "AdultCount": "1",
                    "ChildCount": "1",
                    "ChildAges": ["10"]
                }
           }```

2) Alternatively you can load and run the Postman collection:

    `ConceptaApi.postman_collection.json`

## License

2018 - Lorena Lira
