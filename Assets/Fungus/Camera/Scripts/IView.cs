﻿using UnityEngine;
using System.Collections;

namespace Fungus
{
    /// <summary>
    /// Defines a camera view point.
    /// The position and rotation are specified using the game object's transform, so this class only needs to specify the ortographic view size.
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Orthographic size of the camera view in world units.
        /// </summary>
        float ViewSize { get; set; }

        /// <summary>
        /// Aspect ratio of the primary view rectangle. e.g. a 4:3 aspect ratio = 1.333.
        /// </summary>
        Vector2 PrimaryAspectRatio { get; set; }

        /// <summary>
        /// Aspect ratio of the secondary view rectangle. e.g. a 2:1 aspect ratio = 2/1 = 2.0.
        /// </summary>
        Vector2 SecondaryAspectRatio { get; set; }
    }
}