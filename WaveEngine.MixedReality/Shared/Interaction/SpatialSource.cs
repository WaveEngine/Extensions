﻿// Copyright © 2018 Wave Engine S.L. All rights reserved. Use is subject to license terms.

namespace WaveEngine.MixedReality.Interaction
{
    /// <summary>
    /// Specifies the kind of an interaction source.
    /// </summary>
    public enum SpatialSource
    {
        /// <summary>
        /// Unknow source.
        /// </summary>
        Other = 0,

        /// <summary>
        /// Gesture from the user's hand.
        /// </summary>
        Hand = 1,

        /// <summary>
        /// Recognize from the user's voice.
        /// </summary>
        Voice = 2,

        /// <summary>
        /// Recognize from the clicker's button.
        /// </summary>
        Controller = 3
    }
}
