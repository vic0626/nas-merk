using Nas.Core.Domain.Orders;

namespace Nas.Services.Payments
{
    /// <summary>
    /// Represents a CapturePaymentRequest
    /// </summary>
    public partial class CapturePaymentRequest
    {
        /// <summary>
        /// Gets or sets an order
        /// </summary>
        public Order Order { get; set; }
    }
}
