using Microsoft.AspNetCore.Mvc;
using Smartstore.HelloWorld.Models;
using Smartstore.HelloWorld.Settings;
using Smartstore.ComponentModel;
using Smartstore.Web.Controllers;
using Smartstore.Web.Modelling.Settings;

namespace Smartstore.HelloWorld.Controllers
{
    public class HelloWorldController : PublicController
    {
        [LoadSetting]
        public IActionResult PublicInfo(HelloWorldSettings settings)
        {
            var model = MiniMapper.Map<HelloWorldSettings, PublicInfoModel>(settings);

            return View(model);
        }
    }
}