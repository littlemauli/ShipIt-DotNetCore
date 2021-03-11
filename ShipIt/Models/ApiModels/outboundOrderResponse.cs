namespace ShipIt.Models.ApiModels
{
    public class TruckResponse : Response
    {
        public double Trucks { get; set; }
       
        public TruckResponse( double numberOfTrucks)
        {
            Trucks = numberOfTrucks;
            Success = true;
        }
        public TruckResponse(){}
    }
}



