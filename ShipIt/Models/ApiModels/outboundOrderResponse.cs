namespace ShipIt.Models.ApiModels
{
    public class outboundOrderResponse :Response
    {
        public double Trucks { get; set; }

        //Empty constructor required for xml serialization.
        public TruckResponse( int numberOfTrucks)
        {
            Success= true;
            Trucks = numberOfTrucks;

        }
        public TruckResponse(){}
    }
}



