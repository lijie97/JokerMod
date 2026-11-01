using BaseLib.Abstracts;
using Godot;
using JokerMod.JokerModCode.Extensions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.CardPools;
using MegaCrit.Sts2.Core.Models.Cards;

namespace JokerMod.JokerModCode.Character;

public class JokerModCardPool : CustomCardPoolModel
{
    public override string Title => JokerMod.CharacterId; //This is not a display name.

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();

    public override float H => 1f;
    public override float S => 1f;
    public override float V => 1f;

    public override Color DeckEntryCardColor => new("ffffff");

    public override bool IsColorless => false;

    protected override CardModel[] GenerateAllCards()
    {
        return ModelDb.CardPool<IroncladCardPool>().AllCards
            .Concat(ModelDb.CardPool<SilentCardPool>().AllCards)
            .Concat(ModelDb.CardPool<DefectCardPool>().AllCards)
            .Concat(ModelDb.CardPool<NecrobinderCardPool>().AllCards)
            .Concat(ModelDb.CardPool<RegentCardPool>().AllCards)
            .ToArray();
    }
}
