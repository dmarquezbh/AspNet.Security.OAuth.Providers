/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.Hospitale {
    /// <summary>
    /// Defines a set of options used by <see cref="HospitaleAuthenticationHandler"/>.
    /// </summary>
    public class HospitaleAuthenticationOptions : OAuthOptions {
        public HospitaleAuthenticationOptions() {
            AuthenticationScheme = HospitaleAuthenticationDefaults.AuthenticationScheme;
            DisplayName = HospitaleAuthenticationDefaults.Displayname;
            ClaimsIssuer = HospitaleAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(HospitaleAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = HospitaleAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = HospitaleAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = HospitaleAuthenticationDefaults.UserInformationEndpoint;

            Scope.Add("profile");
        }
    }
}
