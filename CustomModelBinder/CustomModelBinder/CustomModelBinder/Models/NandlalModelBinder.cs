using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CustomModelBinder.Models
{
    public class NandlalModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var value = request.Headers.GetValues("WebGentle");
            return JsonConvert.DeserializeObject<Employee>(value.First());
            //throw new NotImplementedException();
        }
    }
}