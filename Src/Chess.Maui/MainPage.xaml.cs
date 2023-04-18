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

    protected override void OnSizeAllocated(double width, double height)
    {
        chessBoard.WidthRequest = Math.Min(width, height);
        base.OnSizeAllocated(width, height);
    }
}