using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace CSVReadDemo
{
    public class RocketData
    {
       // [Index(1)]
        [Name("rocket_name")]
        public string RocketName { get; set; }
        //[Index(0)]
        [Name("organisation")]
        public string Organisation { get; set; }
        //[Index(2)]
        [Name("payload_capacity")]
        public int? PayloadCapacity { get; set; }
        //[Index(3)]
        [Name("first_launch_date")]
        public DateTime FirstLaunchDate { get; set; }
    }
}
