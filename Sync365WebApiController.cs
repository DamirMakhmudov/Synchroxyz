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
using System;

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
        [Route("api/GPPtransferDocResponse"), HttpPost]
        public string PostJson([FromBody] JsonObject jsonobjectO)
        {
            Logger.Info("GPPtransferDocResponse: started");
            jsonobject = jsonobjectO;
            TDMSObject O_Package_Unload = ThisApplication.GetObjectByGUID(jsonobject.O_Package_Unload.ToString());
            TDMSAttributes Attrs = O_Package_Unload.Attributes;
            if (jsonobject.Completed)
            {
                Attrs["A_Bool_Load"].Value = true;
                Attrs["A_Str_GUID_External"].Value = jsonobject.FolderGuid;
                Attrs["A_Date_Load"].Value = DateTime.Now;
                O_Package_Unload.Status = ThisApplication.Statuses["S_Package_Unload_OnReview"];
            }
            else {
                O_Package_Unload.Status = ThisApplication.Statuses["S_Package_Unload_Cancel"];
            }
            //O_Package_Unload.Attributes["A_Bool_Load"].Value = true;
            //string taskText = jsonobject.task.ToString().ToLower();
            //var req = this.Request;
            ThisApplication.SaveContextObjects();
            response = "cool";
            return response;
        }
    }


}
