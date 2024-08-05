using StardewModdingAPI;
using StardewValley;
using StardewValley.TerrainFeatures;
using System.Linq;
using StardewModdingAPI.Events;
using Microsoft.Xna.Framework.Input;
using xTile.Tiles;
using xTile; 

public class ClearFarmMod : Mod
{
    private ModConfig Config;

    public override void Entry(IModHelper helper)
    {
        // Load the mod configuration
        Config = helper.ReadConfig<ModConfig>();

        helper.Events.Input.ButtonPressed += OnButtonPressed;
        helper.ConsoleCommands.Add("clear_farm", "Clears the farm of trees, bushes, rocks, weeds, stumps, logs, boulders, grass, and random event objects.", ClearFarm);
    }

    private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
    {
        // Check if the pressed key is the assigned clear farm key
        if (e.Button == Config.ClearFarmKey)
        {
            ClearFarm("clear_farm", null);
        }
    }

    private void ClearFarm(string command, string[] args)
    {
        var farm = Game1.getFarm();

        // Clear trees
        foreach (var tile in farm.terrainFeatures.Pairs.Where(p => p.Value is Tree).ToList())
        {
            farm.terrainFeatures.Remove(tile.Key);
        }
        
        // Clear bushes
        foreach (var tile in farm.largeTerrainFeatures.Where(f => f is Bush).ToList())
        {
            farm.largeTerrainFeatures.Remove(tile);
        }

        // Clear rocks, stumps, logs, and boulders
        foreach (var tile in farm.resourceClumps.ToList())
        {
            farm.resourceClumps.Remove(tile);
        }

        // Clear weeds and grass
        foreach (var tile in farm.terrainFeatures.Pairs.Where(p => p.Value is HoeDirt || p.Value is Grass).ToList())
        {
            farm.terrainFeatures.Remove(tile.Key);
        }

        // Clear rocks, stones, twigs, weeds, and debris
        foreach (var tile in farm.objects.Pairs.Where(p => p.Value.Name.Contains("Rock") || p.Value.Name.Contains("Stone") || p.Value.Name.Contains("Twig") || p.Value.Name.Contains("Bush") || p.Value.Name.Contains("Weed") || IsRandomEventObject(p.Value)).ToList())
        {
            farm.objects.Remove(tile.Key);
        }

        // Clear weeds (debris)
        foreach (var tile in farm.debris.ToList())
        {
            farm.debris.Remove(tile);
        }

        // Remove bushes from map tiles
        //ClearBushesFromMap(farm);

        Monitor.Log("Farm cleared of trees, bushes, rocks, weeds, stumps, logs, boulders, grass, and random event objects.", LogLevel.Info);
    }


    private bool IsBushTile(Tile tile)
    {
        // Replace these indices with the actual tile indices for bushes from the guide
        int[] bushTileIndices = { 0, 18, 19, 16, 18, 20, 22, 24, 313,314,315, 316, 317, 318, 402, 412, 414, 416, 417, 418 , 674, 675, 676, 677, 678, 679, 750, 771, 770, 784, 785, 786, 792, 793, 794, 882,883, 884 }; // Example indices
        return bushTileIndices.Contains(tile.TileIndex);
    }



    private bool IsRandomEventObject(StardewValley.Object obj)
    {
        // Check if the object is a random event object such as a meteorite or alien artifact
        return obj.Name == "Meteorite" || obj.Name == "Iridium Ore";
    }
}

public class ModConfig
{
    public SButton ClearFarmKey { get; set; } = SButton.C;
}
