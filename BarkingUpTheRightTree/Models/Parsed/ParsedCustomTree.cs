﻿using System;
using System.Collections.Generic;

namespace BarkingUpTheRightTree.Models.Parsed
{
    /// <summary>Represents a custom tree.</summary>
    /// <remarks>This is a version of <see cref="BarkingUpTheRightTree.Models.Converted.CustomTree"/> that uses <see cref="BarkingUpTheRightTree.Models.Parsed.ParsedTapperTimedProduct"/> and <see cref="BarkingUpTheRightTree.Models.Parsed.ParsedTimedProduct"/>.<br/>The reason this is done is so content packs can have tokens in place of the ids to call mod APIs to get the id (so JsonAsset items can be used for example).</remarks>
    public class ParsedCustomTree
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The name of the tree.</summary>
        public string Name { get; set; }

        /// <summary>The item the tree drops when using a tapper on it.</summary>
        public ParsedTapperTimedProduct TappedProduct { get; set; }

        /// <summary>The item the tree drops when it gets cut down.</summary>
        public string Wood { get; set; }

        /// <summary>Whether the tree drops sap when it gets cut down.</summary>
        public bool DropsSap { get; set; }

        /// <summary>The item to plant to grow the tree.</summary>
        public string Seed { get; set; }

        /// <summary>The items the tree can drop whenever it's shaken.</summary>
        public List<ParsedTimedProduct> ShakingProducts { get; set; }

        /// <summary>The tree will only get loaded if atleast one of the listed mods are present.</summary>
        public List<string> IncludeIfModIsPresent { get; set; }

        /// <summary>The tree will only get loaded if none of the listed mods are present.</summary>
        public List<string> ExcludeIfModIsPresent { get; set; }

        /// <summary>The item the tree drops when using the <see cref="BarkingUpTheRightTree.Tools.BarkRemover"/> tool on it.</summary>
        public ParsedTimedProduct BarkProduct { get; set; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="name">The name of the tree.</param>
        /// <param name="tappedProduct">The item the tree drops when using a tapper on it.</param>
        /// <param name="wood">The item the tree drops when it gets cut down.</param>
        /// <param name="dropsSap">Whether the tree drops sap when it gets cut down.</param>
        /// <param name="seed">The item to plant to grow the tree.</param>
        /// <param name="shakingProducts">The items the tree can drop whenever it's shaken.</param>
        /// <param name="includeIfModIsPresent">The tree will only get loaded if atleast one of the listed mods are present.</param>
        /// <param name="excludeIfModIsPresent">The tree will only get loaded if none of the listed mods are present.</param>
        /// <param name="barkProduct">The item the tree drops when using the <see cref="BarkingUpTheRightTree.Tools.BarkRemover"/> tool on it.</param>
        public ParsedCustomTree(string name, ParsedTapperTimedProduct tappedProduct, string wood, bool dropsSap, string seed, List<ParsedTimedProduct> shakingProducts, List<string> includeIfModIsPresent, List<string> excludeIfModIsPresent, ParsedTimedProduct barkProduct)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            TappedProduct = tappedProduct;
            Wood = wood ?? "-1";
            DropsSap = dropsSap;
            Seed = seed ?? "-1";
            ShakingProducts = shakingProducts ?? new List<ParsedTimedProduct>();
            IncludeIfModIsPresent = includeIfModIsPresent ?? new List<string>();
            ExcludeIfModIsPresent = excludeIfModIsPresent ?? new List<string>();
            BarkProduct = barkProduct;
        }
    }
}
