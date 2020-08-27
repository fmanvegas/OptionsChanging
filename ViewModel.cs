using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class ViewModel : PropChange
    {
        private OVR3 ovr = new OVR3();

        public OVR3 OVR
        {
            get { return ovr; }
            set { ovr =value; OnPropertyChanged(); }
        }

        public ObservableCollection<OVR3> OVRS { get; set; } = new ObservableCollection<OVR3>();


        internal void AddOVR()
        {

            OVRS.Add(new OVR3());
        }
    }
}
