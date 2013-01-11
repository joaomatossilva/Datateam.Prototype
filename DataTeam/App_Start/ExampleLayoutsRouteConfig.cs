using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BootstrapMvcSample.Controllers;
using DataTeam.Controllers;
using NavigationRoutes;

namespace BootstrapMvcSample
{
    public class ExampleLayoutsRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<ExampleLayoutsController>("Administração", c => c.Carousel(), "Admin");
            routes.MapNavigationRoute<ExampleLayoutsController>("Empresa", c => c.Carousel(), "emp")
                .AddChildRoute<ExampleLayoutsController>("Colaboradores", c => c.Carousel(), "col")
                .AddChildRoute<ExampleLayoutsController>("Departamentos", c => c.Carousel(), "dep")
                .AddChildRoute<ExampleLayoutsController>("Funções", c => c.Carousel(), "fun");

            routes.MapNavigationRoute<ExampleLayoutsController>("Processos", c => c.Carousel(), "proc")
                  .AddChildRoute<ExampleLayoutsController>("Férias", c => c.Carousel(), "ferias")
                  .AddChildRoute<ExampleLayoutsController>("Despesas Colaborador", c => c.Carousel(), "desp");

            routes.MapNavigationRoute<ExampleLayoutsController>("Projectos", c => c.Carousel(), "pro")
              .AddChildRoute<ExampleLayoutsController>("Projectos", c => c.Carousel(), "proj")
              .AddChildRoute<TimesheetsController>("Timesheets", c => c.Index());

            routes.MapNavigationRoute<ExampleLayoutsController>("Colaboração", c => c.Carousel(), "colab")
                  .AddChildRoute<ExampleLayoutsController>("Lista TODOs", c => c.Carousel(), "todos")
                  .AddChildRoute<ExampleLayoutsController>("Templates", c => c.Carousel(), "templates");


            routes.MapNavigationRoute<ExampleLayoutsController>("Relatórios", c => c.Carousel(), "reports");

            routes.MapNavigationRoute<ExampleLayoutsController>("Grupo", c => c.Carousel(), "group");
        }
    }
}
