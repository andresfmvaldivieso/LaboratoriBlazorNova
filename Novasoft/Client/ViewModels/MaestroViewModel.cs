using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Novasoft.Client.Services;
using Novasoft.Server.Data;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components.Rendering;
using Radzen.Blazor.Rendering;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Radzen;
using Novasoft.Resources;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class MaestroViewModel : ComponentBase
    {

        #region Variables de Entorno
        [Inject]
        private IWebPaginasmaeServices webPaginasmaeServices { get; set; }
        [Inject]
        private IWebMaestrosgenServices webMaestrosgenServices { get; set; }
        [Inject]
        private IWebGridmaestroServices webGridmaestroServices { get; set; }
        [Parameter]
        public string codMae { get; set; }
        [Inject]
        private IGenDeptosServices genDeptosServices { get; set; }
        public IEnumerable<WebPaginasmae> tabsMaestro { get; set; } = new List<WebPaginasmae>();
        public WebMaestrosgen webMaestrosgen { get; set; } = new();

        public List<Tab> tabs = new List<Tab>();

        public Tab selectedTab;

        public bool isCollapsed = true;
        public bool value { get; set; }
        public int value1 { get; set; }
        #endregion

        protected override async Task OnParametersSetAsync()
        {
           // var codMaestros = Encryptor.Decrypt(codMae);
            query = new List<gen_deptos>();
            webMaestrosgen = await webMaestrosgenServices.GetWebMaestrosgen(Convert.ToInt16(codMae));
            tabsMaestro = await webPaginasmaeServices.GetWebPaginasmae(Convert.ToInt16(codMae));
            AnalizarFlagGrid();
            AddTabs();

            await base.OnParametersSetAsync();
        }


        public void AddTabs()
        {
            StateHasChanged();
            foreach (var tab in tabsMaestro)
            {
                tabs.Add(new Tab
                {
                    Text = $"{tab.NomPag}",
                    Content = builder =>
                    {
                        builder.OpenElement(10, "div");
                        builder.AddAttribute(11, "class", "form-group");

                        foreach (var item in tab.WebMaestros.OrderBy(x => x.PosxCmp).ThenBy(x => x.PosyCmp))
                        {
                            switch (item.TipCmp.Trim())
                            {
                                case "B":

                                    builder.OpenElement(0, "label");
                                    builder.AddAttribute(1, "for", "nombre");
                                    builder.AddAttribute(2, "class", "form-label");
                                    builder.AddContent(3, $"{item.NomCmp}");
                                    builder.CloseElement();

                                    builder.OpenElement(4, "input");
                                    builder.AddAttribute(5, "type", "text");
                                    builder.AddAttribute(6, "class", "form-input");
                                    builder.CloseElement();

                                    break;
                            }
                        }

                        builder.CloseElement();
                    }
                });
            }
            selectedTab = tabs.FirstOrDefault();
        }
        public Dictionary<WebPaginasmae, List<WebMaestro>> gridPag = new();

        private void AnalizarFlagGrid()
        {
            foreach (var tab in tabsMaestro)
            {
                var webMaestrosFiltrados = tab.WebMaestros.Where(input => input.TipCmp.Trim() == "G").ToList();
                if (webMaestrosFiltrados?.Count() > 0)
                {
                    foreach (var item in webMaestrosFiltrados)
                    {
                        string? input = item.KeyHlp;
                        string pattern = @"^(.*?)=";

                        Match match = Regex.Match(input, pattern);


                        if (match.Success)
                            item.KeyHlp = match.Groups[1].Value;
                    }
                    gridPag.Add(tab, webMaestrosFiltrados);
                }
            }
        }

        public void HandleTabSelected(Tab tab)
        {
            selectedTab = tab;
        }

        public void PaisDepartamentoCiudad((string, string, string) eventArgs) { }
        public string aa { get; set; }
        public void ToggleCollapse()
        {
            isCollapsed = !isCollapsed;
            StateHasChanged();
        }
        public string filtroGrid { get; set; }
        public IEnumerable<gen_deptos> query = new List<gen_deptos>();
        public List<(string,string)> columns = new List<(string, string)>();
        public async Task triggerGrid(WebMaestro webMaestro)
        {
            var assembly = typeof(Program).Assembly;
            Type type = assembly.GetType($"{webMaestro.TabHlp}");
            aa = webMaestro.TabHlp;

            columns = new();
            var columnas = await webGridmaestroServices.GetWebGridmaestro(webMaestro.CodMae);
            foreach (var item in columnas)
            {
                columns.Add((item.NomCmp,item.TitCmp));
            }
            var data = await genDeptosServices.GetDeptos();
            query = data.Where(x => x.cod_pai == filtroGrid);
            
        }
        
    }

    public class Tab
    {
        public string Text { get; set; }
        public RenderFragment Content { get; set; }
    }
}
