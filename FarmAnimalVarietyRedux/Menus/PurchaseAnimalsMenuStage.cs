﻿namespace FarmAnimalVarietyRedux.Menus
{
    /// <summary>The stages of the <see cref="CustomPurchaseAnimalsMenu"/>.</summary>
    public enum PurchaseAnimalsMenuStage
    {
        /// <summary>The initial stage of the menu, the player is choosing which animal to buy.</summary>
        PurchasingAnimal,

        /// <summary>The second stage of the menu, the player is choosing which building to put the animal in.</summary>
        HomingAnimal,

        /// <summary>The final stage of the menu, the player is choosing a name for the new animal.</summary>
        NamingAnimal
    }
}
