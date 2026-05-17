using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Engine.Models
{
    public partial class Location : ObservableObject
    {
        [ObservableProperty]
        public Vector2 position;

        [ObservableProperty]
        public string? name;

        [ObservableProperty]
        public string? description;

        [ObservableProperty]
        public string? imageName;
    }
}
