﻿// <auto-generated />

using System;
using System.Runtime.InteropServices;

namespace Noesis
{
    public class SoftwareKeyboard
    {
        /// <summary>
        /// Indicates if Software Keyboard is opened
        /// </summary>
        public bool IsOpen { get; protected set; }

        /// <summary>
        /// Called when a UI element gets the focus and software keyboard should be opened
        /// Should return true if software keyboard is supported and will be shown
        /// </summary>
        public virtual bool Show(UIElement focusedElement)
        {
            return false;
        }

        /// <summary>
        /// Called when UI element loses focus and software keyboard should be closed
        /// </summary>
        public virtual void Hide()
        {
        }

        /// <summary>
        /// Allows updating UI element contents with the software keyboard text
        /// </summary>
        public virtual void Update()
        {
        }
    }
}