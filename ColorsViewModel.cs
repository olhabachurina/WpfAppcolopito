using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfAppcolopito
{
    public class ColorsViewModel : BaseInpc
    {
        private Color _colorFromСomponents;

        public BindingList<ColorСomponent> ColorСomponents { get; } = new BindingList<ColorСomponent>
            {
                new ColorСomponent("Alpha"),
                new ColorСomponent("Blue"),
                new ColorСomponent("Green"),
                new ColorСomponent("Red")
            };
        public ColorsViewModel()
        {
            ColorСomponents.ListChanged += OnСomponentsChanged;
        }

        private void OnСomponentsChanged(object? sender, ListChangedEventArgs e)
        {
            var alpha = ColorСomponents.Single(cc => string.Equals(cc.Name, "Alpha", StringComparison.OrdinalIgnoreCase));
            var blue = ColorСomponents.Single(cc => string.Equals(cc.Name, "Blue", StringComparison.OrdinalIgnoreCase));
            var green = ColorСomponents.Single(cc => string.Equals(cc.Name, "Green", StringComparison.OrdinalIgnoreCase));
            var red = ColorСomponents.Single(cc => string.Equals(cc.Name, "Red", StringComparison.OrdinalIgnoreCase));

            ColorFromСomponents = Color.FromArgb(
                alpha.IsEnabled ? alpha.Value : (byte)255,
                red.IsEnabled ? red.Value : (byte)0,
                green.IsEnabled ? green.Value : (byte)0,
                blue.IsEnabled ? blue.Value : (byte)0);
        }

        public Color ColorFromСomponents { get => _colorFromСomponents; set => Set(ref _colorFromСomponents, value); }
        public BindingList<Color> Colors { get; } = new BindingList<Color>();

        private RelayCommand<Color>? _addCommand;
        public RelayCommand<Color> AddCommand => _addCommand
            ??= new RelayCommand<Color>(color => Colors.Add(color), color => !Colors.Contains(color));

        private RelayCommand<Color>? _removeCommand;
        public RelayCommand<Color> RemoveCommand => _removeCommand
            ??= new RelayCommand<Color>(color => Colors.Remove(color), color => Colors.Contains(color));
    }
}
