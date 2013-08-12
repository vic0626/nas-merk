using System.Net;
using Nas.Core;
using Nas.Services.Stores;
using Nas.Services.Tasks;

namespace Nas.Services.Common
{
    /// <summary>
    /// Represents a task for keeping the site alive
    /// </summary>
    public partial class KeepAliveTask : ITask
    {
        private readonly IStoreContext _storeContext;

        public KeepAliveTask(IStoreContext storeContext)
        {
            this._storeContext = storeContext;
        }

        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            string url = _storeContext.CurrentStore.Url + "keepalive";
            using (var wc = new WebClient())
            {
                wc.DownloadString(url);
            }
        }
    }
}
