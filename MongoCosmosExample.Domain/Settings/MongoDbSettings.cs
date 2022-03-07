using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCosmosExample.Domain.Settings;
public class MongoDbSettings
{
    public string DatabaseName { get; set; }
    public string CollectionName { get; set; }
    public string ConnectionString { get; set; }
}

