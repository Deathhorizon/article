using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Filter;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Xml;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument log4netConfig = new XmlDocument();
            #region Load log4netConfig
            log4netConfig.LoadXml(@"
            <log4net>
            <appender name=""MemoryAppender"" type=""log4net.Appender.MemoryAppender, log4net"">
                <filter type=""log4net.Tests.Filter.MultiplePropertyFilter, log4net.Tests"">
                    <condition>
                        <key value=""ABC"" />
                        <stringToMatch value=""123"" />
                    </condition>
                    <condition>
                        <key value=""DEF"" />
                        <stringToMatch value=""456"" />
                    </condition>
                </filter>
            </appender>
            <root>
                <level value=""ALL"" />
                <appender-ref ref=""MemoryAppender"" />
            </root>
            </log4net>");
            #endregion

            ILoggerRepository rep = LogManager.CreateRepository(Guid.NewGuid().ToString());
            XmlConfigurator.Configure(rep, log4netConfig["log4net"]);

            IAppender[] appenders = LogManager.GetRepository(rep.Name).GetAppenders();
           // Assert.IsTrue(appenders.Length == 1);

            IAppender appender = Array.Find(appenders, delegate (IAppender a) {
                return a.Name == "MemoryAppender";
            });
            //Assert.IsNotNull(appender);

            MultiplePropertyFilter multiplePropertyFilter = new MultiplePropertyFilter();
            
                multiplePropertyFilter =((AppenderSkeleton)appender).FilterHead as MultiplePropertyFilter;
            MultiplePropertyFilter.Condition[] conditions = multiplePropertyFilter.GetConditions();
            
        }
    }
    public class MultiplePropertyFilter : FilterSkeleton
    {
        private readonly List<Condition> _conditions = new List<Condition>();

        public override FilterDecision Decide(LoggingEvent loggingEvent)
        {
            return FilterDecision.Accept;
        }

        public Condition[] GetConditions()
        {
            return _conditions.ToArray();
        }

        public void AddCondition(Condition condition)
        {
            _conditions.Add(condition);
        }

        public class Condition
        {
            private string key, stringToMatch;
            public string Key
            {
                get { return key; }
                set { key = value; }
            }
            public string StringToMatch
            {
                get { return stringToMatch; }
                set { stringToMatch = value; }
            }
        }
    }
}
