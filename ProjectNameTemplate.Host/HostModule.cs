﻿using ProjectNameTemplate.Application;
using ProjectNameTemplate.Core;
using ProjectNameTemplate.Repository;
using System.Reflection;
using Talk;

namespace ProjectNameTemplate.Host
{    
    [DependsOn(typeof(CoreModule), typeof(ApplicationModule), typeof(RepositoryModule))]
    public class HostModule : AppModule
    {
        public override void Initialize()
        {
            ModuleAssembly = Assembly.GetExecutingAssembly();
        }
    }
}
