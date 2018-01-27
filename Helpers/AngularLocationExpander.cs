using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;

namespace LoadTesting.Helpers
{
  public class AngularLocationExpander : IViewLocationExpander
  {
    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
      return new List<string>
      {
        "~/wwwroot/app/views/{1}/{0}.html",
        "~/wwwroot/app/{0}.html"
      };
    }

    public void PopulateValues(ViewLocationExpanderContext context) { }
  }
}