using System;
using DIPSky.Core.Configuration;
using DIPSky.Core.Infrastructure.DependencyManagement;

namespace DIPSky.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the 
    /// various services composing the DIPSky engine. Edit functionality, modules
    /// and implementations access most DIPSky functionality through this 
    /// interface.
    /// </summary>
    public interface IEngine
    {
        ContainerManager ContainerManager { get; }
        
        /// <summary>
        /// Initialize components and plugins in the DIPSky environment.
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize(DipSkyConfig config);

        T Resolve<T>() where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();
    }
}
