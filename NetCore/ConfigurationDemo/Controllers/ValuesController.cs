using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Rabbit.Zookeeper;
using Rabbit.Zookeeper.Implementation;

namespace ConfigurationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IOptions<EntAppFramework> _options;
        public ValuesController(IConfiguration config, IOptions<EntAppFramework> options)
        {
            _options = options;
            _config = config;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            //  IZookeeperClient zookeeperClient = new ZookeeperClient("w1.confandsa.zk.group.hex.com:2181,w2.confandsa.zk.group.hex.com:2181,w3.confandsa.zk.group.hex.com:2181");
            //IEnumerable<byte> date =  await zookeeperClient.GetDataAsync("/EntAppFrameWorkconfig/Group-HTE");
            //  var h = Encoding.UTF8.GetString(date.ToArray());

            // var xml = XmlReader.Create(new StringReader(h));
           var domain =  _config["domain"];
            var i = _config["EntAppFramework:DataAccesses:DataAccessescontent:0:DataAccess:id"];
            var a = _options.Value.DataAccesses.DataAccessescontent.FirstOrDefault(m=>m.domainConfigName==domain).Object.constructorarg[0].value;
            return new string[] { i,a };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
