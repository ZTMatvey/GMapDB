using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapDB
{
    internal sealed class MarkerEntity: GMarkerGoogle
    {
        private bool m_isChanged;
        private string m_name;
        public string Name
        {
            get => m_name;
            set => m_name = value;
        }
        public bool IsChanged
        {
            get => m_isChanged;
        }
        public void Changed()
        {
            m_isChanged = true;
        }
        public MarkerEntity(PointLatLng position): base(position, GMarkerGoogleType.blue_dot)
        { }
    }
}
