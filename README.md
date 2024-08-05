# Clear Farm Debris Mod for Stardew Valley

## Overview

The Clear Farm Debris Mod allows you to easily clear your farm of unwanted debris such as trees, bushes, rocks, weeds, stumps, logs, boulders, grass, and random event objects. Additionally, this mod replaces the ground with plain dirt tiles, making it easier to manage your farm space.

The idea was inspired by my daughter.  She and I have modded our game so much and we cheat a lot and have a unique gameplay style with our selected mods.  She enjoys starting from scratch a lot and hates grinding on clearing her farm.

It only took like 15 minutes to put this together as I had a template to compile a modern 1.6.0 development environment ready to go and chat gpt wrote this entire thing practically with some smart prompts.

## Requirements

- Stardew Valley up to date
- [StardewModdingAPI (SMAPI)](https://smapi.io/)

## Features

- Clears all trees, bushes, rocks, weeds, stumps, logs, boulders, grass, and random event objects from your farm.
- Simple command-line interface to trigger the cleaning process.

## Installation

1. **Download and install SMAPI** if you haven't already.
2. **Download the Clear Farm Debris Mod** from the [GitHub repository](https://github.com/davidrenne/ClearFarmDebris).
3. **Extract the mod files** into your `Mods` folder within the Stardew Valley installation directory.

## Usage

### Command

To clear your farm, use the command:
```

### Customizing Key Binding

The default key binding for clearing the farm is set to `C`. If you wish to change the key binding, you can edit the `config.json` file located in the mod's directory. Open the `config.json` file and modify the `ClearFarmKey` to your preferred key.

Example `config.json`:
```json
{
    "ClearFarmKey": "C"
}

```

## Future Features

The current version focuses on clearing debris and replacing the ground with plain dirt tiles. In future updates, there may be options to overlay brick tiles and more in-town features based on user feedback. Stay tuned for more updates so longs as I get a few people interested in things like this I will add more commands to possibly clean up dirt or make all soil already tilled.  I really like my farms having nice stone paths or cement looking stuff.  Just takes time to layout.  I especially like all my tiles in town to also have gravel or stone paths vs. the default tiles that are in the game in town.  Its just very time consuming to place everything along walking paths.  So ideally I want all my saves to have a certain look or feel in common walking paths in town and around certain places, so in theory I could map out all these areas and provide a command line function to call with the type of tile you want to lay over the standard walking paths to suit your needs.

