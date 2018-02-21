# conceptaTest

Welcome to Concepta .NET project!

## Documentation

1) Open `docs` folder to learn more about the API endpoints and the request's formats.

## Testing

1) Submit a POST request to `https://concepta-node-js.herokuapp.com/v1/tickets`, considering the following properties:

    a) Header:
        - Content-Type  application/json
        - Authorization Bearer <token>
            - Example: Bearer zb2Xa_9rUnk8YEXR7EZNwfPLs6kyVUZt9787zkSlYOa2H4LHHXbjj9tgImYYul614SqZ-MSfX-E6H2PRBfKny0--PSVEe-yFWwvV4qkgO9xXLnQ_LA8M_b_ZGaGz3Iz8ggrnsyvKrJi2m11MP3qoC8zsbLuTqOo2N59snmbn_4igrNDAKaH9KqMC8puLNiXJX6gzp7p1xvNcrV5qZgiD0BV-pzcKOnnmNsM9wz2QBE1ubypscFrEwLCaA3gU-0xwC7NSz2JXCEXb5_VyEv_WYu9wG15BC1riN78wo8f9MCUaRJ-X0Cv1l9BWO2H71g6akOsuy8nujB-eevQD2QfTiWfSZPlH-ZKITg9pstysK4CVOeFRCAZeajOs8dKagP9GOtD7DsMtQS7oMjtED7jHO59lKHG6S2WmuIjEwu6UAnxyn7dFcvgZu_HPOQzz26kQly-nIbDSWC3Fdp2t4BwZoQNXM06QkiEiUiMNclW-6cDTBIzN29HctdnEU6qTuNfjLUmwcZbDQ9QSM5BhxmHFEQ
    
    b) Body:
        - Raw json
            - Example: {
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
                        } 

2) Alternatively you can load and run the Postman collection:

    $ conceptatest.postman_collection.json

## License

2018 - Lorena Lira
