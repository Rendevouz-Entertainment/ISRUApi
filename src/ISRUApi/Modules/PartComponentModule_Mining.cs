using KSP.Sim.impl;

namespace ISRUApi.Modules;

public class PartComponentModule_Mining: PartComponentModule
{
    public override Type PartBehaviourModuleType => typeof(Module_Mining);

    private Data_Mining _dataMiningModule;


    public override void OnStart(double universalTime)
    {
        if (!DataModules.TryGetByType<Data_Mining>(out _dataMiningModule))
        {
            return;
        }

        _dataMiningModule.PartComponentModule = this;

        base.OnStart(universalTime);
    }
}