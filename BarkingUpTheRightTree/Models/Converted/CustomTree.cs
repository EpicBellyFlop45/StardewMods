﻿using BarkingUpTheRightTree.Tools;
using Microsoft.Xna.Framework.Graphics;
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

        /// <summary>The id of the item the tree drops when it gets cut down.</summary>
        public int WoodId { get; }

        /// <summary>Whether the tree drops sap when it gets cut down.</summary>
        public bool DropsSap { get; }

        /// <summary>The id of the item to plant to grow the tree.</summary>
        public int SeedId { get; }

        /// <summary>The required tool level to cut down the tree.</summary>
        public int RequiredToolLevel { get; }

        /// <summary>Whether the tree turns into a stump in winter, like the mushroom tree.</summary>
        public bool IsStumpInWinter { get; }

        /// <summary>The items the tree can drop whenever it's shaken.</summary>
        public List<SeasonalTimedProduct> ShakingProducts { get; }

        /// <summary>The tree will only get loaded if atleast one of the listed mods are present.</summary>
        public List<string> IncludeIfModIsPresent { get; }

        /// <summary>The tree will only get loaded if none of the listed mods are present.</summary>
        public List<string> ExcludeIfModIsPresent { get; }

        /// <summary>The item the tree drops when using the <see cref="BarkRemover"/> tool on it.</summary>
        public TimedProduct BarkProduct { get; }

        /// <summary>The chance the tree has to grow a stage (at the start of each day) when it's unfertilised.</summary>
        public float UnfertilisedGrowthChance { get; }

        /// <summary>The chance the tree has to grow a stage (at the start of each day) when it's fertilised.</summary>
        public float FertilisedGrowthChance { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="id">The id of the tree.</param>
        /// <param name="name">The name of the tree.</param>
        /// <param name="texture">The texture for the tree.</param>
        /// <param name="tappedProduct">The item the tree drops when using a tapper on it.</param>
        /// <param name="woodId">The id of the item the tree drops when it gets cut down.</param>
        /// <param name="dropsSap">Whether the tree drops sap when it gets cut down.</param>
        /// <param name="seedId">The id of the item to plant to grow the tree.</param>
        /// <param name="requiredToolLevel">The required tool level to cut down the tree.</param>
        /// <param name="isStumpInWinter">Whether the tree turns into a stump in winter, like the mushroom tree.</param>
        /// <param name="shakingProducts">The items the tree can drop whenever it's shaken.</param>
        /// <param name="includeIfModIsPresent">The tree will only get loaded if atleast one of the listed mods are present.</param>
        /// <param name="excludeIfModIsPresent">The tree will only get loaded if none of the listed mods are present.</param>
        /// <param name="barkProduct">The item the tree drops when using the <see cref="BarkRemover"/> tool on it.</param>
        /// <param name="unfertilisedGrowthChance">The chance the tree has to grow a stage (at the start of each day) when it's unfertilised.</param>
        /// <param name="fertilisedGrowthChance">The chance the tree has to grow a stage (at the start of each day) when it's fertilised.</param>
        public CustomTree(int id, string name, Texture2D texture, TapperTimedProduct tappedProduct, int woodId, bool dropsSap, int seedId, int requiredToolLevel, bool isStumpInWinter, List<SeasonalTimedProduct> shakingProducts, List<string> includeIfModIsPresent, List<string> excludeIfModIsPresent, TimedProduct barkProduct, float unfertilisedGrowthChance, float fertilisedGrowthChance)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Texture = texture ?? throw new ArgumentNullException(nameof(texture));
            TappedProduct = tappedProduct;
            WoodId = woodId;
            DropsSap = dropsSap;
            SeedId = seedId;
            RequiredToolLevel = requiredToolLevel;
            IsStumpInWinter = isStumpInWinter;
            ShakingProducts = shakingProducts ?? new List<SeasonalTimedProduct>();
            IncludeIfModIsPresent = includeIfModIsPresent ?? new List<string>();
            ExcludeIfModIsPresent = excludeIfModIsPresent ?? new List<string>();
            BarkProduct = barkProduct;
            UnfertilisedGrowthChance = unfertilisedGrowthChance;
            FertilisedGrowthChance = fertilisedGrowthChance;
        }
    }
}
