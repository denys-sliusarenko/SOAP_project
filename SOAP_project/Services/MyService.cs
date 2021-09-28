using Microsoft.AspNetCore.Mvc;
using SOAP_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SOAP_project.Services
{
    public class MyService:IMyService
    {
        public string Test(string s)
        {
            return "Your message: "+ s;
        }


        public UserModel TestUserModel(UserModel customModel)
        {
             return customModel;
        }
    }
}
