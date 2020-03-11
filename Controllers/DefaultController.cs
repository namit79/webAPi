using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace start.Controllers
{
    public class DefaultController : ApiController
    {
        database_Access_Layer.db dblayer = new database_Access_Layer.db();
        public DataSet getRecord()
        {
            DataSet ds = dblayer.GetAllUsers();
            return ds;
        }

        // GET: api/Default
        
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public DataSet getRecordById(int id)
        {
            DataSet ds = dblayer.GetUsersById(id);
            return ds;
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
