﻿
using Nas.Core.Configuration;

namespace Nas.Plugin.SMS.Verizon
{
    public class VerizonSettings : ISettings
    {
        /// <summary>
        /// Gets or sets the value indicting whether this SMS provider is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the Verizon email
        /// </summary>
        public string Email { get; set; }
    }
}