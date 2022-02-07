using GMap.NET.WindowsForms;
using System;

namespace GMapDB
{
    internal sealed class MarkerEventArgs: EventArgs
    {
        public readonly MarkerEntity Marker;

        public MarkerEventArgs(MarkerEntity marker)
        {
            Marker = marker;
        }
    }
}
