namespace Chess.Wpf;

public partial class MainWindow : Window
{
    public BoardViewModel Board { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        Board = new BoardViewModel();
    }

    private void Square_Click(object sender, MouseButtonEventArgs e)
    {
        var image = (Image)sender;
        var square = (SquareViewModel)image.DataContext;
        Board.HandleClick(square);
    }
}
