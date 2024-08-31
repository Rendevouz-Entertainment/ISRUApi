using KSP.Sim.Definitions;
using UnityEngine;

namespace ISRUApi.Modules;

[DisallowMultipleComponent]
public class Module_Mining : PartBehaviourModule
{
    public override Type PartComponentModuleType => typeof(PartComponentModule_Mining);

    [SerializeField]
    protected Data_Mining _dataMining;

    protected override void AddDataModules()
    {
        base.AddDataModules();
        _dataMining ??= new Data_Mining();
        DataModules.TryAddUnique(_dataMining, out _dataMining);
    }
}