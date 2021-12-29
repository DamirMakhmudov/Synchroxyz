using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchroxyz
{
    public class JsonObject
    {
        public JsonObject() { }
        public string GUID { get; set; }
        public JsonO_Project O_Project { get; set; }
        public JsonO_PLAN_WBS O_PLAN_WBS { get; set; }
        public List<JsonO_PLAN_WBS> O_PLAN_WBSs { get; set; }
}

    public class JsonO_Project
    {
        public JsonO_Project() { }
        public string extGUID { get; set; }
        public string A_Date_Begin { get; set; }
        public string A_Date_Begin_Fact { get; set; }
        public string A_Date_End { get; set; }
        public string A_Date_End_Fact { get; set; }
        public string A_Str_Name { get; set; }
        public string A_Str_Note { get; set; }
    }
    public class JsonO_PLAN_WBS
    {
        public JsonO_PLAN_WBS() { }
        public string extGUID { get; set; }
        public string A_Date_Begin { get; set; }
        public string A_Date_Begin_Fact { get; set; }
        public string A_Date_End { get; set; }
        public string A_Date_End_Fact { get; set; }
        public string A_Str_Name { get; set; }
        public string A_Str_Note { get; set; }
    }
}
