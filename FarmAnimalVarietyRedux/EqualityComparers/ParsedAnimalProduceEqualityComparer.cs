﻿using FarmAnimalVarietyRedux.Models.Parsed;
using System.Collections.Generic;

namespace FarmAnimalVarietyRedux.EqualityComparers
{
    /// <summary>Defines how two <see cref="ParsedAnimalProduce"/>s should be compared.</summary>
    /// <remarks>This only uses the <see cref="ParsedAnimalProduce.UniqueName"/> and disregards every other property such as amount, etc.</remarks>
    internal class ParsedAnimalProduceEqualityComparer : IEqualityComparer<ParsedAnimalProduce>
    {
        /*********
        ** Public Methods
        *********/
        /// <inheritdoc/>
        public bool Equals(ParsedAnimalProduce x, ParsedAnimalProduce y) => x?.UniqueName.ToLower() == y?.UniqueName.ToLower();

        /// <inheritdoc/>
        public int GetHashCode(ParsedAnimalProduce obj) => (obj?.UniqueName).GetHashCode();
    }
}
