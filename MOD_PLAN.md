# JokerMod Plan

## Current scaffold

- Generated from `Alchyr/ModTemplate-StS2` using the `Slay the Spire 2 Character` template.
- Depends on `BaseLib` and targets STS2 mod manifest format with `.dll`, `.json`, and `.pck` output.
- The first pass uses Defect as the mechanical base: Defect strike/defend cards, `Zap`, `Dualcast`, and `CrackedCore`.

## Character concept

The Joker is a robot-derived wildcard character. The initial version should feel like Defect at floor 1, then become increasingly unstable by mixing rewards from the whole game.

Starting identity:

- Base: Defect-style automaton.
- Starting relics: all five character starter relics, plus `PrismaticGem`. The custom `Marked Deck` relic is currently disabled because the first in-game test locked up when entering a shop.
- Starting deck: one Strike and one Defend from each character, plus each character's non-basic starter cards.
- Main custom relic setup: start with the base game's `PrismaticGem` for cross-character card rewards. Add a cost-compensation relic later after the base Joker character is stable.

## Implementation checkpoints

1. Replace placeholder art and localization.
2. Confirm whether `PrismaticGem` already applies the full desired reward-pool behavior for the Joker.
3. Patch or hook card reward generation/cost modification so `Marked Deck` offsets Prismatic Shard's +1 off-color cost.
4. Decide whether the Joker keeps a small private card pool, has no private card pool, or uses curated cross-class synergies.
5. Test single-player first. Workshop comments for BaseLib currently mention multiplayer desync risks around saved custom card state, so multiplayer support should be treated as a separate pass.

## Open implementation details

- The exact card reward hook needs to be confirmed against the current STS2 assemblies or BaseLib hooks because the game is still Early Access and mod APIs are moving.
- If all-character rewards are too noisy, a weighted pool may be better: mostly current character cards, with guaranteed off-class options after elites/bosses.
