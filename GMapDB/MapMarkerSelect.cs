using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Linq;
using System.Windows.Forms;
using static GMapDB.Program;

namespace GMapDB
{
    internal sealed class MapMarkerSelect
    {
        public event MarkerEvent NewMarkerSelected;
        public event EventHandler NoMarkerSelected;
        private readonly GMapControl m_gMapControl;
        private readonly Markers m_markers;
        private MarkerEntity m_selectedMarker;
        private bool m_isMarkerWasMoved;
        private int m_moveTime;
        public MapMarkerSelect(GMapControl gMapControl, Markers markers)
        {
            m_gMapControl = gMapControl;
            m_markers = markers;
            m_markers.MarkerCreated += M_markers_MarkerCreated;
        }

        private void M_markers_MarkerCreated(object sender, MarkerEventArgs e)
        {
            m_selectedMarker = e.Marker;
            OnNewMarkerSelected();
        }

        public void SelectMarker()
        {
            m_selectedMarker = (MarkerEntity)m_gMapControl.Overlays
            .SelectMany(o => o.Markers)
            .FirstOrDefault(m => m.IsMouseOver == true);
            if (m_selectedMarker != null)
                OnNewMarkerSelected();
            else
                OnNoMarkerSelected();
        }
        public void RemoveSelection()
        {
            m_isMarkerWasMoved = true;
            m_selectedMarker = null;
            OnNewMarkerSelected();
        }
        private void OnNewMarkerSelected()
        {
            m_moveTime = 0;
            m_isMarkerWasMoved = false;
            var e = new MarkerEventArgs(m_selectedMarker);
            NewMarkerSelected?.Invoke(this, e);
        }
        private void OnNoMarkerSelected()
        {
            NoMarkerSelected?.Invoke(this, EventArgs.Empty);
        }
        public void ChangeSelectedMarkerPosition(double lat, double lng)
        {
            var pointLatLng = new PointLatLng(lat, lng);
            ChangeSelectedMarkerPosition(pointLatLng);
        }
        public void ChangeSelectedMarkerPosition(PointLatLng latlng)
        {
            if (m_selectedMarker == null || m_isMarkerWasMoved || m_moveTime < 10)
                return;
            m_selectedMarker.Position = latlng;
            m_isMarkerWasMoved = true;
        }
        public void DeleteMarker()
        {
            if (m_selectedMarker == null)
                return;
            m_markers.DeleteMarker(m_selectedMarker);
            OnNoMarkerSelected();
        }
        public void RenameMarker(string newContent)
        {
            if (m_selectedMarker == null)
                return;
            m_selectedMarker.Name = newContent;
        }
        public void Move()=> m_moveTime++;
    }
}
