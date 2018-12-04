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
    public class ApplicationController: Controller
    {
        private readonly StudDBContext context;
        private readonly IMapper mapper;

        public ApplicationController(StudDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/applications")]
        public async Task<IEnumerable<ObjectResource>> GetApplications(){
            var status = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(status);
        }
    }
}