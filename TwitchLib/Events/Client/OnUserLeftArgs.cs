﻿namespace TwitchLib.Events.Client
{
    #region using directives
    using System;
    #endregion
    /// <summary>Args representing viewer left event.</summary>
    public class OnUserLeftArgs : EventArgs
    {
        /// <summary>Property representing username of user that left.</summary>
        public string Username;
        /// <summary>Property representing channel bot is connected to.</summary>
        public string Channel;
    }
}
