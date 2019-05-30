using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace KenticoCommunity.GiphySelectorWidget
{
    public class GiphySelectorWidgetProperties : IWidgetProperties
    {
        public string Url { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Alternative text")]
        public string AlternativeText { get; set; }
    }
}
