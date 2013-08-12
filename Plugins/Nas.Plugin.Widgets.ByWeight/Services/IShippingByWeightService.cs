using System.Collections.Generic;
using Nas.Core;
using Nas.Plugin.Shipping.ByWeight.Domain;

namespace Nas.Plugin.Shipping.ByWeight.Services
{
    public partial interface IShippingByWeightService
    {
        void DeleteShippingByWeightRecord(ShippingByWeightRecord shippingByWeightRecord);

        IPagedList<ShippingByWeightRecord> GetAll(int pageIndex = 0, int pageSize = int.MaxValue);

        ShippingByWeightRecord FindRecord(int shippingMethodId,
            int countryId, int stateProvinceId, string zip, decimal weight);

        ShippingByWeightRecord GetById(int shippingByWeightRecordId);

        void InsertShippingByWeightRecord(ShippingByWeightRecord shippingByWeightRecord);

        void UpdateShippingByWeightRecord(ShippingByWeightRecord shippingByWeightRecord);
    }
}
