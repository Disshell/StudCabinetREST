using AutoMapper;
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
        public async Task<IEnumerable<ApplicationMainInfoResource>> GetApplications(){
            var applications = await context.ApplicationMainInfo.ToListAsync();

            return mapper.Map<List<ApplicationMainInfo>, List<ApplicationMainInfoResource>>(applications);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateApplication([FromBody]ApplicationMainInfoResource applicationResource){

            var application = mapper.Map<ApplicationMainInfoResource, ApplicationMainInfo>(applicationResource);
            context.ApplicationMainInfo.Add(application);
            await context.SaveChangesAsync();
            var result = mapper.Map<ApplicationMainInfo, ApplicationMainInfoResource>(application);
            return Ok(result);
        }
    }
}