using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Weedwacker.GameServer.Database
{
    internal class IntDictionarySerializer<V> : DictionarySerializerBase<Dictionary<int, V>>
    {
        public IntDictionarySerializer() : base(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document)
        {
        }

        protected override Dictionary<int, V> CreateInstance()
        {
            return new Dictionary<int, V>();
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, Dictionary<int, V> value)
        {
            if (value != null)
            {
                Dictionary<string, V> dic = value.ToDictionary(d => d.Key.ToString(), d => d.Value);
                BsonSerializer.Serialize<Dictionary<string, V>>(context.Writer, dic);
            }
            else
                BsonSerializer.Serialize<object>(context.Writer, null);
        }
        public override Dictionary<int, V> Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            Dictionary<string, V> dic = BsonSerializer.Deserialize<Dictionary<string, V>>(context.Reader);
            if (dic == null)
                return null;

            Dictionary<int, V> ret = new Dictionary<int, V>();
            foreach (var pair in dic)
            {
                int key;
                if (!int.TryParse(pair.Key, out key))
                    continue;
                ret[key] = pair.Value;
            }
            return ret;
        }
    }

    internal class UIntDictionarySerializer<V> : DictionarySerializerBase<Dictionary<uint, V>>
    {
        public UIntDictionarySerializer() : base(MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document)
        {
        }

        protected override Dictionary<uint, V> CreateInstance()
        {
            return new Dictionary<uint, V>();
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, Dictionary<uint, V> value)
        {
            if (value != null)
            {
                Dictionary<string, V> dic = value.ToDictionary(d => d.Key.ToString(), d => d.Value);
                BsonSerializer.Serialize<Dictionary<string, V>>(context.Writer, dic);
            }
            else
                BsonSerializer.Serialize<object>(context.Writer, null);
        }
        public override Dictionary<uint, V> Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            Dictionary<string, V> dic = BsonSerializer.Deserialize<Dictionary<string, V>>(context.Reader);
            if (dic == null)
                return null;

            Dictionary<uint, V> ret = new Dictionary<uint, V>();
            foreach (var pair in dic)
            {
                uint key;
                if (!uint.TryParse(pair.Key, out key))
                    continue;
                ret[key] = pair.Value;
            }
            return ret;
        }
    }
}
