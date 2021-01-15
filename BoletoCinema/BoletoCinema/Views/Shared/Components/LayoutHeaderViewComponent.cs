using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Data;
using BoletoCinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoletoCinema.Views.Shared.Components
{

    public class LayoutHeaderViewComponent : ViewComponent
    {
        private readonly BoletoContext _context;
        public LayoutHeaderViewComponent(BoletoContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            User user = Ultils.getCurrentUser(HttpContext);
            return View(user);
        }
    }
}
