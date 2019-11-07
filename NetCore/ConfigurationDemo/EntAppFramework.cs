using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public class idAndrefType
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string refType { get; set; }
    }
    public class EntAppFramework: IOptions<EntAppFramework>
    {
        /// <summary>
        /// 
        /// </summary>
        public string Log { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataAccesses DataAccesses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PublishSubscribe PublishSubscribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DomainService DomainService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DomainModel DomainModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SerialNumber SerialNumber { get; set; }
        public EntAppFramework Value => this;
    }
    public class DataAccess: idAndrefType
    {
        
    }

    public class @Object
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ConstructorargItem> constructorarg { get; set; }
    }

    public class DataAccessescontentItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string domainConfigName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataAccess DataAccess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public @Object @Object { get; set; }
    }

    public class DataAccesses
    {
        /// <summary>
        /// 
        /// </summary>
        public string @default { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataAccessescontentItem> DataAccessescontent { get; set; }
    }

    public class Provider: idAndrefType
    {
       
    }

    public class PublishSubscribecontentItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Provider Provider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public @Object @Object { get; set; }
    }

    public class PublishSubscribe
    {
        /// <summary>
        /// 
        /// </summary>
        public string app { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @default { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PublishSubscribecontentItem> PublishSubscribecontent { get; set; }
    }

    public class Dll
    {
        /// <summary>
        /// 
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Dllcontent { get; set; }
    }

    public class @In
    {
        /// <summary>
        /// 
        /// </summary>
        public Dll Dll { get; set; }
    }

    public class DomainService
    {
        /// <summary>
        /// 
        /// </summary>
        public string serviceDiscoveryMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string saveEntityMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dataQueueService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bcDataQueueService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cache { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public @In @In { get; set; }
    }

    public class DomainModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string serviceDiscoveryMode { get; set; }
    }

    public class SNProvider: idAndrefType
    {
        
    }

    public class ConstructorargItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string domainConfigName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string valueType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
    }

    public class SerialNumbercontentItem
    {
        /// <summary>
        /// 
        /// </summary>
        public SNProvider SNProvider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public @Object @Object { get; set; }
    }

    public class SerialNumber
    {
        /// <summary>
        /// 
        /// </summary>
        public string @default { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SerialNumbercontentItem> SerialNumbercontent { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public EntAppFramework EntAppFramework { get; set; }
    }
}
