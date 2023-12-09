namespace EnvironmentsAndErrors.Pages;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Popups;

public partial class Index
{
    private ErrorBoundary? errorBoundary;
    private static readonly DialogOptions dialogOptions = new()
    {
        Position = new PositionDataModel()
        {
            X = "center",
            Y = "center"
        },
        AllowDragging = true
    };

    [Inject]
    private SfDialogService? DialogService { get; set; }

    [CascadingParameter(Name = nameof(ConnectionStrings))]
    public ConnectionStrings? ConnectionStrings { get; set; }

    public IndexViewModel ViewModel { get; set; } = new();

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();

    private async Task ShowDialogClickedHandler()
    {
        await this.DialogService!.AlertAsync("Alert", "", dialogOptions);
        await Task.Delay(1);
        _ = await this.DialogService!.ConfirmAsync("Confirm", "", dialogOptions);
        await Task.Delay(1);
        _ = await this.DialogService!.PromptAsync("Prompt", "", dialogOptions);
        await Task.Delay(1);
        await this.DialogService!.AlertAsync("Alert", "", dialogOptions);
        await Task.Delay(1);
        _ = await this.DialogService!.ConfirmAsync("Confirm", "", dialogOptions);
    }
}
