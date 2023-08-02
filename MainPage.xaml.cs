using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupSizePosition
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            double width = double.Parse(txtWidth.Text);
            double height = double.Parse(txtHeight.Text);

            Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
            if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
            if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
            if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

            var popup = new PopupPage();
            popup.Size = new Size(double.Parse(txtWidth.Text), double.Parse(txtHeight.Text));
            popup.VerticalOptions = verticalOptions;
            popup.HorizontalOptions = horizontalOptions;
            Shell.Current.ShowPopup(popup);
        }
    }
}