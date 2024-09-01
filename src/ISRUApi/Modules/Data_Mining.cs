using System.ComponentModel;
using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;

namespace ISRUApi.Modules;

[Serializable]
public class Data_Mining: ModuleData
{
    public override Type ModuleType => typeof(Module_Mining);

    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(ExcludeFromContext = true, SortIndex = 2)]
    [LocalizedField("ISRUApi/Modules/Data_Mining/deployed")]
    public ModuleProperty<bool> deployed = new ModuleProperty<bool>(false);

    [LocalizedField("ISRUApi/Modules/Data_Mining/status")]
    [PAMDisplayControl(SortIndex = 1)]
    public ModuleProperty<MiningState> controlStatus = new ModuleProperty<MiningState>(MiningState.Stopped, true);

    [JsonIgnore]
    public PartComponentModule_Mining PartComponentModule;

    protected override void InitProperties()
    {
        base.InitProperties();

        controlStatus.SetValue(deployed.GetValue() ? MiningState.Mining : MiningState.Stopped);
    }
}

public enum MiningState : byte
{
    None = 0,
    [Description("ISRUApi/Modules/Data_Mining/status/Mining")] Mining = 1,
    [Description("ISRUApi/Modules/Data_Mining/status/Stopped")] Stopped = 2,
}