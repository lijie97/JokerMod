using BaseLib.Abstracts;
using BaseLib.Utils;
using JokerMod.JokerModCode.Character;

namespace JokerMod.JokerModCode.Potions;

[Pool(typeof(JokerModPotionPool))]
public abstract class JokerModPotion : CustomPotionModel;