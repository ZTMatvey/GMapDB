using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapDB
{
    internal sealed class DBContext
    {
        private static readonly string s_getAllMarkers = "USE GMapDB SELECT * FROM Markers";
        private readonly string m_connectionString;

        public DBContext(string connectionString)
        {
            m_connectionString = connectionString;
        }
        public async Task<List<MarkerEntity>> GetAllMarkers()
        {
            using (var connection = new SqlConnection(m_connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(s_getAllMarkers, connection);
                var reader = await command.ExecuteReaderAsync();
                var markers = new List<MarkerEntity>();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        var lat = double.Parse(reader.GetValue(1).ToString());
                        var lng = double.Parse(reader.GetValue(2).ToString());
                        var name = reader.GetValue(3).ToString();
                        var position = new PointLatLng(lat, lng);
                        var marker = new MarkerEntity(position) { Name = name };
                        markers.Add(marker);
                    }
                }
                reader.Close();
                return markers;
            }
        }
        public async void RewriteMarkers(List<MarkerEntity> markerEntities)
        {
            using (var connection = new SqlConnection(m_connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand("USE GMapDB DELETE FROM Markers", connection);
                await command.ExecuteNonQueryAsync();
                var expression = new StringBuilder($"USE GMapDB INSERT INTO Markers (Latitude, Longitude, Name) VALUES");
                foreach (var marker in markerEntities)
                     expression.Append($" ({marker.Position.Lat}, {marker.Position.Lng}, '{marker.Name}'),");
                expression.Remove(expression.Length-1, 1);
                expression.Append(';');
                command = new SqlCommand(expression.ToString(), connection);
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
