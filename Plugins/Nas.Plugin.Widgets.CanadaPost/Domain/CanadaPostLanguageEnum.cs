
using System.Runtime.Serialization;

namespace Nas.Plugin.Shipping.CanadaPost.Domain
{
    [DataContract(Name = "Language")]
    public enum CanadaPostLanguageEnum
    {
        [EnumMember]
        English = 0,
        [EnumMember]
        French = 1
    }
}
