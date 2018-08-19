using BusinessLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiAndEFPracticeApplication.Controllers
{
    [Authorize]
    public class MemberOrderController : ApiController
    {
        MemberOrderDetailsManager memberOrderDetailsManager = new MemberOrderDetailsManager();
        // GET: api/MemberDetails
        public IHttpActionResult Get()
        {
            var result = memberOrderDetailsManager.GetAllMemberOrderDetailsRecords();
            if (result.Any())
                return Ok(result);
            else
                return NotFound();
        }

        // GET: api/MemberDetails/5
        public IHttpActionResult Get(int id)
        {
            var result = memberOrderDetailsManager.GetSpecificMemberOrderDetailsRecord(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/MemberDetails
        public IHttpActionResult Post([FromBody]MemberOrderDetails memberOrderDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = memberOrderDetailsManager.AddMemberOrderDetails(memberOrderDetails);
            return CreatedAtRoute("DefaultApi", new { id = result.Id }, result);
        }

        // PUT: api/MemberDetails/5
        public IHttpActionResult Put([FromBody]MemberOrderDetails memberOrderDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            memberOrderDetailsManager.UpdateMemberOrderDetails(memberOrderDetails);

            return Ok();
        }

        // DELETE: api/MemberDetails/5
        public IHttpActionResult Delete([FromBody]MemberOrderDetails memberOrderDetails)
        {
            memberOrderDetailsManager.DeleteMemberOrderDetails(memberOrderDetails);
            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            memberOrderDetailsManager.Dispose();
            base.Dispose(disposing);
        }
    }
}
