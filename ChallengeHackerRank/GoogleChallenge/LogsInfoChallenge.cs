using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.GoogleChallenge
{
    public static class LogsInfoChallenge
    {

        static  int TimeoutValue = 3;



        static Dictionary<long, LogsInfo> LogsInfoMap = new Dictionary<long, LogsInfo>();

        public static bool CheckLogsTimeout(long RpcId, long TimeStatmp, string Status)
        {
            var logsInfo = new LogsInfo(RpcId, TimeStatmp, Status);

            if(LogsInfoMap.ContainsKey(logsInfo.RpcId))
            {
                var logInfoBefore = LogsInfoMap[logsInfo.RpcId];

                var caclTimeStamp = logsInfo.TimeStamp - logInfoBefore.TimeStamp;
                if (caclTimeStamp > TimeoutValue)
                    return false;
                else
                {
                    if(logsInfo.Status == "End") 
                        LogsInfoMap.Remove(logsInfo.RpcId);
                }
            } else
            {
                if(LogsInfoMap.Count > 0)
                {
                    var logBefore = LogsInfoMap.Values.FirstOrDefault();
                    var caclTimeStamp = logsInfo.TimeStamp - logBefore.TimeStamp;
                    if (caclTimeStamp > TimeoutValue)
                        return false;
                }

                LogsInfoMap.Add(logsInfo.RpcId, logsInfo);
            }

            return true;
        }

        public static void Initial(string [] args)
        {
            var listLogsInfo = new List<LogsInfo>();
            bool hasTimeout = false;


            listLogsInfo.Add(new LogsInfo(1, 0, "Start"));
            listLogsInfo.Add(new LogsInfo(2, 1, "Start"));
            listLogsInfo.Add(new LogsInfo(1, 2, "End"));
            listLogsInfo.Add(new LogsInfo(3, 6, "Start"));
            listLogsInfo.Add(new LogsInfo(2, 7, "End"));
            listLogsInfo.Add(new LogsInfo(3, 8, "End"));

            foreach(var log in listLogsInfo)
            {
                hasTimeout = CheckLogsTimeout(log.RpcId, log.TimeStamp, log.Status);
                if(hasTimeout == false)
                {
                    break;
                }
            };

            if (hasTimeout == false)
            {
                Console.WriteLine("Throw timeout exception");                
            } else 
                Console.WriteLine("Log running without timeout");

        }
    }


    public class LogsInfo
    {
        public long RpcId { get; set; }
        public long TimeStamp { get; set; }
        public string Status { get; set; }

        public LogsInfo(long RpcId, long TimeStatmp, string Status)
        {
            this.RpcId = RpcId;
            this.TimeStamp = TimeStatmp;
            this.Status = Status;

        }

    }

}
