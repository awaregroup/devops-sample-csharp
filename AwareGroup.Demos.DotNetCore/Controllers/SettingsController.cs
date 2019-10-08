using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwareGroup.Demos.DotNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AwareGroup.Demos.DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        public readonly IOptions<Settings> _settings;

        public SettingsController(IOptions<Settings> settings)
        {
            _settings = settings;
        }

        [HttpGet]
        public IOptions<Settings> GetAppSettings()
        {
            return _settings;
        }
    }
}