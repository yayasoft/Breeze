﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BreezyDevices
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Ex: ~/api/breezydevices/People
      config.Routes.MapHttpRoute(
          name: "BreezeApi",
          routeTemplate: "api/{controller}/{action}"
          );


      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );

    }
  }
}