using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace ValidatePIDcustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult ValidateMethod(Session session)
        {
            session.Log("Begin Validate PID");
            string ProductKey = session["PIDKEY"].ToString();

            if (ProductKey.Substring(0,1) == "1")
            {
                session["PIDACCEPTED"] = "1";
            }
            else
            {
                session["PIDACCEPTED"] = "0";
            }

            return ActionResult.Success;
        }
    }
}
