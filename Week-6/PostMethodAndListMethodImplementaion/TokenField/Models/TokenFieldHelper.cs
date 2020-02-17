using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenField.Models
{
    public static class TokenFieldHelper
    {
        public static MvcHtmlString TokenField(this HtmlHelper helper, string id, string values)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("id", id);
            tb.Attributes.Add("value", values);
            string result = "<script>$('#"+id+ "').tokenfield({autocomplete:{source: ['red', 'blue', 'green', 'yellow', 'violet', 'brown', 'purple', 'black', 'white'],delay: 100},showAutocompleteOnFocus: true})</script>";
            result = tb.ToString() + result;
            return new MvcHtmlString(result);
        }
    }
}