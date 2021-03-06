﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using vOpenUYCQRS.Application.Categories.Queries.GetCategoriesList;

namespace vOpenUYCQRS.WebUI.Controllers
{
    //[Authorize]
    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IList<CategoryLookupDto>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCategoriesListQuery()));
        }
    }
}
