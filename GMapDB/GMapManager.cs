using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Windows.Forms;

namespace GMapDB
{
    internal sealed class GMapManager
    {
        private readonly GMapControl m_gMapControl;
        private double m_defaultLat;
        private double m_defaultLng;
        public GMapManager(GMapControl gMapControl, double defaultLat, double defaultLng)
        {
            m_gMapControl = gMapControl;
            m_defaultLat = defaultLat;
            m_defaultLng = defaultLng;
            Setup();
        }
        public void Setup()
        {
            m_gMapControl.MapProvider = GMapProviders.GoogleMap;
            m_gMapControl.MinZoom = 2;
            m_gMapControl.MaxZoom = 30;
            m_gMapControl.Zoom = 10;
            m_gMapControl.DragButton = MouseButtons.Left;
            MovePositioToDefault();
        }
        private void MovePositioToDefault()
        {
            m_gMapControl.Position = new global::GMap.NET.PointLatLng(m_defaultLat, m_defaultLng);
        }
    }
}
