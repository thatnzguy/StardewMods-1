using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley;

namespace Pathoschild.Stardew.DataMaps.Framework
{
    /// <summary>Provides metadata to display in the overlay.</summary>
    internal interface IDataMap
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The map's display name.</summary>
        string Name { get; }

        /// <summary>The number of ticks between each update.</summary>
        int UpdateTickRate { get; }

        /// <summary>Whether to update the map when the set of visible tiles changes.</summary>
        bool UpdateWhenVisibleTilesChange { get; }

        /// <summary>The legend entries to display.</summary>
        LegendEntry[] Legend { get; }


        /*********
        ** Methods
        *********/
        /// <summary>Get the updated data map tiles.</summary>
        /// <param name="location">The current location.</param>
        /// <param name="visibleArea">The tiles currently visible on the screen.</param>
        /// <param name="cursorTile">The tile position under the cursor.</param>
        IEnumerable<TileGroup> Update(GameLocation location, Rectangle visibleArea, Vector2 cursorTile);
    }
}
