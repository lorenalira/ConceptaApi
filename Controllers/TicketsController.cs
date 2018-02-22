using ConceptaApi.Models;
using ConceptaApi.Models.Request;
using ConceptaApi.Models.Response;
using ConceptaApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/**
  * @api {post} api/Tickets Get tickets information
  * @apiName GetTickets
  * @apiGroup Tickets
  *
  * @apiExample {json} Example usage:
  *   curl -H \"Authorization: Bearer MEStxaC7B20vYK-t78jYF5xsmp6DQ-En2Yl3e1lW8kaxrv4XBQJEd--VSdKCB2CypP-JYmJD3jMtMiCpJ8juyTStFt4348xtb4Nbm5me-rDInB_YMQH4-e7FbfZbc27-YEwxfafXKI-gJjP7mnmPP7afENExIWJ3Lq3xlmurxY4Mt36P6Yw7ocQtIbcRa8C7lcj71RAZTK8ibkvf6wWqewRmRh405XB2GilY7m0vXWdQKoqfGbft93507lNrHjpH7d-H12weS7vBhXZpY-CzmS5jJ_b3vNT_V2J872vFYnHX0h4SpjxtlOaU9Jz2Ec2nxUevbD2tFsDAUr1497cnvp9P_otpB5KwqK2vj4h5pfmzLyfZMul2ES0CnhnEEeEC5TuqnzUd7gQLeemZA6ZymEQ412lYWYx0GL5Iw_V5o-NgyCZJSIJdo3Ag5qUei18ksYx0fzDrqZqpbJ93NPZw15cJL93-w_D8LNy7M09QYBXyFHdGlVFkhDgPVNK5cdPR-QrhNCAwsyeCV6Jozrb5uQ\" -H \"Content-Type: application/json\" -d '{
  *     "Language":"ENG",
  *     "Currency":"USD",
  *     "destination":"MCO",
  *     "DateFrom":"11/26/2018",
  *     "DateTO":"11/29/2018",
  *     "Occupancy":{
  *         "AdultCount":"1",
  *             "ChildCount":"1",
  *             "ChildAges":[
  *                 "10"
  *             ]
  *         }
  *     }' -X POST 127.0.0.1:5000/v1/auth
  *
  * @apiSuccessExample {json} Success-Response:
  *   HTTP/1.1 200 OK
  * [
  *     {
  *        "Destination":"MCO",
  *        "Code":"WDWBASENXT",
  *        "Classification":"Theme & Aquatic Parks",
  *        "Name":"Disney Magic Your Way Base Ticket with NoExpiration Option",
  *        "Description":"The Walt Disney World Resort is the place wherefun reigns supreme and dreams come true every day. With four Theme Parks,two Water Parks plus Downtown Disney Area - where the most amazingshopping, dining and entertainment imaginable can be found. Discover anentire world of enchantment and wonder around every corner with one ofDisney's Magic Your Way Tickets. Disney’s Magic Your Way Base Ticket offersadmission to one of the following theme parks for each day of the ticket",
  *        "ImageThumb":"http://www.hotelbeds.com/giata/extras/small/ds/28917/28917_3.jpg",
  *        "ImageFull":"http://www.hotelbeds.com/giata/extras/big/ds/28917/28917_3.jpg",
  *        "AvailableModality":[
  *           {
  *              "Code":"0#CNX09/19",
  *              "Name":"3 Days",
  *              "Contract":"2015WDWEURTO",
  *              "ServicePrice":656.08,
  *              "OperationDateList":[
  *                 {
  *                    "From":"11/26/2018",
  *                    "To":"11/29/2018"
  *                 },
  *                 {
  *                    "From":"11/27/2015",
  *                    "To":"11/30/2015"
  *                 }
  *              ]
  *           },
  *           // loop
  *        ]
  *     },
  *     // loop
  *  ]
  */
namespace ConceptaApi.Controllers
{
    /// <summary>
    /// TicketSearchController
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        private readonly ITicketSearchService TicketService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="service"></param>
        public TicketsController(ITicketSearchService service)
        {
            TicketService = service;
        }

        /// <summary>
        /// TicketServiceResponse
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult<IEnumerable<TicketServiceResponse>>> Post([FromBody] TicketServiceRequest request)
        {
            try
            {
                var result = await TicketService.GetTickets(request);
                return await Task.FromResult(new TicketServiceResult().Success(result));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new TicketServiceResult().Error(ex.Message));
            }
        }
    }
}