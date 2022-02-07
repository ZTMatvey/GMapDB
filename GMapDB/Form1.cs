using GMap.NET.WindowsForms;
using System;
using System.Windows.Forms;
using System.Linq;

namespace GMapDB
{
    public sealed partial class Form1 : Form
    {
        private static readonly string s_connectionString = "Server=DESKTOP-M5K0C6P;Database=GMapDB;User Id='sa';Password='sa';Trusted_Connection=False;";
        private static readonly double s_defaultLat = 56.4977100;
        private static readonly double s_defaultLng = 84.9743700;
        private readonly GMapManager m_gMapManager;
        private readonly Markers m_markers;
        private readonly DBContext m_context;
        private readonly MapMarkerSelect m_mapMarkerSelect;
        public Form1()
        {
            InitializeComponent();
            m_gMapManager = new GMapManager(gMapControl, s_defaultLat, s_defaultLng);
            m_markers = new Markers(gMapControl);
            m_gMapManager.Setup();
            m_mapMarkerSelect = new MapMarkerSelect(gMapControl, m_markers);
            m_mapMarkerSelect.NewMarkerSelected += M_mapMarkerSelect_NewMarkerSelected;
            m_mapMarkerSelect.NoMarkerSelected += M_mapMarkerSelect_NoMarkerSelected;
            DisableAllMarkerInfo();
            m_context = new DBContext(s_connectionString);
            LoadData();
            FormClosing += (s, e) =>
            {
                var markers = m_markers.MarkersOverlay.Markers.Select(x=> (MarkerEntity)x).ToList();
                m_context.RewriteMarkers(markers);
            };
        }
        private async void LoadData()
        {
            var markers = await m_context.GetAllMarkers();
            foreach (var marker in markers)
            {
                m_markers.CreateMarker(marker.Position, marker.Name);
            }
        }
        private void M_mapMarkerSelect_NewMarkerSelected(object sender, MarkerEventArgs e)
        {
            markerNameTBox.Text = e.Marker.Name ?? string.Empty;
            markerNameTBox.Enabled = true;
            saveMarkerBtn.Enabled = true;
            deleteMarkerBtn.Enabled = true;
        }
        private void M_mapMarkerSelect_NoMarkerSelected(object sender, EventArgs e)
        {
            DisableAllMarkerInfo();
        }
        private void DisableAllMarkerInfo()
        {
            markerNameTBox.Text = string.Empty;
            markerNameTBox.Enabled = false;
            saveMarkerBtn.Enabled = false;
            deleteMarkerBtn.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var latConverted = double.TryParse(latTextBox.Text, out double lat);
            var lngConverted = double.TryParse(lngTextBox.Text, out double lng);
            if (latConverted && lngConverted)
            {
                m_markers.CreateMarker(lat, lng);
                return;
            }
            MessageBox.Show("Не удалось преобразовать введенные координаты");
        }
        private void gMapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var latlng = gMapControl.FromLocalToLatLng(e.X, e.Y);
            m_markers.CreateMarker(latlng);
        }
        private void gMapControl_MouseDown(object sender, MouseEventArgs e)
        {
            m_mapMarkerSelect.SelectMarker();
        }

        private void gMapControl_MouseUp(object sender, MouseEventArgs e)
        {
            var latlng = gMapControl.FromLocalToLatLng(e.X, e.Y);
            m_mapMarkerSelect.ChangeSelectedMarkerPosition(latlng);
        }

        private void saveMarkerBtn_Click(object sender, EventArgs e)
        {
            m_mapMarkerSelect.RenameMarker(markerNameTBox.Text);
        }

        private void deleteMarkerBtn_Click(object sender, EventArgs e)
        {
            m_mapMarkerSelect.DeleteMarker();
        }

        private void gMapControl_MouseMove(object sender, MouseEventArgs e)
        {
            m_mapMarkerSelect.Move();
        }
    }
}
