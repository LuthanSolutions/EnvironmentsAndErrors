namespace EnvironmentsAndErrors.Pages;

using Microsoft.AspNetCore.Components.Web;

public partial class Index
{
    private ErrorBoundary? errorBoundary;

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();

}
