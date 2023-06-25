using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Ls.Abp.SharedLib.CustomFilters
{
    public class HiddenApiFilter: IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var api in context.ApiDescriptions)
            {
                var attribute = api.CustomAttributes().OfType<HiddenApiAttribute>().FirstOrDefault();

                if (attribute != null)
                {
                    string key = "/" + api.RelativePath;
                    if (key.Contains("?"))
                    {
                        int idx = key.IndexOf("?", System.StringComparison.Ordinal);
                        key = key.Substring(0, idx);
                    }
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Method | System.AttributeTargets.Class)]
    public class HiddenApiAttribute : System.Attribute { }
}
