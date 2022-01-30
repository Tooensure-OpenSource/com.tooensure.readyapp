using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Types
{
    /// <summary>
    /// Creating auth type enum will specify what type if authentication the user wishes to authenticate themselves.
    /// </summary>
    public enum AuthType
    {
        none,
        ready,
        google,
        facebook
    }
}
