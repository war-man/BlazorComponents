using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorComponents.Components;

namespace BlazorComponents.Examples.Pages
{
    public class GeneralModel : LayoutComponentBase
    {
        public Modal ModalExample { get; set; }

        public string SearchText { get; set; } = string.Empty;
    }
}
