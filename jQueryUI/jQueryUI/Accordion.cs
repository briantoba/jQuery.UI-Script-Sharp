using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace JQueryUIApi
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("$.fn.Accordion")]
    public class AccordionObject : jQueryObject
    {
        [AlternateSignature]
        public extern AccordionObject Accordion();

        [AlternateSignature]
        public extern AccordionObject Accordion(string api);

        public extern AccordionObject Accordion(AccordionOptions options);

        public extern AccordionObject Sortable(AccordionSortableOptions options);
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class AccordionHeaderOptions
    {
        [IntrinsicProperty]
        public string Header { get; set; }

        [IntrinsicProperty]
        public string HeaderSelected { get; set; }
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class AccordionSortableOptions
    {
        [IntrinsicProperty]
        public string Axis { get; set; }

        [IntrinsicProperty]
        public string Handle { get; set; }

        [IntrinsicProperty]
        public jQueryEventHandler Stop { get; set; }
    }

    [IgnoreNamespace]
    [ScriptName("Object")]
    [Imported]
    public sealed class AccordionOptions
    {
        [IntrinsicProperty]
        public bool Disabled { get; set; }

        [IntrinsicProperty]
        public int Active { get; set; }

        [IntrinsicProperty]
        public string Animated { get; set; }

        [IntrinsicProperty]
        public bool AutoHeight { get; set; }

        [IntrinsicProperty]
        public bool ClearStyle { get; set; }

        [IntrinsicProperty]
        public bool Collapsible { get; set; }

        [IntrinsicProperty]
        public string Event { get; set; }

        [IntrinsicProperty]
        public bool FillSpace { get; set; }

        [IntrinsicProperty]
        public string Header { get; set; }

        [IntrinsicProperty]
        public AccordionHeaderOptions Icons { get; set; }

        [IntrinsicProperty]
        public bool Navigation { get; set; }

        [IntrinsicProperty]
        public Action NavigationFilter { get; set; }
    }

}