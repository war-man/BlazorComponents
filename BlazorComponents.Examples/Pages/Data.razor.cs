using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Examples.Pages
{
    public class DataModel : LayoutComponentBase
    {
        public class Search
        {
            public string Value { get; set; }
        }

        public string SearchText { get; set; } = string.Empty;

        public Task OnSearch(ChangeEventArgs arg)
        {
            SearchText = (string)arg.Value;
            return Task.Run(() => InvokeAsync(StateHasChanged));
        }

        public class ExampleItem
        {
            [Display(Name = "Código")]
            public int Id { get; set; }

            [Display(Name = "Nome")]
            public string Name { get; set; }

            [Display(Name = "Data de Cadastro")]
            public DateTime CreatedOn { get; set; }
        }

        public List<ExampleItem> ExampleItems = new List<ExampleItem>();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            List<string> Names = new List<string>
            { "Amanda", "John", "Daniel", "Peter", "Marie", "Lizzie", "Martha", "Anna", "Jane", "Nancy" };

            for(int i = 1; i <= 10; i++)
            {
                ExampleItems.Add(new ExampleItem { Id = i, Name = Names[i-1], CreatedOn = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i) });
            }
        }
    }
}
