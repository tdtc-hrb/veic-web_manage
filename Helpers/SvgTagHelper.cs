using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veic_web.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("svg", Attributes = "width, height")]
    public class SvgTagHelper : TagHelper
    {
        public string MyWidth { get; set; } = "1";
        public string MyHeight { get; set; } = "1";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("width", $"{MyWidth}em");
            output.Attributes.SetAttribute("height", $"{MyHeight}em");
        }
    }
}
