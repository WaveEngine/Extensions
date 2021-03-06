﻿// Copyright © 2018 Wave Engine S.L. All rights reserved. Use is subject to license terms.

#region Using Statements
using OculusWrap;
using WaveEngine.Common.Input;
#endregion

namespace WaveEngine.OculusRift.Input
{
    /// <summary>
    /// Holds the state of the Oculus Remote.
    /// </summary>
    public class OculusRemoteState : IController
    {
        /// <summary>
        /// The D-Pad up button.
        /// </summary>
        public ButtonState Up;

        /// <summary>
        /// The D-Pad down button.
        /// </summary>
        public ButtonState Down;

        /// <summary>
        /// The D-Pad left button.
        /// </summary>
        public ButtonState Left;

        /// <summary>
        /// The D-Pad right button.
        /// </summary>
        public ButtonState Right;

        /// <summary>
        /// The D-Pad central button.
        /// </summary>
        public ButtonState Start;

        /// <summary>
        /// The back button.
        /// </summary>
        public ButtonState Back;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        public bool IsConnected { get; set; }

        /// <summary>
        /// Updates the state of the buttons in the Remote
        /// </summary>
        /// <param name="hmd">The HMD handler</param>
        internal void Update(Hmd hmd)
        {
            OVRTypes.InputState inputState = hmd.GetInputState(OVRTypes.ControllerType.Remote);

            this.IsConnected = inputState.ControllerType == OVRTypes.ControllerType.Remote;

            this.Up = (inputState.Buttons & (uint)OVRTypes.Button.Up) != 0 ? ButtonState.Pressed : ButtonState.Released;
            this.Down = (inputState.Buttons & (uint)OVRTypes.Button.Down) != 0 ? ButtonState.Pressed : ButtonState.Released;
            this.Left = (inputState.Buttons & (uint)OVRTypes.Button.Left) != 0 ? ButtonState.Pressed : ButtonState.Released;
            this.Right = (inputState.Buttons & (uint)OVRTypes.Button.Right) != 0 ? ButtonState.Pressed : ButtonState.Released;
            this.Start = (inputState.Buttons & (uint)OVRTypes.Button.Enter) != 0 ? ButtonState.Pressed : ButtonState.Released;
            this.Back = (inputState.Buttons & (uint)OVRTypes.Button.Back) != 0 ? ButtonState.Pressed : ButtonState.Released;
        }

        /// <summary>
        /// Updates generic controller state.
        /// </summary>
        /// <param name="gamePad">The gamepad</param>
        internal void ToGamePadState(out GamePadState gamePad)
        {
            gamePad = default(GamePadState);

            if (this.IsConnected)
            {
                gamePad.IsConnected = true;

                gamePad.DPad.Up = this.Up;
                gamePad.DPad.Down = this.Down;
                gamePad.DPad.Left = this.Left;
                gamePad.DPad.Right = this.Right;
                gamePad.Buttons.A = this.Start;
                gamePad.Buttons.B = this.Back;
            }
        }
    }
}
