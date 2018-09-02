using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseFirstDataLayer;
using BusinessLayer;

namespace WebApiAndEFPracticeApplication.Controllers
{
    //[Authorize]
    public class MemberDetailsController : ApiController
    {
        MemberDetailsManager memberDetailsManager = new MemberDetailsManager();
        // GET: api/MemberDetails
        public IHttpActionResult Get()
        {
            var result = memberDetailsManager.GetAllMemberDetailsRecords();
            if (result.Any())
                return Ok(result);
            else
                return NotFound();
        }

        // GET: api/MemberDetails/5
        public IHttpActionResult Get(int id)
        {
            var result = memberDetailsManager.GetSpecificMemberDetailsRecord(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/MemberDetails
        public IHttpActionResult Post([FromBody]MemberDetails memberDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = memberDetailsManager.AddMemberDetails(memberDetails);
            return CreatedAtRoute("DefaultApi", new { id = result.MemberLoginDetails.MemberId }, result);
        }

        // PUT: api/MemberDetails/5
        public IHttpActionResult Put([FromBody]MemberDetails memberDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            memberDetailsManager.UpdateMemberDetails(memberDetails);
 
            return Ok();
        }

        // DELETE: api/MemberDetails/5
        public IHttpActionResult Delete([FromBody]MemberDetails memberDetails)
        {
            memberDetailsManager.DeleteMemberDetails(memberDetails);
            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            memberDetailsManager.Dispose();
            base.Dispose(disposing);
        }
    }
}
