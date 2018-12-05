using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudCabinetREST.Controllers.Resources;
using StudCabinetREST.Models;

namespace StudCabinetREST.Controllers
{
    public class InfoController
    {
        public InfoController (StudDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        private readonly StudDBContext context;
        private readonly IMapper mapper;

        [HttpGet("/api/info/objects")]
        public async Task<IEnumerable<ObjectResource>> GetObjects(){
            var objects = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(objects);
        }

        [HttpGet("/api/info/certificatetypes")]
        public async Task<IEnumerable<ObjectResource>> GetCertificateType(){
            var objects = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(objects);
        }

        [HttpGet("/api/info/institutiontypes")]
        public async Task<IEnumerable<ObjectResource>> GetInstitutionType(){
            var objects = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(objects);
        }

        [HttpGet("/api/info/faculties")]
        public async Task<IEnumerable<ObjectResource>> Getfaculty(){
            var objects = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(objects);
        }

        [HttpGet("/api/info/specializations")]
        public async Task<IEnumerable<ObjectResource>> GetSpecializations(){
            var objects = await context.Object.ToListAsync();

            return mapper.Map<List<Object>, List<ObjectResource>>(objects);
        }

    }
}