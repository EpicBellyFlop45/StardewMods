﻿using BarkingUpTheRightTree.Models.Converted;

namespace BarkingUpTheRightTree.Models.Parsed
{
    /// <summary>Represents a product that a tree drops within specified seasons.</summary>
    /// <remarks>This is a version of <see cref="SeasonalTimedProduct"/> that inherits from <see cref="ParsedTimedProduct"/> because <see cref="ParsedTimedProduct.ProductId"/> is <see langword="string"/>.<br/>The reason this is done is so content packs can have tokens in place of the ids to call mod APIs to get the id (so JsonAsset items can be used for example).</remarks>
    public class ParsedSeasonalTimedProduct : ParsedTimedProduct
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The seasons the product can drop from (<see langword="null"/> for all seasons).</summary>
        public string[] Seasons { get; set; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="daysBetweenProduce">The number of days inbetween the product dropping.</param>
        /// <param name="product">The product that will drop.</param>
        /// <param name="amount">The amount of product that will be produced.</param>
        /// <param name="seasons">The seasons the product can drop from (<see langword="null"/> for all seasons).</param>
        public ParsedSeasonalTimedProduct(int daysBetweenProduce, string product, int amount, string[] seasons)
            : base(daysBetweenProduce, product, amount)
        {
            if (seasons == null || seasons.Length == 0)
                seasons = new[] { "spring", "summer", "fall", "winter" };

            Seasons = seasons;
        }
    }
}
