﻿using System;
using System.Web;
using System.Web.Http;
using WebApi.Example.Configurations;

namespace WebApi.Example
{
  public class Global : HttpApplication
  {

    protected void Application_Start(object sender, EventArgs e)
    {
      WebApiControllers.Register(GlobalConfiguration.Configuration);
    }

    protected void Session_Start(object sender, EventArgs e)
    {

    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {

    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {

    }

    protected void Application_Error(object sender, EventArgs e)
    {

    }

    protected void Session_End(object sender, EventArgs e)
    {

    }

    protected void Application_End(object sender, EventArgs e)
    {

    }
  }
}