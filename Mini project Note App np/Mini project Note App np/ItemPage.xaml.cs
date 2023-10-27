using Microsoft.Maui.Controls;

namespace Mini_project_Note_App_np
{
    public partial class ItemPage : ContentPage
    {
        public string headerText { get; set; } = "text";
        public ItemPage(string item) 
        {
            InitializeComponent();
            headerText = item;
            Label.Text = headerText;
        }

        public void back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
