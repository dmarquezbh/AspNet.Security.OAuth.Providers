/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using AspNet.Security.OAuth.Hospitale;
using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Builder {
    /// <summary>
    /// Extension methods to add Hospitale authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class HospitaleAuthenticationExtensions {
        /// <summary>
        /// Adds the <see cref="HospitaleAuthenticationMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>, which enables Hospitale authentication capabilities.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
        /// <param name="options">A <see cref="HospitaleAuthenticationOptions"/> that specifies options for the middleware.</param>        
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IApplicationBuilder UseHospitaleAuthentication(
            [NotNull] this IApplicationBuilder app,
            [NotNull] HospitaleAuthenticationOptions options) {
            if (app == null) {
                throw new ArgumentNullException(nameof(app));
            }

            if (options == null) {
                throw new ArgumentNullException(nameof(options));
            }

            return app.UseMiddleware<HospitaleAuthenticationMiddleware>(Options.Create(options));
        }

        /// <summary>
        /// Adds the <see cref="HospitaleAuthenticationMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>, which enables Hospitale authentication capabilities.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
        /// <param name="configuration">An action delegate to configure the provided <see cref="HospitaleAuthenticationOptions"/>.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IApplicationBuilder UseHospitaleAuthentication(
            [NotNull] this IApplicationBuilder app,
            [NotNull] Action<HospitaleAuthenticationOptions> configuration) {
            if (app == null) {
                throw new ArgumentNullException(nameof(app));
            }

            if (configuration == null) {
                throw new ArgumentNullException(nameof(configuration));
            }

            var options = new HospitaleAuthenticationOptions();
            configuration(options);

            return app.UseMiddleware<HospitaleAuthenticationMiddleware>(Options.Create(options));
        }
    }
}
