﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.DataObjects
{
    public class NodeActivityFlowReportMap : ClassMap<ActivityFlow>
    {
        public NodeActivityFlowReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.NodeName).Index(i); i++;
            Map(m => m.CallType).Index(i); i++;
            Map(m => m.CallDirection).Index(i); i++;
            Map(m => m.FromName).Index(i); i++;
            Map(m => m.FromType).Index(i); i++;
            Map(m => m.FromEntityID).Index(i); i++;
            Map(m => m.ToName).Index(i); i++;
            Map(m => m.ToType).Index(i); i++;
            Map(m => m.ToEntityID).Index(i); i++;
            Map(m => m.ART).Index(i); i++;
            Map(m => m.Calls).Index(i); i++;
            Map(m => m.CPM).Index(i); i++;
            Map(m => m.Errors).Index(i); i++;
            Map(m => m.EPM).Index(i); i++;
            Map(m => m.ErrorsPercentage).Index(i); i++;
            Map(m => m.From).Index(i); i++;
            Map(m => m.To).Index(i); i++;
            Map(m => m.FromUtc).Index(i); i++;
            Map(m => m.ToUtc).Index(i); i++;
            Map(m => m.Duration).Index(i); i++;
            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.NodeID).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.TierLink).Index(i); i++;
            Map(m => m.NodeLink).Index(i); i++;
            Map(m => m.FromLink).Index(i); i++;
            Map(m => m.ToLink).Index(i); i++;
            Map(m => m.MetricLink).Index(i); i++;
        }
    }
}