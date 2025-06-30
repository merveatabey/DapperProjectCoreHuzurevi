using System;
using DapperCoreProjectHuzurevi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DapperCoreProjectHuzurevi.ViewComponents
{
	public class SubeDropdownViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var subeler = DP.Listeleme<SubeModel>("GetSubeBySubeAdi");
			return View(subeler);
		}
	}
}

