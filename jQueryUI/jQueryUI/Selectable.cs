using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace JQueryUIApi
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("$.fn.selectable")]
    public class SelectableObject : jQueryObject
    {
        [AlternateSignature]
        public extern SelectableObject Selectable();

        [AlternateSignature]
        public extern SelectableObject Selectable(string api);

        public extern SelectableObject Selectable(SelectableOptions options);
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class SelectableOptions
    {
        [IntrinsicProperty]
        public bool Disabled { get; set; }

        [IntrinsicProperty]
        public bool AutoRefresh { get; set; }

        [IntrinsicProperty]
        public string Cancel { get; set; }

        [IntrinsicProperty]
        public int Delay { get; set; }

        [IntrinsicProperty]
        public int Distance { get; set; }

        [IntrinsicProperty]
        public string Filter { get; set; }

        [IntrinsicProperty]
        public string Tolerance { get; set; }
    }
}