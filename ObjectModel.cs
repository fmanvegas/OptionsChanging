using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class OVR3 : PropChange
    {
        public ObservableCollection<MapObject> Lines { get; set; } = new ObservableCollection<MapObject>();
        public ObservableCollection<MapObject> Texts { get; set; } = new ObservableCollection<MapObject>();

        public string Name { get; }

        public OvrOption Options
        {
            get { return _options; }
            set { _options = value; OnPropertyChanged(); }
        }
        private OvrOption _options = new OvrOption();


        public OVR3()
        {
            Name = DateTime.Now.Millisecond.ToString();

            for (int x = 0; x < DateTime.Now.Second; x++)
                Texts.Add(new TextObject(x,this));
            for (int x = 0; x < DateTime.Now.Second; x++)
                Lines.Add(new LineObject(x,this));

        }

    }

    public abstract class MapObject : PropChange
    {
        public IndividualOption Options { get; internal set; }
        public string Name { get; internal set; }
    }

    public class LineObject : MapObject
    {
        public LineObject(int x, OVR3 o)
        {
            Name = $"Line {x + 1}";
            Options = new IndividualOption(o);
            o.Options.LineOptions.PropertyChanged += (a,b) => {
                Options.LineColor = o.Options.LineOptions.LineColor;

            };
        }
    }

    public class TextObject :MapObject
    {
        public TextObject(int x, OVR3 o)
        {
            Name = $"Text {x+1}";
            Options = new IndividualOption(o);
            o.Options.TextOptions.PropertyChanged += (sen, evt) =>
            {
                Options.LineColor = o.Options.TextOptions.LineColor;

            };
        }
    }
}
