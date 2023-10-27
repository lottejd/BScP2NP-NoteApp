using static Microsoft.Maui.Controls.Button.ButtonContentLayout;
using static Microsoft.Maui.Controls.Button;

namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
        InitializeComponent();
        foreach (Button item in stackLayout.Children)
        {
            item.BackgroundColor = Color.FromRgb(60, 60, 60);
        }
        header.BackgroundColor = Color.FromRgb(60, 60, 60);
    }

    public void clickBtn(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            Navigation.PushAsync(new ItemPage(clickedButton.Text));
        }
        
    }

    public void Add(object sender, EventArgs e)
    {
        Button btn = new Button();
        btn.Text = "New note";
        btn.BackgroundColor = Color.FromRgb(60,60,60);
        btn.ImageSource = "trashbin.png";
        btn.Clicked += clickBtn;
        btn.ContentLayout = new ButtonContentLayout(ImagePosition.Right, 300);

        stackLayout.Children.Add(btn);
    }
}