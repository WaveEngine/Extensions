﻿// Copyright © 2018 Wave Engine S.L. All rights reserved. Use is subject to license terms.

#region Using Statements
using WaveEngine.Networking.Connection.Messages;
using WaveEngine.Networking.Players;
using WaveEngine.Networking.Server.Rooms;
#endregion

namespace WaveEngine.Networking.Server.Players
{
    /// <summary>
    /// This class represents a player from the server
    /// </summary>
    public class ServerPlayer : BaseSyncNetworkPlayer
    {
        #region Properties

        /// <summary>
        /// Gets the unique key identifier of a player.
        /// </summary>
        internal int ServerKey { get; private set; }

        /// <summary>
        /// Gets the network endpoint of the player
        /// </summary>
        public NetworkEndpoint Endpoint { get; private set; }

        /// <summary>
        /// Gets the server room where is the player. It is null if the player is in the lobby.
        /// </summary>
        public new ServerRoom Room
        {
            get
            {
                return (ServerRoom)base.Room;
            }
        }

        #endregion

        #region Initialize

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerPlayer" /> class.
        /// </summary>
        /// <param name="key">Internal unique key generated by the server to identify players</param>
        /// <param name="endpoint">The network endpoint of the player</param>
        public ServerPlayer(int key, NetworkEndpoint endpoint)
            : base()
        {
            this.ServerKey = key;
            this.Endpoint = endpoint;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Writes all the fields to an outgoing message.
        /// </summary>
        /// <param name="message">The outgoing message</param>
        internal void WriteToMessage(OutgoingMessage message)
        {
            this.CustomProperties.ForceFullSync();

            this.WriteToMessage(message, PlayerFliedsFlags.All);
        }

        #endregion
    }
}
