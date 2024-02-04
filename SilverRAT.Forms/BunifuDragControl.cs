using Bunifu.UI.WinForms;
using System;

namespace SilverRAT.Forms
{
    internal class BunifuDragControl
    {
        public bool Horizontal { get; internal set; }
        public bool Fixed { get; internal set; }
        public BunifuPanel TargetControl { get; internal set; }
        public bool Vertical { get; internal set; }

        public static implicit operator BunifuDragControl(Bunifu.Framework.UI.BunifuDragControl v) => throw new NotImplementedException();
    }
}