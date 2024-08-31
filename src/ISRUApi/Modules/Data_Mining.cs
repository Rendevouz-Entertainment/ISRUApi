using KSP.Sim;
using KSP.Sim.Definitions;

namespace ISRUApi.Modules;

[Serializable]
public class Data_Mining: ModuleData
{
    public override Type ModuleType => typeof(Module_Mining);

    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(ExcludeFromContext = true)]
    public ModuleProperty<bool> CurrentDeployState = new ModuleProperty<bool>(false);
}