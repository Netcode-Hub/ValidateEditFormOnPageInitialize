using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace ValidateEditFormOnPageInitialize
{
    public class CustomValidator : ComponentBase
    {
        [CascadingParameter]
        private EditContext myCustomContext { get; set; }

        protected override void OnParametersSet()
        {
            myCustomContext.Validate();
        }
    }
}
