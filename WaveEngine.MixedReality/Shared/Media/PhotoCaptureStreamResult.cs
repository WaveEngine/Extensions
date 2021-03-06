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
    /// This class represent the result of a Take a photo using the Photo capture.
    /// </summary>
    public struct PhotoCaptureStreamResult
    {
        /// <summary>
        /// Gets the output stream.
        /// </summary>
        public Stream OutputStream { get; private set; }

        /// <summary>
        /// Gets a value indicating whether whether the photo was saved or not.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoCaptureStreamResult"/> struct.
        /// Initializes a new instance of the <see cref="PhotoCaptureResult"/> class.
        /// </summary>
        /// <param name="success">Whether the photo was saved or not.</param>
        /// <param name="outputStream">The output stream.</param>
        public PhotoCaptureStreamResult(bool success, Stream outputStream)
            : this()
        {
            this.Success = success;
            this.OutputStream = outputStream;
        }
    }
}
