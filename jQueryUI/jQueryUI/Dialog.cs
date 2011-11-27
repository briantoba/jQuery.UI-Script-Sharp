using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace JQueryUIApi
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("$.fn.dialog")]
    public class DialogObject : jQueryObject
    {
        [AlternateSignature]
        public extern DialogObject Dialog();

        [AlternateSignature]
        public extern DialogObject Dialog(string api);

        public extern DialogObject Dialog(DialogOptions options);
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class DialogButton
    {
        public string Text;
        public Action Click;
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class DialogOptions
    {
        [IntrinsicProperty]
        public bool Disabled { get; set; }

        [IntrinsicProperty]
        public bool AutoOpen { get; set; }

        [IntrinsicProperty]
        public Array Buttons { get; set; }

        [IntrinsicProperty]
        public bool CloseOnEscape { get; set; }

        [IntrinsicProperty]
        public String CloseText { get; set; }

        [IntrinsicProperty]
        public String DialogClass { get; set; }

        [IntrinsicProperty]
        public bool Draggable { get; set; }

        [IntrinsicProperty]
        public Object Height { get; set; }

        [IntrinsicProperty]
        public Object Hide { get; set; }

        [IntrinsicProperty]
        public Object MaxHeight { get; set; }

        [IntrinsicProperty]
        public Object MaxWidth { get; set; }

        [IntrinsicProperty]
        public int MinHeight { get; set; }

        [IntrinsicProperty]
        public int MinWidth { get; set; }

        [IntrinsicProperty]
        public bool Modal { get; set; }

        [IntrinsicProperty]
        public Object Position { get; set; }

        [IntrinsicProperty]
        public bool Resizable { get; set; }

        [IntrinsicProperty]
        public Object Show { get; set; }

        [IntrinsicProperty]
        public bool Stack { get; set; }

        [IntrinsicProperty]
        public String Title { get; set; }

        [IntrinsicProperty]
        public int Width { get; set; }

        [IntrinsicProperty]
        public int ZIndex { get; set; }

        [ScriptName("close")]
        public Action OnClose = null;

        [ScriptName("beforeclose")]
        public Action OnBeforeClose = null;
    }
}