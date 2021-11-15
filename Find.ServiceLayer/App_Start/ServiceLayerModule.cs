using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.App_Start
{
   public  class ServiceLayerModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Autowire the classes with interfaces
            builder.RegisterAssemblyTypes(GetType().Assembly).AsImplementedInterfaces();

            //--------------------------------------//

            //register other layers as implemented in your project, find example below          
            //builder.RegisterModule(new BizDbAccessModule());
            //builder.RegisterModule(new BizLogicModule());
        }
    }
}
