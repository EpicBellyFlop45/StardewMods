﻿namespace BetterMixedSeeds
{
    /// <summary>Provides basic crop apis.</summary>
    public interface IApi
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Overrides the configuration file to foribly exclude crops.</summary>
        /// <param name="cropNames">The names of the crops to forcibly exclude.</param>
        /// <remarks>This should be used as a last resort by mod authors who have added hard to get, highly profitable crops which can't be implemented alongside BMS without destroying in-game economy.</remarks>
        public void ForceExcludeCrop(params string[] cropNames);
    }
}
