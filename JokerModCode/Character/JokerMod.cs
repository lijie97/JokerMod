using BaseLib.Abstracts;
using BaseLib.Utils.NodeFactories;
using JokerMod.JokerModCode.Extensions;
using Godot;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.CardPools;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.PotionPools;
using MegaCrit.Sts2.Core.Models.RelicPools;
using MegaCrit.Sts2.Core.Models.Relics;

namespace JokerMod.JokerModCode.Character;

public class JokerMod : PlaceholderCharacterModel
{
    public const string CharacterId = "JokerMod";
    
    public static readonly Color Color = new("00aaff");

    public override Color NameColor => Color;
    public override CharacterGender Gender => CharacterGender.Neutral;
    public override int StartingHp => 75;
    public override int MaxEnergy => 2;
    public override int BaseOrbSlotCount => 3;
    
    public override IEnumerable<CardModel> StartingDeck => [
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<Bash>(),
        ModelDb.Card<StrikeSilent>(),
        ModelDb.Card<DefendSilent>(),
        ModelDb.Card<Neutralize>(),
        ModelDb.Card<Survivor>(),
        ModelDb.Card<StrikeDefect>(),
        ModelDb.Card<DefendDefect>(),
        ModelDb.Card<Zap>(),
        ModelDb.Card<Dualcast>(),
        ModelDb.Card<StrikeNecrobinder>(),
        ModelDb.Card<DefendNecrobinder>(),
        ModelDb.Card<Bodyguard>(),
        ModelDb.Card<Unleash>(),
        ModelDb.Card<StrikeRegent>(),
        ModelDb.Card<DefendRegent>(),
        ModelDb.Card<FallingStar>(),
        ModelDb.Card<Venerate>()
    ];

    public override IReadOnlyList<RelicModel> StartingRelics =>
    [
        ModelDb.Relic<BurningBlood>(),
        ModelDb.Relic<RingOfTheSnake>(),
        ModelDb.Relic<CrackedCore>(),
        ModelDb.Relic<DivineRight>(),
        ModelDb.Relic<BoundPhylactery>(),
        ModelDb.Relic<PrismaticGem>()
    ];
    
    public override CardPoolModel CardPool => ModelDb.CardPool<JokerModCardPool>();
    public override RelicPoolModel RelicPool => ModelDb.RelicPool<JokerModRelicPool>();
    public override PotionPoolModel PotionPool => ModelDb.PotionPool<JokerModPotionPool>();
    
    /*  PlaceholderCharacterModel will utilize placeholder basegame assets for most of your character assets until you
        override all the other methods that define those assets. 
        These are just some of the simplest assets, given some placeholders to differentiate your character with. 
        You don't have to, but you're suggested to rename these images. */
    public override Control CustomIcon
    {
        get
        {
            var icon = NodeFactory<Control>.CreateFromResource(CustomIconTexturePath);
            icon.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
            return icon;
        }
    }
    public override string CustomIconTexturePath => "character_icon_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectIconPath => "char_select_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectLockedIconPath => "char_select_char_name_locked.png".CharacterUiPath();
    public override string CustomMapMarkerPath => "map_marker_char_name.png".CharacterUiPath();
}
