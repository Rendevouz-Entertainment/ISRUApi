using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;

namespace ISRUApi.Modules;

[Serializable]
public class Data_Mining: ModuleData
{
    public override Type ModuleType => typeof(Module_Mining);

    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(ExcludeFromContext = true)]
    [LocalizedField("ISRUApi/Modules/Data_Mining/deployed")]
    public ModuleProperty<bool> deployed = new ModuleProperty<bool>(false);

    [JsonIgnore]
    public PartComponentModule_Mining PartComponentModule;
}