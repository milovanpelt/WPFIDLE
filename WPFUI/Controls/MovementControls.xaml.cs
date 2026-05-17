using Engine.Models;
using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUI.Controls
{
    /// <summary>
    /// Interaction logic for MovementControls.xaml
    /// </summary>
    public partial class MovementControls : UserControl
    {
        public MovementControls()
        {
            InitializeComponent();
        }

        private void MoveNorth(object sender, RoutedEventArgs e)
        {
            Vector2 UpDirection = new Vector2(0, 1);
            MoveToLocation(UpDirection);
        }

        private void MoveSouth(object sender, RoutedEventArgs e)
        {
            Vector2 DownDirection = new Vector2(0, -1);
            MoveToLocation(DownDirection);
        }

        private void MoveEast(object sender, RoutedEventArgs e)
        {
            Vector2 RightDirection = new Vector2(1, 0);
            MoveToLocation(RightDirection);
        }

        private void MoveWest(object sender, RoutedEventArgs e)
        {
            Vector2 LeftDirection = new Vector2(-1, 0);
            MoveToLocation(LeftDirection);
        }

        private void MoveToLocation(Vector2 location)
        {
            GameSession? _gameSession = this.DataContext as GameSession;

            Location? newLocation = _gameSession?.CurrentWorld.LocationAt(location);

            if (newLocation != null)
            {
                _gameSession?.CurrentLocation = newLocation;
            }
        }
    }
}
