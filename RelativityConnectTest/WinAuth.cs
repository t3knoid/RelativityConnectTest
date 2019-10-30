using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using kCura.Relativity.Client.DTOs;
using DTOs = kCura.Relativity.Client.DTOs;
using Relativity.Services.ServiceProxy;


namespace RelativityConnectTest
{
    public class WinAuth
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public string RestURL { get; set; }

        public string ServicesURL { get; set; }

        public WinAuth()
        { }

        public static Relativity.Services.ServiceProxy.ServiceFactory GetServiceFactory(WindowsCredentials cred)
        {
            Uri RestURI = new Uri(cred.RestURL);
            Uri servicesURI = new Uri(cred.ServicesURL);
            ServiceFactorySettings settings;

            if (String.IsNullOrEmpty(cred.Username.Trim()))
            {
                // Use Windows integrated authentication
                IntegratedAuthCredentials credentials = new IntegratedAuthCredentials();
                settings = new ServiceFactorySettings(servicesURI, RestURI, credentials);
            }
            else
            {
                UsernamePasswordCredentials credentials = new UsernamePasswordCredentials(cred.Username, cred.Password);
                settings = new ServiceFactorySettings(servicesURI, RestURI, credentials);
            }
            
            return new ServiceFactory(settings);
            
        }

        public kCura.Relativity.Client.IRSAPIClient GetRSAPIClient(WindowsCredentials cred)
        {
            // Sets up connection with Bearer token authentication.
            var serviceFactory = GetServiceFactory(cred);
            kCura.Relativity.Client.IRSAPIClient proxy = serviceFactory.CreateProxy<kCura.Relativity.Client.IRSAPIClient>();
            return proxy;
        }

        public bool RetrieveRelativityWorkspaces(string workspaceName = "")
        {
            List<NameValueObject> workspaces = new List<NameValueObject>();

            try
            {
                WindowsCredentials windowsCred = new WindowsCredentials
                {
                     Username = this.Username,
                     Password = this.Password,
                     RestURL = this.RestURL,
                     ServicesURL = this.ServicesURL
                };

                using (var client = GetRSAPIClient(windowsCred))
                {
                    NameValueObject currentWorkspaceInfo = new NameValueObject();

                    //Query for all workspace and load them in the dropdown.

                    kCura.Relativity.Client.DTOs.Query<kCura.Relativity.Client.DTOs.Workspace> query = new kCura.Relativity.Client.DTOs.Query<kCura.Relativity.Client.DTOs.Workspace>();
                    query.Fields.Add(new kCura.Relativity.Client.DTOs.FieldValue("Name"));
                    query.Fields.Add(new kCura.Relativity.Client.DTOs.FieldValue("Status"));
                    //Send the query and receive results.
                    kCura.Relativity.Client.DTOs.QueryResultSet<kCura.Relativity.Client.DTOs.Workspace> results = client.Repositories.Workspace.Query(query);
                    return results.Success;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class WindowsCredentials
    {
        public string RestURL { get; set; }
        public string ServicesURL { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
