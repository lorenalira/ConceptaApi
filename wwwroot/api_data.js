define({ "api": [
  {
    "type": "post",
    "url": "api/Tickets",
    "title": "Get tickets information",
    "name": "GetTickets",
    "group": "Tickets",
    "examples": [
      {
        "title": "Example usage:",
        "content": "curl -H \\\"Authorization: Bearer MEStxaC7B20vYK-t78jYF5xsmp6DQ-En2Yl3e1lW8kaxrv4XBQJEd--VSdKCB2CypP-JYmJD3jMtMiCpJ8juyTStFt4348xtb4Nbm5me-rDInB_YMQH4-e7FbfZbc27-YEwxfafXKI-gJjP7mnmPP7afENExIWJ3Lq3xlmurxY4Mt36P6Yw7ocQtIbcRa8C7lcj71RAZTK8ibkvf6wWqewRmRh405XB2GilY7m0vXWdQKoqfGbft93507lNrHjpH7d-H12weS7vBhXZpY-CzmS5jJ_b3vNT_V2J872vFYnHX0h4SpjxtlOaU9Jz2Ec2nxUevbD2tFsDAUr1497cnvp9P_otpB5KwqK2vj4h5pfmzLyfZMul2ES0CnhnEEeEC5TuqnzUd7gQLeemZA6ZymEQ412lYWYx0GL5Iw_V5o-NgyCZJSIJdo3Ag5qUei18ksYx0fzDrqZqpbJ93NPZw15cJL93-w_D8LNy7M09QYBXyFHdGlVFkhDgPVNK5cdPR-QrhNCAwsyeCV6Jozrb5uQ\\\" -H \\\"Content-Type: application/json\\\" -d '{\n  \"Language\":\"ENG\",\n  \"Currency\":\"USD\",\n  \"destination\":\"MCO\",\n  \"DateFrom\":\"11/26/2018\",\n  \"DateTO\":\"11/29/2018\",\n  \"Occupancy\":{\n      \"AdultCount\":\"1\",\n          \"ChildCount\":\"1\",\n          \"ChildAges\":[\n              \"10\"\n          ]\n      }\n  }' -X POST 127.0.0.1:5000/api/Tickets",
        "type": "json"
      }
    ],
    "success": {
      "examples": [
        {
          "title": "Success-Response:",
          "content": "  HTTP/1.1 200 OK\n[\n    {\n       \"Destination\":\"MCO\",\n       \"Code\":\"WDWBASENXT\",\n       \"Classification\":\"Theme & Aquatic Parks\",\n       \"Name\":\"Disney Magic Your Way Base Ticket with NoExpiration Option\",\n       \"Description\":\"The Walt Disney World Resort is the place wherefun reigns supreme and dreams come true every day. With four Theme Parks,two Water Parks plus Downtown Disney Area - where the most amazingshopping, dining and entertainment imaginable can be found. Discover anentire world of enchantment and wonder around every corner with one ofDisney's Magic Your Way Tickets. Disney’s Magic Your Way Base Ticket offersadmission to one of the following theme parks for each day of the ticket\",\n       \"ImageThumb\":\"http://www.hotelbeds.com/giata/extras/small/ds/28917/28917_3.jpg\",\n       \"ImageFull\":\"http://www.hotelbeds.com/giata/extras/big/ds/28917/28917_3.jpg\",\n       \"AvailableModality\":[\n          {\n             \"Code\":\"0#CNX09/19\",\n             \"Name\":\"3 Days\",\n             \"Contract\":\"2015WDWEURTO\",\n             \"ServicePrice\":656.08,\n             \"OperationDateList\":[\n                {\n                   \"From\":\"11/26/2018\",\n                   \"To\":\"11/29/2018\"\n                },\n                {\n                   \"From\":\"11/27/2018\",\n                   \"To\":\"11/30/2018\"\n                }\n             ]\n          },\n          // loop\n       ]\n    },\n    // loop\n ]",
          "type": "json"
        }
      ]
    },
    "version": "1.0.0",
    "filename": "src/ConceptaApi/Controllers/TicketsController.cs",
    "groupTitle": "Tickets"
  }
] });
