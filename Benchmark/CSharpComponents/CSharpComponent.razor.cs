using Microsoft.AspNetCore.Components.Rendering;

namespace CSharpComponents
{
    public partial class CSharpComponent
    {
        int count = 0;

        void Increase()
        {
            count++;
        }

        public void Build()
        {
            using var builder = new RenderTreeBuilder();
            BuildRenderTree(builder);
        }
    }
}
