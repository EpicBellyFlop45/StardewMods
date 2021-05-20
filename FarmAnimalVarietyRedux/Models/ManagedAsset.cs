﻿using Microsoft.Xna.Framework;
using StardewModdingAPI;
using System;

namespace FarmAnimalVarietyRedux.Models
{
    /// <summary>Represents an asset that's being manager through <see cref="AssetManager"/>.</summary>
    public class ManagedAsset
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The internal name of the animal the sprite sheet is for.</summary>
        public string InternalAnimalName { get; }

        /// <summary>The internal name of the subtype the sprite sheet is for.</summary>
        public string InternalAnimalSubtypeName { get; }

        /// <summary>Whether the sprite sheet is for the baby version of the animal.</summary>
        public bool IsBaby { get; }

        /// <summary>Whether the sprite sheet is for the harvested version of the animal.</summary>
        public bool IsHarvested { get; }

        /// <summary>The season the sprite sheet is for of the animal.</summary>
        public string Season { get; }

        /// <summary>Whether the asset is a shop icon.</summary>
        public bool IsShopIcon { get; }

        /// <summary>The path to the sprite sheet relative to <see cref="ContentPackAssetOwner"/>.</summary>
        public string RelativeTexturePath { get; }

        /// <summary>The source rectangle of the shop icon.</summary>
        public Rectangle? SourceRectangle { get; }

        /// <summary>The content pack that owns the asset.</summary>
        public IContentPack ContentPackAssetOwner { get; }

        /// <summary>Whether the asset is from the game content.</summary>
        public bool IsGameContent { get; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="internalAnimalName">The internal name of the animal the sprite sheet is for.</param>
        /// <param name="relativeTexturePath">The path to the sprite sheet relative to the game content folder.</param>
        /// <param name="sourceRectangle">The source rectangle of the shop icon.</param>
        public ManagedAsset(string internalAnimalName, string relativeTexturePath, Rectangle sourceRectangle)
        {
            IsShopIcon = true;
            InternalAnimalName = internalAnimalName;
            RelativeTexturePath = relativeTexturePath;
            SourceRectangle = sourceRectangle;
            IsGameContent = true;
        }

        /// <summary>Constructs an instance.</summary>
        /// <param name="internalAnimalName">The internal name of the animal the sprite sheet is for.</param>
        /// <param name="relativeTexturePath">The path to the shop icon relative to <paramref name="contentPackAssetOwner"/>.</param>
        /// <param name="contentPackAssetOwner">The content pack that owns the asset.</param>
        public ManagedAsset(string internalAnimalName, string relativeTexturePath, IContentPack contentPackAssetOwner)
        {
            IsShopIcon = true;
            InternalAnimalName = internalAnimalName;
            RelativeTexturePath = relativeTexturePath;
            ContentPackAssetOwner = contentPackAssetOwner;
        }
        
        /// <summary>Constructs an instance.</summary>
        /// <param name="internalAnimalName">The internal name of the animal the sprite sheet is for.</param>
        /// <param name="internalAnimalSubtypeName">The internal name of the subtype the sprite sheet is for.</param>
        /// <param name="isBaby">Whether the sprite sheet is for the baby version of the animal.</param>
        /// <param name="isHarvested">Whether the sprite sheet is for the harvested version of the animal.</param>
        /// <param name="season">The season the sprite sheet is for of the animal.</param>
        /// <param name="relativeTexturePath">The path to the sprite sheet relative to the game content folder.</param>
        public ManagedAsset(string internalAnimalName, string internalAnimalSubtypeName, bool isBaby, bool isHarvested, string season, string relativeTexturePath)
        {
            InternalAnimalName = internalAnimalName;
            InternalAnimalSubtypeName = internalAnimalSubtypeName;
            IsBaby = isBaby;
            IsHarvested = isHarvested;
            Season = season;
            RelativeTexturePath = relativeTexturePath;
            IsGameContent = true;
        }

        /// <summary>Constructs an instance.</summary>
        /// <param name="internalAnimalName">The internal name of the animal the sprite sheet is for.</param>
        /// <param name="internalAnimalSubtypeName">The internal name of the subtype the sprite sheet is for.</param>
        /// <param name="isBaby">Whether the sprite sheet is for the baby version of the animal.</param>
        /// <param name="isHarvested">Whether the sprite sheet is for the harvested version of the animal.</param>
        /// <param name="season">The season the sprite sheet is for of the animal.</param>
        /// <param name="relativeTexturePath">The path to the sprite sheet relative to <paramref name="contentPackAssetOwner"/>.</param>
        /// <param name="contentPackAssetOwner">The content pack that owns the asset.</param>
        public ManagedAsset(string internalAnimalName, string internalAnimalSubtypeName, bool isBaby, bool isHarvested, string season, string relativeTexturePath, IContentPack contentPackAssetOwner)
        {
            if (string.IsNullOrEmpty(internalAnimalName))
                throw new ArgumentException("Cannot be null or empty", nameof(internalAnimalName));

            if (string.IsNullOrEmpty(internalAnimalSubtypeName))
                throw new ArgumentException("Cannot be null or empty", nameof(internalAnimalSubtypeName));

            InternalAnimalName = internalAnimalName;
            InternalAnimalSubtypeName = internalAnimalSubtypeName;
            IsBaby = isBaby;
            IsHarvested = isHarvested;
            Season = season;
            RelativeTexturePath = relativeTexturePath;
            ContentPackAssetOwner = contentPackAssetOwner;
        }
    }
}