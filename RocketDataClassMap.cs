using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;


namespace CSVReadDemo
{
    public class RocketDataClassMap : ClassMap<RocketData>
    {
        public RocketDataClassMap()
        {
            //Map(r => r.RocketName).Name("rocket_name");
            //Map(r => r.Organisation).Name("organisation");
            //Map(r => r.PayloadCapacity).Name("payload_capacity");
            ////.Convert(rocket =>
            ////{
            ////    return rocket.PayloadCapacity.HasValue ? $"{rocket.PayloadCapacity} kg" : string.Empty;
            ////});
            //Map(r => r.FirstLaunchDate).Name("first_launch_date").TypeConverterOption.Format("s");

            Map(r => r.RocketName).Index(0);
            Map(r => r.Organisation).Index(1);
            Map(r => r.PayloadCapacity).Index(2);
            Map(r => r.FirstLaunchDate).Index(3);
        }
    }
}
