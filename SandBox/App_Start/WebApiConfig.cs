﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace SandBox
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "UnreadMessages",
                routeTemplate: "api/emailmessages/unread",
                defaults: new { controller = "EmailMessages", action = "GetNumberOfUnreadMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "IncomingMessages",
                routeTemplate: "api/emailmessages/inbox",
                defaults: new { controller = "EmailMessages", action = "GetIncomingMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "OutcomingMessages",
                routeTemplate: "api/emailmessages/outbox",
                defaults: new { controller = "EmailMessages", action = "GetOutcomingMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "FollowersCount",
                routeTemplate: "api/followers/{id}",
                defaults: new { controller = "Subscriptions", action = "GetNumberOfFollowers" }
            );

            config.Routes.MapHttpRoute(
                name: "UsersSugestions",
                routeTemplate: "api/users/{nameQuery}",
                defaults: new { controller = "Users", action = "GetUsers" }
            );


            config.Routes.MapHttpRoute(
                name: "Subscriptions",
                routeTemplate: "api/publishers/{id}",
                defaults: new { controller = "Users", action = "GetSubscriptions" }
            );

            config.Routes.MapHttpRoute(
                name: "Followers",
                routeTemplate: "api/followers",
                defaults: new { controller = "Users", action = "GetMyFollowers" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
