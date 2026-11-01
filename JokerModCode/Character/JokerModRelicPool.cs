using BaseLib.Abstracts;
using Godot;
using JokerMod.JokerModCode.Extensions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.RelicPools;
using MegaCrit.Sts2.Core.Models.Relics;

namespace JokerMod.JokerModCode.Character;

public class JokerModRelicPool : CustomRelicPoolModel
{
    public override Color LabOutlineColor => JokerMod.Color;

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();

    protected override RelicModel[] GenerateAllRelics()
    {
        return ModelDb.RelicPool<IroncladRelicPool>().AllRelics
            .Concat(ModelDb.RelicPool<SilentRelicPool>().AllRelics)
            .Concat(ModelDb.RelicPool<DefectRelicPool>().AllRelics)
            .Concat(ModelDb.RelicPool<NecrobinderRelicPool>().AllRelics)
            .Concat(ModelDb.RelicPool<RegentRelicPool>().AllRelics)
            .ToArray();
    }
}
