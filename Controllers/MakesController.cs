using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using dotnetCore.Controllers.Resources;
using dotnetCore.model;
using dotnetCore.Persistent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore.Controllers
{
    public class MakesController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public MakesController(AppDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> Getmakes()
        {
            var makes =  await context.Makes.Include(x => x.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}