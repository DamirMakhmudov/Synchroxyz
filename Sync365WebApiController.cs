using Microsoft.AspNetCore.Mvc;
using Tdms.Api;
using Tdms.Log;
using System.IO;
using System.Text;
using System.Reflection;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sync365
{
    public class Sync365WebApiController : ControllerBase
    {
        public TDMSApplication ThisApplication;
        public ILogger Logger { get; set; }
        public TDMSObject thisobject;
        public JsonObject jsonobject;
        public string response;

        public Sync365WebApiController(TDMSApplication application)
        {
            ThisApplication = application;
            Logger = Tdms.Log.LogManager.GetLogger("Sync365WebApi");
        }
        [Route("api/testpost"), HttpPost]
        public string PostJson([FromBody] JsonObject jsonobjectO)
        {
            jsonobject = jsonobjectO;
            string taskText = jsonobject.task.ToString().ToLower();
            //var req = this.Request;
            Logger.Info("hello!");
            response = "cool";
            return response;
        }
    }


}
