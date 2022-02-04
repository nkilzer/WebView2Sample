using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WebView2Sample;

public partial class Form1 : Form
{
    private CoreWebView2Environment _env;
    private WebView2? _popup;

    public Form1()
    {
        InitializeComponent();

        wvMain.CoreWebView2InitializationCompleted += HandleMainInitComplete;
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
        wvMain.Source = new(tbUrl.Text);
    }

    private async void CreateNewView(CoreWebView2NewWindowRequestedEventArgs e, CoreWebView2Deferral deferral)
    {
        _popup = new();
        _popup.CoreWebView2InitializationCompleted += HandlePopupInitComplete;
        _popup.Tag = new Context(e, deferral);
        _popup.Dock = DockStyle.Fill;

        pnlBorderPopup.Controls.Add(_popup);
        Update();

        await _popup.EnsureCoreWebView2Async(wvMain.CoreWebView2.Environment);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        tbUrl.Text = @"http://localhost:8025/TestDocFail.html";

        var userDataPath = Path.Combine(Path.GetTempPath(), @"wv2Sample_" + Path.GetRandomFileName().Replace(".", ""), "Env");
        _env = await CoreWebView2Environment.CreateAsync(userDataFolder: userDataPath);
        await wvMain.EnsureCoreWebView2Async(_env);
    }

    private void HandleMainClose(object? sender, object e)
    {
        lblMainStatus.Text = @"Close requested";
    }

    private void HandleMainFailed(object? sender, CoreWebView2ProcessFailedEventArgs e)
    {
        lblMainStatus.Text = string.Format(@"- {0} - Kind: {1}, Reason: {2}", e.ProcessDescription, e.ProcessFailedKind, e.Reason);
    }

    private void HandleMainInitComplete(object? sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        var wv = sender as CoreWebView2 ?? (sender as WebView2)?.CoreWebView2 ?? throw new InvalidOperationException(@"No Core Web View");
        wv.ProcessFailed += HandleMainFailed;
        wv.WindowCloseRequested += HandleMainClose;
        wv.NewWindowRequested += HandleMainNewWindow;
    }

    private void HandleMainNewWindow(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
        e.Handled = true;
        var deferral = e.GetDeferral();

        if (!Uri.TryCreate(e.Uri, UriKind.Absolute, out _))
        {
            deferral.Dispose();
            return;
        }

        CreateNewView(e, deferral);
    }

    private void HandlePopupClose(object? sender, object e)
    {
        lblMainStatus.Text = @"Close requested";
    }

    private void HandlePopupFailed(object? sender, CoreWebView2ProcessFailedEventArgs e)
    {
        lblPopupStatus.Text = string.Format(@"- {0} - Kind: {1}, Reason: {2}", e.ProcessDescription, e.ProcessFailedKind, e.Reason);
    }

    private void HandlePopupInitComplete(object? sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        var wv = sender as CoreWebView2 ?? (sender as WebView2)?.CoreWebView2 ?? throw new InvalidOperationException(@"No Core Web View");
        var (e2, deferral) = (Context)_popup.Tag;

        wv.ProcessFailed += HandlePopupFailed;
        wv.WindowCloseRequested += HandlePopupClose;

        e2.Handled = true;
        e2.NewWindow = wv;
        _popup.Source = new(e2.Uri);

        deferral.Complete();
    }

    private sealed record Context(CoreWebView2NewWindowRequestedEventArgs Args, CoreWebView2Deferral Deferral);
}