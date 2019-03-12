using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudCabinetREST.Controllers.Resources;
using StudCabinetREST.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudCabinetREST.Controllers
{
    [Route("/api/applications")]
    public class ApplicationController: Controller
    {
        private readonly StudDBContext context;
        private readonly IMapper mapper;

        public ApplicationController(StudDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet()]
        [Authorize]
        public async Task<IEnumerable<ApplicationMainInfoResource>> GetApplications(){
            var applications = await context.ApplicationMainInfo.ToListAsync();

            return mapper.Map<List<ApplicationMainInfo>, List<ApplicationMainInfoResource>>(applications);
        }
        [HttpPost()]
        [Authorize]
        public async Task<IActionResult> CreateApplication([FromBody]ApplicationMainInfoResource applicationMainInfoResource){

            var application = mapper.Map<ApplicationMainInfoResource, ApplicationMainInfo>(applicationMainInfoResource);
            context.ApplicationMainInfo.Add(application);
            await context.SaveChangesAsync();
            var result = mapper.Map<ApplicationMainInfo, ApplicationMainInfoResource>(application);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplication(int id, [FromBody]ApplicationMainInfoResource applicationMainInfoResource){
            var applicationMainInfo = await context.ApplicationMainInfo
            .Include(a => a.Military)
            .Include(a => a.Passport)
            .Include(a => a.Exams)
            .Include(a => a.Applications)
            .Include(a => a.Educations)
            .Include(a => a.Privileges)
            .Include(a => a.Rewards)
            .SingleOrDefaultAsync(a => a.ApplicationMainInfoId == id);
            if (applicationMainInfo == null)
                return NotFound();
            mapper.Map<ApplicationMainInfoResource, ApplicationMainInfo>(applicationMainInfoResource, applicationMainInfo);
            await context.SaveChangesAsync();
            var result = mapper.Map<ApplicationMainInfo, ApplicationMainInfoResource>(applicationMainInfo);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplication(int id){
            var applicationMainInfo = await context.ApplicationMainInfo.FindAsync(id);
            if (applicationMainInfo == null)
                return NotFound();
            context.Remove(applicationMainInfo);
            await context.SaveChangesAsync();
            return Ok(200);
        }
    }
}