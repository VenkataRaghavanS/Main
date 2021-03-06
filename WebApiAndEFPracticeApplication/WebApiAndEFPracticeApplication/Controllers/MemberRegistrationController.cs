﻿using System.Web.Http;
using BusinessLayer;
using DatabaseFirstDataLayer;

namespace WebApiAndEFPracticeApplication.Controllers
{
    public class MemberRegistrationController : ApiController
    {
        MemberLoginDetailsManager memberLoginDetailsManager = new MemberLoginDetailsManager();
        
        [HttpPost]
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

        [HttpGet]
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
        
        [HttpGet]
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
