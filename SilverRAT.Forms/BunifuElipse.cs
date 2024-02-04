using System;
using System.Windows.Forms;

namespace SilverRAT.Forms
{
    internal class BunifuElipse
    {
        public int ElipseRadius { get; internal set; }
        public Panel TargetControl { get; internal set; }

        public static implicit operator BunifuElipse(Bunifu.Framework.UI.BunifuElipse v) => throw new NotImplementedException();
    }
}