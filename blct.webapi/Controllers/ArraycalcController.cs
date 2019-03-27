using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blct.Interfaces;
using Blct.WebApi.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Blct.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ArraycalcController : ControllerBase
    {
        private readonly IArrayOperations arrayOperations;

        public ArraycalcController(IArrayOperations arrayOperations)
        {
            this.arrayOperations = arrayOperations;
        }

        // GET api/arraycalc/reverse
        [HttpGet()]
        [Route("reverse")]
        public ActionResult<IEnumerable<int>> Reverse([FromQuery] RequestReverseParameters query)
        {
            return arrayOperations
                .Reverse(query.ProductIds)
                .ToArray();
        }

        // GET api/arraycalc/reverse
        [HttpGet()]
        [Route("deletepart")]
        public ActionResult<IEnumerable<int>> DeletePart([FromQuery] RequestDeletePartParameters query)
        {
            return arrayOperations
                .DeletePart(query.ProductIds, query.Position)
                .ToArray();
        }
    }
}