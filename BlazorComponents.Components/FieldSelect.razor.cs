using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorComponents.Components
{
    public class SelectModel : ComponentBase
    {
        public ElementReference ElemRef = new ElementReference("fieldtext-" + Guid.NewGuid());

        [Parameter] public Dictionary<int, string> Items { get; set; }

        private string _value;

        [Parameter]
        public string Value
        {
            get => _value ?? string.Empty;
            set { if (Value != value) _value = value; ValueChanged.InvokeAsync(value); }
        }

        [Parameter] public EventCallback<string> ValueChanged { get; set; }

        [Parameter] public string Label { get; set; }

        [Parameter] public bool Required { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> AdditionalAttributes { get; set; }

        [Parameter] public int Col { get; set; } = 12;

        public bool isFocus;

        protected void ToggleFocus() => isFocus = !isFocus;

        [Parameter] public string CssClass { get; set; }

    }
}
