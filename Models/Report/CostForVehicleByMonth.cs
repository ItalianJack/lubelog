﻿namespace CarCareTracker.Models
{
    public class CostForVehicleByMonth
    {
        public int MonthId { get; set; }
        public string MonthName { get; set; }
        public decimal Cost { get; set; }
        public decimal DistanceTraveled { get; set; }
    }
}
