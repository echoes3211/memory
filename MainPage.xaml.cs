using Microsoft.Maui.Controls;

namespace memory
{
    public partial class MainPage : ContentPage
    {
        private ImageButton[] cards;

        public MainPage()
        {
            InitializeComponent();

            cards = new ImageButton[]
            {
                new ImageButton {Source = "aaron.jpg"},
                new ImageButton {Source = "akif.jpg"},
                new ImageButton {Source = "suleyman.jpg"},
                new ImageButton {Source = "berdj.jpg"},
                new ImageButton {Source = "liam.jpg"},
                new ImageButton {Source = "youssef.jpg"},
            };

            int rows = 3;
            int columns = 4;
            int uniquePictures = cards.Length;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    int index = row * columns + column;
                    if (index < uniquePictures)
                    {
                        mainGrid.Children.Add(cards[index]);
                        Grid.SetRow(cards[index], row);
                        Grid.SetColumn(cards[index], column);
                    }
                    else
                    {
                        int duplicateIndex = (index - uniquePictures) % uniquePictures;
                        var duplicateImage = new ImageButton { Source = cards[duplicateIndex].Source };
                        mainGrid.Children.Add(duplicateImage);
                        Grid.SetRow(duplicateImage, row);
                        Grid.SetColumn(duplicateImage, column);
                    }
                }
            }
        }
    }
}
