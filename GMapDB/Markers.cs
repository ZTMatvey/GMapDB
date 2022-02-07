using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using static GMapDB.Program;

namespace GMapDB
{
    internal sealed class Markers
    {
        private readonly GMapOverlay m_markersOverlay = new GMapOverlay("markers");
        public GMapOverlay MarkersOverlay { get => m_markersOverlay; }
        public event MarkerEvent MarkerCreated;
        public Markers(GMapControl gMapControl)
        {
            gMapControl.Overlays.Add(m_markersOverlay);
        }
        public void CreateMarker(double lat, double lng)
        {
            var pointLatLng = new PointLatLng(lat, lng);
            CreateMarker(pointLatLng);
        }
        public void CreateMarker(PointLatLng latlng)
        {
            CreateMarker(latlng, string.Empty);
        }
        public void CreateMarker(PointLatLng latlng, string name)
        {
            var marker = new MarkerEntity(latlng) { Name = name };
            m_markersOverlay.Markers.Add(marker);
            var e = new MarkerEventArgs(marker);
            MarkerCreated?.Invoke(this, e);
        }
        public void DeleteMarker(GMapMarker marker)
        {
            m_markersOverlay.Markers.Remove(marker);
        }
    }
}
