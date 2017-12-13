using System;

namespace Microsoft.AspNetCore.Diagnostics.Elm.RazorViews
{
    public class DetailsPageModel
    {
        public ActivityContext Activity { get; set; }

        public ViewOptions Options { get; set; }
    }
}