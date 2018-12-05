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
        public async Task<IEnumerable<CertificateTypeResource>> GetCertificateType(){
            var certificateTypes = await context.CertificateType.ToListAsync();

            return mapper.Map<List<CertificateType>, List<CertificateTypeResource>>(certificateTypes);
        }

        [HttpGet("/api/info/institutiontypes")]
        public async Task<IEnumerable<InstitutionTypeResource>> GetInstitutionType(){
            var institutionTypes = await context.InstitutionType.ToListAsync();

            return mapper.Map<List<InstitutionType>, List<InstitutionTypeResource>>(institutionTypes);
        }

        [HttpGet("/api/info/faculties")]
        public async Task<IEnumerable<FacultyResources>> Getfaculty(){
            var faculties = await context.Faculty.ToListAsync();

            return mapper.Map<List<Faculty>, List<FacultyResources>>(faculties);
        }

        [HttpGet("/api/info/directions")]
        public async Task<IEnumerable<DirectionResource>> GetDirections(){
            var directions = await context.Direction.ToListAsync();

            return mapper.Map<List<Direction>, List<DirectionResource>>(directions);
        }

        [HttpGet("/api/info/specializations")]
        public async Task<IEnumerable<SpecializationResource>> GetSpecializations(){
            var specializations = await context.Specialization.ToListAsync();

            return mapper.Map<List<Specialization>, List<SpecializationResource>>(specializations);
        }

    }
}