﻿namespace AppDynamics.Dexter
{
    public class JobOutput
    {
        public bool DetectedEntities { get; set; }
        public bool EntityMetrics { get; set; }
        public bool EntityMetricGraphs { get; set; }
        public bool EntityDetails { get; set; }
        public bool Snapshots { get; set; }
        public bool FlameGraphs { get; set; }
        public bool Configuration { get; set; }
        public bool Events { get; set; }
    }
}
