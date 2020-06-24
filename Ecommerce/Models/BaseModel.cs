using System.Runtime.Serialization;

namespace Ecommerce.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }
}
