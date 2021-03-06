﻿// Copyright © 2018 Wave Engine S.L. All rights reserved. Use is subject to license terms.

#region Using Statements
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#endregion

namespace WaveEngine.MixedReality.Media
{
    /// <summary>
    /// This class represent the result in some videocapture callbacks.
    /// </summary>
    public struct VideoCaptureStreamResult
    {
        /// <summary>
        /// Gets the output stream.
        /// </summary>
        public Stream OutputStream { get; private set; }

        /// <summary>
        /// Gets a value indicating whether whether the video was saved or not.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCaptureStreamResult"/> struct.
        /// Initializes a new instance of the <see cref="VideoCaptureStreamResult"/> class.
        /// </summary>
        /// <param name="success">Whether the video was saved or not.</param>
        /// <param name="outputStream">The output stream.</param>
        public VideoCaptureStreamResult(bool success, Stream outputStream)
            : this()
        {
            this.Success = success;
            this.OutputStream = outputStream;
        }
    }
}
