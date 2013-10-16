using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConnectSensorConsole.Telemetry;

namespace ConnectSensorConsole
{
    class Program
    {
        private static string strResult = ""; 
        static void Main(string[] args)
        {

            try
            {
                Telemetry.Telemetry service1 = new Telemetry.Telemetry();
                Console.WindowWidth = 80;
                Console.WindowHeight = 40;
                // Display hello world
                Console.WriteLine("Service say: " + service1.HelloWorld());

                // display data output
                string strUserName = "CS.SOAP009";
                string strPass = "65MtbTAA9";
                LatestLevel_V2[] results;
                results = service1.GetOTGSMLatestLevels_V2(strUserName, strPass);

                //Console.WriteLine("Here are data resutls");
                //Console.WriteLine("Level\tLevelDate\t\tAccountRef\t\t\tSignalmanNo\t\tTriggerpoint\tCapacity\tAlerts\tExpectedCallTime");

                //for (int i = 0; i < results.Length; i++)
                //{ 
                //    Console.WriteLine(results[i].Level.ToString() + "\t" + results[i].LevelDate.ToString() + "\t"
                //                + results[i].AccountRef.ToString() + "\t\t\t" + results[i].SignalmanNo.ToString() + "\t\t"
                //                + results[i].TriggerPoint.ToString() + "\t\t" + results[i].Capacity.ToString() + "\t " 
                //                + results[i].Alerts.ToString() + "\t\t" + results[i].ExpectedCallTime.ToString());
                //} 
                //Console.ReadKey();

                if (results.Count() < 1)
                {
                    Console.WriteLine("Cannot connect to the service. Please try again within 2 minutes");
                    Console.Beep();

                }
                string strNewLine = "\r\n";
                //string strSpace = "\t";
                string strSpace = ",";

                Console.WriteLine("Start exporting level data");


                // Export level data 
                for (int i = 0; i < results.Length; i++)
                {
                    //strResult = strResult + results[i].Level.ToString() + ";"
                    //            + results[i].LevelDate.ToString() + ";"
                    //            + results[i].AccountRef.ToString() + ";"
                    //            + results[i].SignalmanNo.ToString() + ";"
                    //            + results[i].TriggerPoint.ToString() + ";"
                    //            + results[i].Capacity.ToString() + ";"
                    //            + results[i].Alerts.ToString() + ";"
                    //            + results[i].ExpectedCallTime.ToString();

                    strResult = strResult
                                + results[i].SignalmanNo.ToString() + "-level" + strSpace
                        //+ results[i].AccountRef.ToString() + strSpace
                                + results[i].LevelDate.ToShortDateString() + strSpace
                                + results[i].LevelDate.ToString("hh:mm:ss") + strSpace
                                + results[i].Level.ToString();

                    strResult = strResult + strNewLine;
                }

                System.IO.File.WriteAllText(@"C:\Level.log", strResult);

                Console.WriteLine("Completed exporting level data");

                Console.WriteLine("Start exporting fill data");

                strResult = "";
                // Export Fill data 
                for (int i = 0; i < results.Length; i++)
                {
                    //strResult = strResult + results[i].Level.ToString() + ";"
                    //            + results[i].LevelDate.ToString() + ";"
                    //            + results[i].AccountRef.ToString() + ";"
                    //            + results[i].SignalmanNo.ToString() + ";"
                    //            + results[i].TriggerPoint.ToString() + ";"
                    //            + results[i].Capacity.ToString() + ";"
                    //            + results[i].Alerts.ToString() + ";"
                    //            + results[i].ExpectedCallTime.ToString();

                    strResult = strResult
                                + results[i].SignalmanNo.ToString() + "-fill" + strSpace
                        //+ results[i].AccountRef.ToString() + strSpace
                                + results[i].LevelDate.ToShortDateString() + strSpace
                                + results[i].LevelDate.ToString("hh:mm:ss") + strSpace
                                + Convert.ToString((100 - results[i].Level) * results[i].Capacity);
                    strResult = strResult + strNewLine;
                }

                System.IO.File.AppendAllText(@"C:\Level.log", strResult);

                Console.WriteLine("Completed exporting fill data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
