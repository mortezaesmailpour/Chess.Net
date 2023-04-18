namespace Chess.Maui;

public partial class MainPage : ContentPage
{
    public BoardViewModel Board { get; set; }
    public MainPage()
    {
        InitializeComponent();
        Board = new BoardViewModel();
        BindingContext = this;
    }
}