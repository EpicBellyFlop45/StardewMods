﻿using FarmAnimalVarietyRedux.Models;
using System.Collections.Generic;

namespace FarmAnimalVarietyRedux.EqualityComparers
{
    /// <summary>Defines how two <see cref="ManagedAsset"/>s should be compared.</summary>
    /// <remarks>This uses the <see cref="ManagedAsset.InternalAnimalName"/>, <see cref="ManagedAsset.InternalAnimalSubtypeName"/>, <see cref="ManagedAsset.IsBaby"/>, <see cref="ManagedAsset.IsHarvested"/>, <see cref="ManagedAsset.Season"/>, <see cref="ManagedAsset.IsShopIcon"/>, and <see cref="ManagedAsset.IsGameContent"/>.</remarks>
    internal class ManagedAssetEqualityComparer : IEqualityComparer<ManagedAsset>
    {
        /*********
        ** Public Methods
        *********/
        /// <inheritdoc/>
        public bool Equals(ManagedAsset x, ManagedAsset y) => x?.InternalAnimalName.ToLower() == y?.InternalAnimalName.ToLower()
                                                           && x?.InternalAnimalSubtypeName?.ToLower() == y?.InternalAnimalSubtypeName?.ToLower()
                                                           && x?.IsBaby == y?.IsBaby
                                                           && x?.IsHarvested == y?.IsHarvested
                                                           && x?.Season?.ToLower() == y?.Season?.ToLower()
                                                           && x?.IsShopIcon == y?.IsShopIcon
                                                           && x?.IsGameContent == y?.IsGameContent;

        /// <inheritdoc/>
        public int GetHashCode(ManagedAsset obj) => (obj?.InternalAnimalName.ToLower(), obj?.InternalAnimalSubtypeName.ToLower(), obj?.IsBaby, obj?.IsHarvested, obj?.Season.ToLower(), obj?.IsShopIcon, obj?.IsGameContent).GetHashCode();
    }
}
