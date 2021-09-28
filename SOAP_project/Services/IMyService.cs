using SOAP_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SOAP_project.Services
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string Test(string s);
       
        [OperationContract]
        UserModel TestUserModel(UserModel model);
    }
}
