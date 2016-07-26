using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.IO;

namespace CSharpCustomActionProject
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult MyCustomActionMethod(Session session)
        {
            session.Log("Executing MyCustomAction");

            File.CreateText(@"C:\TEMP\Installed.txt");

            return ActionResult.Success;
        }
    }
}
