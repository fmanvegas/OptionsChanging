using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Options
{
 
    public class BaseOption : PropChange
    {
        public bool Visible { get => _vis; set { _vis = value; OnPropertyChanged(); } }
        private bool _vis;

        public Color LineColor { get => _lineColor; set { _lineColor = value; OnPropertyChanged(); } }
        private Color _lineColor = Colors.Blue;

        public bool Selected { get => _sel; set { _sel = value; OnPropertyChanged(); } }
        private bool _sel;

        public Color SelectedColor { get => _selectedColor; set { _selectedColor = value; OnPropertyChanged(); } }
        private Color _selectedColor = Colors.Red;
    }


    public class IndividualOption : BaseOption
    {
        private OVR3 oVR3;

        public IndividualOption(OVR3 o)
        {
          
        }

       
    }

    public abstract class CategoryOption : BaseOption
    {
       
    }
    public class LineOption : CategoryOption
    {

    }
    public class TextOption : CategoryOption
    {

    }

    public class OvrOption : BaseOption
    {
        public LineOption LineOptions { get; set; } = new LineOption();
        public TextOption TextOptions { get; set; } = new TextOption();
    }

    public class PropChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
