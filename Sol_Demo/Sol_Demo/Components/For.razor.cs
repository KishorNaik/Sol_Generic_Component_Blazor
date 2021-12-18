using Microsoft.AspNetCore.Components;

namespace Sol_Demo.Components
{
    public partial class For<T>
    {
        [Parameter]
        public List<T>? In { get; set; }

        [Parameter]
        public RenderFragment<T>? ChildContent { get; set; }
    }
}