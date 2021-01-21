using System;
using System.Collections.Generic;
using System.Linq;
using Kentico.Kontent.Delivery.Abstractions;

namespace Jamstack.On.Dotnet.Models
{
    public partial class Root
    {
        public IEnumerable<Shortcut> ShortcutsTyped => Shortcuts.OfType<Shortcut>();
    }
}