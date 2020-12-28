﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace BarkingUpTheRightTree.Models.Converted
{
    /// <summary>Represents a custom tree.</summary>
    public class CustomTree
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The id of the tree.</summary>
        public int Id { get; }

        /// <summary>The name of the tree.</summary>
        public string Name { get; }

        /// <summary>The texture for the tree.</summary>
        public Texture2D Texture { get; }

        /// <summary>The item the tree drops when using a tapper on it.</summary>
        public TapperTimedProduct TappedProduct { get; }

        /// <summary>The item the tree drops when it gets cut down.</summary>
        public int Wood { get; }

        /// <summary>Whether the tree drops sap when it gets cut down.</summary>
        public bool DropsSap { get; }

        /// <summary>The item to plant to grow the tree.</summary>
        public int Seed { get; }

        /// <summary>The items the tree can drop whenever it's shaken.</summary>
        public List<TimedProduct> ShakingProducts { get; }

        /// <summary>The tree will only get loaded if atleast one of the listed mods are present.</summary>
        public List<string> IncludeIfModIsPresent { get; }

        /// <summary>The tree will only get loaded if none of the listed mods are present.</summary>
        public List<string> ExcludeIfModIsPresent { get; }

        /// <summary>The item the tree drops when using the <see cref="BarkingUpTheRightTree.Tools.BarkRemover"/> tool on it.</summary>
        public TimedProduct BarkProduct { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="id">The id of the tree.</param>
        /// <param name="name">The name of the tree.</param>
        /// <param name="texture">The texture for the tree.</param>
        /// <param name="tappedProduct">The item the tree drops when using a tapper on it.</param>
        /// <param name="wood">The item the tree drops when it gets cut down.</param>
        /// <param name="dropsSap">Whether the tree drops sap when it gets cut down.</param>
        /// <param name="seed">The item to plant to grow the tree.</param>
        /// <param name="shakingProducts">The items the tree can drop whenever it's shaken.</param>
        /// <param name="includeIfModIsPresent">The tree will only get loaded if atleast one of the listed mods are present.</param>
        /// <param name="excludeIfModIsPresent">The tree will only get loaded if none of the listed mods are present.</param>
        /// <param name="barkProduct">The item the tree drops when using the <see cref="BarkingUpTheRightTree.Tools.BarkRemover"/> tool on it.</param>
        public CustomTree(int id, string name, Texture2D texture, TapperTimedProduct tappedProduct, int wood, bool dropsSap, int seed, List<TimedProduct> shakingProducts, List<string> includeIfModIsPresent, List<string> excludeIfModIsPresent, TimedProduct barkProduct)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Texture = texture ?? throw new ArgumentNullException(nameof(texture));
            TappedProduct = tappedProduct;
            Wood = wood;
            DropsSap = dropsSap;
            Seed = seed;
            ShakingProducts = shakingProducts ?? new List<TimedProduct>();
            IncludeIfModIsPresent = includeIfModIsPresent ?? new List<string>();
            ExcludeIfModIsPresent = excludeIfModIsPresent ?? new List<string>();
            BarkProduct = barkProduct;
        }
    }
}
