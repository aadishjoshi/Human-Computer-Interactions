using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_asj170430
{
    class DataHandler
    {
        //data handler class is used for manupulating data
        GetterSetterClass data = new GetterSetterClass();
        List<DateTime> entryStart = new List<DateTime>();
        List<DateTime> entryEnd = new List<DateTime>();
        List<TimeSpan> activityTime = new List<TimeSpan>();
        List<TimeSpan> betweenTime = new List<TimeSpan>();

        //evaluate data reads the file CS6326Asg2 and splits the data with \t  
        public GetterSetterClass evaluateData(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string record = reader.ReadLine();
                    data.totalRecords = 0;
                    data.backSpaceCount = 0;
                    while (record != null)
                    {
                        data.totalRecords++;
                        string[] dt = record.Split('\t');

                        //12,13,14
                        entryEnd.Add(Convert.ToDateTime(dt[12]));
                        Console.WriteLine(dt[12]);
                        Console.WriteLine(dt[14]);
                        Console.WriteLine(dt[15]);
                        entryStart.Add(Convert.ToDateTime(dt[14]));
                        data.backSpaceCount = System.Convert.ToInt32(dt[15]);
                        Console.WriteLine(data.backSpaceCount);
                        record = reader.ReadLine();
                    }

                    //the entry time max, min operations list

                    for(int i= 0; i < data.totalRecords; i++)
                    {
                        activityTime.Add(entryEnd[i].Subtract(entryStart[i]));
                        
                    }

                    //between two entries
                    for(int i=0;i< data.totalRecords -1; i++)
                    {
                        betweenTime.Add(entryStart[i + 1].Subtract(entryEnd[i]));
                    }

                    data.entryTimeMax = activityTime.Max();
                    data.entryTimeMin = activityTime.Min();
                    data.betweenTimeMax = betweenTime.Max();
                    data.betweenTimeMin = betweenTime.Min();
                    data.timeTotal = entryEnd[data.totalRecords - 1].Subtract(entryStart[0]);
                    data.entryTimeAvg = new TimeSpan(Convert.ToInt64(activityTime.Average(ts => ts.Ticks)));
                    data.betweenTimeAvg = new TimeSpan(Convert.ToInt64(betweenTime.Average(ts => ts.Ticks)));

                }
                return data;
            }
            catch
            {
                return data;
            }
            
        }

        //CS6326Asg3 file created
        public bool writeData(string fileName, GetterSetterClass dataInstance)
        {
            try
            {

                //if fileexists then delete and proceed
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                
                    using(StreamWriter writer = new StreamWriter(fileName))
                    {
                        string output = "The Number of records : " + data.totalRecords + "\n"
                       + "\n Minimum Entry Time: " + data.entryTimeMin.ToString(@"mm\:ss") + "\n" 
                       + "\n Maximum Entry Time: " + data.entryTimeMax.ToString(@"mm\:ss") + "\n"
                       + "\n Average Entry Time: " + data.entryTimeAvg.ToString(@"mm\:ss") + "\n"
                       + "\n Minimum Between Time: " + data.betweenTimeMin.ToString(@"mm\:ss") + "\n"
                       + "\n Maximum Between Time: " + data.betweenTimeMax.ToString(@"mm\:ss") + "\n"
                       + "\n Average Between Time: " + data.betweenTimeAvg.ToString(@"mm\:ss") + "\n"
                       + "\n Total Time: " + data.timeTotal.ToString(@"mm\:ss") + "\n"
                       + "\n Total backspaces Count: " + data.backSpaceCount + "\n";

                        writer.Write(output);

                    }
                   
                    
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
