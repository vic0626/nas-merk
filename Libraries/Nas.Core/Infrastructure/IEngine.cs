using System;
using Nas.Core.Configuration;
using Nas.Core.Infrastructure.DependencyManagement;

namespace Nas.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the 
    /// various services composing the Nas engine. Edit functionality, modules
    /// and implementations access most Nas functionality through this 
    /// interface.
    /// </summary>
    public interface IEngine
    {
        ContainerManager ContainerManager { get; }
        
        /// <summary>
        /// Initialize components and plugins in the Nas environment.
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize(NasConfig config);

        T Resolve<T>() where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();
    }
}
