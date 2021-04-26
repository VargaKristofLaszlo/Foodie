﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Dal.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Foodie.Web.ViewComponents
{
    public class PagerViewComponent : ViewComponent
    {
        public class PagerSpecification
        {
            public int AllResultsCount { get; set; }
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
            public int TotalPages { get; set; }
            public int PagesToShow { get; set; }
        }

        public IViewComponentResult Invoke(int pageSize, int pageNumber, int allResultsCount, int pagesToShow)
        {
            return View(new PagerSpecification
            {
                AllResultsCount = allResultsCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(allResultsCount / (double)pageSize),
                PagesToShow = pagesToShow
            });
        }
    }
}
