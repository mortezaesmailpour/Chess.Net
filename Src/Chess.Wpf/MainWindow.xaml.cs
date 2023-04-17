using Chess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
