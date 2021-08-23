using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Api.Models;
using Api.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NewsController : ControllerBase
    {
		private readonly NewsDbContext context;

		public NewsController(NewsDbContext context)
        {
			this.context = context;
		}

        [HttpGet]
        public IEnumerable<string> GetCategories()
        {
            return context.Articles.Select(a => a.Category).Distinct();
        }

        [HttpGet]
        public IEnumerable<Article> GetArticles(string category)
        {
            return context.Articles.Where(a => a.Category == category);
        }
    }
}
