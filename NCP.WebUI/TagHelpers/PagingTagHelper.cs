using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCP.WebUI.TagHelpers
{
    [HtmlTargetElement("list-paging")]
    public class PagingTagHelper: TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul class='pagination'>");
            for (int i = 1; i <= PageCount; i++)
            {
                //sb.Append("<li " + (i == CurrentPage ? "class='active'" : "") + ">");
                sb.AppendFormat("<li class='{0} page-item'>",i==CurrentPage?"active":"");
                sb.AppendFormat("<a class='page-link' href='/Home/Index?page={0}&category={1}'>{2}</a>",i,CurrentCategory,i);
                sb.Append("</li>");
            }
            sb.Append("</ul>");
            output.Content.SetHtmlContent(sb.ToString());      
            base.Process(context, output);
        }
    }
}
