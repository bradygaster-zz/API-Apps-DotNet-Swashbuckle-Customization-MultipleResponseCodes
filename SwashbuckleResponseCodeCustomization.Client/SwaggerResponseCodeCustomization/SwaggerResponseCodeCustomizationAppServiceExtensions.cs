using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace SwashbuckleResponseCodeCustomization.Client
{
    public static class SwaggerResponseCodeCustomizationAppServiceExtensions
    {
        public static SwaggerResponseCodeCustomization CreateSwaggerResponseCodeCustomization(this IAppServiceClient client)
        {
            return new SwaggerResponseCodeCustomization(client.CreateHandler());
        }

        public static SwaggerResponseCodeCustomization CreateSwaggerResponseCodeCustomization(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new SwaggerResponseCodeCustomization(client.CreateHandler(handlers));
        }

        public static SwaggerResponseCodeCustomization CreateSwaggerResponseCodeCustomization(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new SwaggerResponseCodeCustomization(uri, client.CreateHandler(handlers));
        }

        public static SwaggerResponseCodeCustomization CreateSwaggerResponseCodeCustomization(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new SwaggerResponseCodeCustomization(rootHandler, client.CreateHandler(handlers));
        }
    }
}
