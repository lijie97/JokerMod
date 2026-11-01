using BaseLib.Abstracts;
using Godot;
using JokerMod.JokerModCode.Extensions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.PotionPools;
using MegaCrit.Sts2.Core.Models.Potions;

namespace JokerMod.JokerModCode.Character;

public class JokerModPotionPool : CustomPotionPoolModel
{
    public override Color LabOutlineColor => JokerMod.Color;

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();

    protected override PotionModel[] GenerateAllPotions()
    {
        return ModelDb.PotionPool<IroncladPotionPool>().AllPotions
            .Concat(ModelDb.PotionPool<SilentPotionPool>().AllPotions)
            .Concat(ModelDb.PotionPool<DefectPotionPool>().AllPotions)
            .Concat(ModelDb.PotionPool<NecrobinderPotionPool>().AllPotions)
            .Concat(ModelDb.PotionPool<RegentPotionPool>().AllPotions)
            .ToArray();
    }
}
