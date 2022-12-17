using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class HomeworldEnterEditorMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string[] editorModifierNames;
        [JsonProperty] public readonly string[] worldModifierNames;
    }
}
