using Nas.Core.Domain.Customers;
using Nas.Core.Domain.Directory;
using Nas.Core.Domain.Localization;
using Nas.Core.Domain.Stores;
using Nas.Core.Domain.Tax;

namespace Nas.Core
{
    /// <summary>
    /// Store context
    /// </summary>
    public interface IStoreContext
    {
        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        Store CurrentStore { get; }
    }
}
