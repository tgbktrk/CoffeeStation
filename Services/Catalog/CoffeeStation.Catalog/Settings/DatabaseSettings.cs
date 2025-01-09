using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductDetailCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductImageCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}