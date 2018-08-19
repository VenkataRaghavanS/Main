using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using Domain;

namespace WebApiAndEFPracticeApplication.Controllers
{
    public class MemberRegistrationController : ApiController
    {
        MemberLoginDetailsManager memberLoginDetailsManager = new MemberLoginDetailsManager();
        
        public IHttpActionResult RegisterMember([FromBody]MemberLoginDetails memberLoginDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(memberLoginDetailsManager.RegisterMember(memberLoginDetails))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        public IHttpActionResult CheckIfMemberAlreadyExists(string userName)
        {
            if (memberLoginDetailsManager.CheckIfMemberAlreadyExists(userName))
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
        // GET: api/MemberRegistration
        public IHttpActionResult LoginMember(string userName, string password)
        {
            int memberId = memberLoginDetailsManager.LoginMember(userName, password);
            if (memberId > 0)
            {
                return Ok(memberId);
            }
            else
            {
                return NotFound();
            }
        }

        protected override void Dispose(bool disposing)
        {
            memberLoginDetailsManager.Dispose();
            base.Dispose(disposing);
        }
    }
}
