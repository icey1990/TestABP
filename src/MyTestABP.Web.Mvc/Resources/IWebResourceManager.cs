using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace MyTestABP.Web.Resources
{
    public interface IWebResourceManager
    {
        void AddScript(string url, bool addMinifiedOnProd = true);

        IReadOnlyList<string> GetScripts();

        HelperResult RenderScripts();
    }
}
