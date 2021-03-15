using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using ShipIt.Exceptions;
using ShipIt.Models.ApiModels;

namespace ShipIt.Models.DataModels
{

    public class StockProductDataModel : DataModel
    {
        [DatabaseColumnName("p_id")]
        public int Id { get; set; }

        [DatabaseColumnName("gtin_cd")]
        public string Gtin { get; set; }

        [DatabaseColumnName("gcp_cd")]
        public string Gcp { get; set; }

        [DatabaseColumnName("gtin_nm")]
        public string Name { get; set; }

        [DatabaseColumnName("m_g")]
        public double Weight { get; set; }

        [DatabaseColumnName("l_th")]
        public int LowerThreshold { get; set; }

        [DatabaseColumnName("ds")]
        public int Discontinued { get; set; }

        [DatabaseColumnName("min_qt")]
        public int MinimumOrderQuantity { get; set; }
        
        [DatabaseColumnName("w_id")]
        public int WarehouseId { get; set; }

     
        [DatabaseColumnName("hld")]
        public int Held { get; set; }

        public StockProductDataModel(IDataReader dataReader) : base(dataReader)
        { }

        public StockProductDataModel()
        { }

        public StockProductDataModel(StockProductDataModel apiModel)
        {
            Id = apiModel.Id;
            Gtin = apiModel.Gtin;
            Gcp = apiModel.Gcp;
            Name = apiModel.Name;
            Weight = apiModel.Weight;
            LowerThreshold = apiModel.LowerThreshold;
            Discontinued = apiModel.Discontinued;
            MinimumOrderQuantity = apiModel.MinimumOrderQuantity;
            Held = apiModel.Held;
            WarehouseId = apiModel.WarehouseId;
        }

    }

}