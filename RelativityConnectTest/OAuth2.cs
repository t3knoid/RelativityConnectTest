using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using kCura.Relativity.Client.DTOs;
using DTOs = kCura.Relativity.Client.DTOs;
using Relativity.OAuth2Client.IdentityModel.Client;
using Relativity.OAuth2Client.IdentityModel.Interfaces;
using Relativity.Services.ServiceProxy;


namespace RelativityConnectTest
{
    class OAuth2
    {
        public string RestUri { get; set; }
        public string ServicesUri { get; set; }
        public string IdentityServerTokenUrl { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }

        public static ITokenResponse token = null;

        public OAuth2()
        { }

        public static ServiceFactory GetServiceFactory(ApiConfig apiConfig)
        {
            Uri hostUri = new Uri(apiConfig.RestUri);
            Uri serviceUri = new Uri(apiConfig.ServicesUri);

            using (TokenClient clientToken = new TokenClient(apiConfig.IdentityServerTokenUrl, apiConfig.ClientId, apiConfig.ClientSecret))
            {

                token = clientToken.RequestClientCredentialsAsync("SystemUserInfo").ConfigureAwait(false).GetAwaiter().GetResult();
                if (token.Exception != null)
                {
                    throw token.Exception;
                }
            }

            //create token object (bearerToken)
            //token will return a string
            BearerTokenCredentials bearerToken = new BearerTokenCredentials(token.AccessToken);

            // ServiceFactorySettings class contains the Service Factory instantiation parameters
            ServiceFactorySettings settings = new ServiceFactorySettings(serviceUri, hostUri, bearerToken);
            return new ServiceFactory(settings);
        }


        public kCura.Relativity.Client.IRSAPIClient GetRSAPIClient(ApiConfig apiConfig)
        {
            // Sets up connection with Bearer token authentication.
            var serviceFactory = GetServiceFactory(apiConfig);
            kCura.Relativity.Client.IRSAPIClient proxy = serviceFactory.CreateProxy<kCura.Relativity.Client.IRSAPIClient>();
            return proxy;
        }

        public bool RetrieveRelativityWorkspaces(string workspaceName = "")
        {
            List<NameValueObject> workspaces = new List<NameValueObject>();

            try
            {
                ApiConfig apiConfig = new ApiConfig
                {
                    // Set the environment variables:
                    RestUri = this.RestUri,
                    ServicesUri = this.ServicesUri,
                    IdentityServerTokenUrl = this.IdentityServerTokenUrl,
                    // oAuth2 client of type client credentials
                    ClientId = this.ClientID,
                    ClientSecret = this.ClientSecret
                };

                using (var client = GetRSAPIClient(apiConfig))
                {
                    string t = client.Login();
                    NameValueObject currentWorkspaceInfo = new NameValueObject();

                    //Query for all workspace and load them in the dropdown.
                    Query<Workspace> query = new Query<DTOs.Workspace>();
                    query.Fields.Add(new DTOs.FieldValue("Name"));
                    query.Fields.Add(new DTOs.FieldValue("Status"));
                    //Send the query and receive results.
                    QueryResultSet<DTOs.Workspace> results = client.Repositories.Workspace.Query(query);                    
                    return results.Success;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class ApiConfig
    {
        /// <summary>
        /// https://[local]/Relativity.Rest/API
        /// </summary>
        public string RestUri { get; set; }
        /// <summary>
        /// "https://[local]/relativity.services/"
        /// </summary>
        public string ServicesUri { get; set; }
        /// <summary>
        /// "https://[local]/Relativity/Identity/connect/token"
        /// </summary>
        public string IdentityServerTokenUrl { get; set; }
        /// <summary>
        /// oAuth2 client ID
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// oAuth2 client Secret
        /// </summary>
        public string ClientSecret { get; set; }

    }
}
