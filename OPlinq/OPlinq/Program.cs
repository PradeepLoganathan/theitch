using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OPlinq
{
    class Program
    {
        static void Main(string[] args)
        {

            SumEven();
            //var BandRawData = CreateBandRawData();
            //var DistRawdata = CreateDistRawData();

            //PrintOPData(BandRawData);
            //PrintDistData(DistRawdata);

            //JoinOPDistData(BandRawData, DistRawdata);


        }

        private static void JoinOPDistData(IEnumerable<OzGradeRanking> bandRawData, IEnumerable<OZGradeDistribution> distRawdata)
        {
            var s = from g in bandRawData
                    join j in distRawdata on new { year = g.Year, band = g.Band} equals
                                             new { year = j.Year, band = j.OPBand } 
                    select new
                    {
                        Year = g.Year,
                        Band = g.Band,
                        LowerBoundary = g.LowerBoundary,
                        NoOfStudents = j.NoOfStudents,
                        Percentage = j.Percentage
                    };
            var m = s.ToList();
            Console.WriteLine($"Year OpRanking    #     LowerBoundary");
            foreach (var item in m)
            {
                Console.WriteLine($"{item.Year, -5} {item.Band, -10} {item.NoOfStudents, 5} {item.LowerBoundary, 10}");
            }
            

        }

        private static IEnumerable<OZGradeDistribution> CreateDistRawData()
        {
            var csvdata = File.ReadAllLines("opdistribution.csv")
                       .Skip(1);

            var gradeDistributions = csvdata.
                    Select (eachline =>
                    {
                        var columns = eachline.Split('\t');
                        return new OZGradeDistribution
                        {
                            Year = int.Parse(columns[0]),
                            OPBand = int.Parse(columns[1]),
                            NoOfStudents = int.Parse(columns[2]),
                            Percentage = double.Parse(columns[3]),
                            Cumulative = double.Parse(columns[4]),
                            CumulativePercentage = double.Parse(columns[5])
                        };
                    });

            return gradeDistributions;
        }

        private static IEnumerable<OzGradeRanking> CreateBandRawData()
        {
            var RawData = File.ReadAllLines("qcaa_op_fp_band_boundaries.csv")
                 .Skip(1)
                 .Where(line => line.Length > 1);

            var OPFP = RawData.
                     Select(line =>
                     {
                         var columns = line.Split(',');
                         return new OzGradeRanking
                         {
                             Year = int.Parse(columns[0]),
                             OPFP = columns[1],
                             Band = int.Parse(columns[2]),
                             LowerBoundary = double.Parse(columns[3])
                         };
                     });

            //return OPFP.Where(l => l.Year == 2017 || l.Year == 2016 || l.Year == 2015);
            return OPFP.Where(l => l.Year == 2017 && l.OPFP == "OP");
        }


        private static void PrintOPData(IEnumerable<OzGradeRanking> RawData)
        {

            var OPDataGroup = from data in RawData
                              where data.OPFP == "OP"
                              group data by data.Year;
                         
                                         
                         

            //foreach (var item in OPDataGroup)
            //{
            //    Console.WriteLine(Environment.NewLine + $"For the year {item.Key, -5}" + Environment.NewLine);
            //    foreach (var data in item)
            //    {
            //        Console.WriteLine($"\t{data.Band,-5} --> {data.LowerBoundary,-10}");
            //    }
                
            //}
        }

        private static void PrintDistData(IEnumerable<OZGradeDistribution> distRawdata)
        {

            var s = from p in distRawdata
                    group p by p.Year;

            //foreach (var item in s)
            //{
            //    Console.WriteLine($"For the year {item.Key}");
            //    foreach (var vals in item)
            //    {
            //        Console.WriteLine($"{vals.Year,-5} {vals.OPBand,-2} {vals.NoOfStudents,-7}");
            //    }
            //    Console.WriteLine(Environment.NewLine);
            //}
        }

        private static void SumEven()
        {
            var numbers = Enumerable.Range(1, 10);
            var s = (from num in numbers
                      where num % 2 == 0
                      select num).Sum();
                       

        }
    }
}
