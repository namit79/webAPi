using start.Models;
using System;
using System.Web.Http;

namespace start.Controllers
{
    public class AddController : ApiController
    {
        database_Access_Layer.db dblayer = new database_Access_Layer.db();
        [HttpPost]
        public IHttpActionResult AddDocument([FromBody]document dc)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                dblayer.AddDocuments(dc);
                return Ok("SUCCESS");

            }
            catch (Exception e)
            {
                return Ok("something went wrong");
            }
        }
    }
}
