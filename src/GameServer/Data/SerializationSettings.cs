using Newtonsoft.Json.Serialization;

namespace Weedwacker.GameServer.Data
{
    internal class SerializationSettings
    {
        // To handle $type fields
        public class KnownTypesBinder : ISerializationBinder
        {
            public IEnumerable<Type> KnownTypes { get; set; }

            public Type BindToType(string assemblyName, string typeName)
            {
                return KnownTypes.SingleOrDefault(t => t.Name == typeName);
            }

            public void BindToName(Type serializedType, out string assemblyName, out string typeName)
            {
                assemblyName = null;
                typeName = serializedType.Name;
            }
        }
    }
}
