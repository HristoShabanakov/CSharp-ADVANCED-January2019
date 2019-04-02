namespace StorageMaster.Models.Storages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using StorageMaster.Models.Vehicles;

    public class DistributionCenter : Storage
    {
        //Always has 2 capacity and 5 garage slots
        private const int DistributionCenterCapacity = 2;
        private const int DistributionCenterGarageSlots = 5;

        //Default vehicles: 3 Vans.
        private static Vehicle[] DefaultVehicles = {
            new Van(),
            new Van(),
            new Van()
        };
        public DistributionCenter(string name) 
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlots, DefaultVehicles)
        {
        }
    }
}
