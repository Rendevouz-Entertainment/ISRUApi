using KSP.Sim.impl;

namespace ISRUApi.Modules;

public class PartComponentModule_Mining: PartComponentModule
{
    public override Type PartBehaviourModuleType => typeof(Module_Mining);


    public override void OnStart(double universalTime)
    {
        base.OnStart(universalTime);
    }
}