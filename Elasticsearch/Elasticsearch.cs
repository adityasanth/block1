using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Elasticsearch
{
    class Elasticsearch
    {
        ElasticClient client = null;
        public Elasticsearch()
        {
            var uri = new Uri("http://127.0.0.1:9200");
            var settings = new ConnectionSettings(uri);
            settings.DisableDirectStreaming();
            client = new ElasticClient(settings);
        }

        public void phoneSearch()
        {
            var result = client.Search<Phone>(s => s
                 .Index("phone_test_index")
                 .Type("_doc")
                 .Query(q => q.MatchPhrasePrefix(c => c.Field("Phone_Number").Query("310")) 
                 && q.MatchPhrasePrefix(c => c.Field("Phone_Type").Query("wrk"))
                 ).Size(100));
            Console.WriteLine("\nResults for Phone Index");
            var resultval = result.Hits.ToDictionary(x => x.Id,z=>z.Index);
            foreach(var res in resultval)
            {
                Console.WriteLine(res);

            }
            Console.WriteLine("\n Result");
            Console.WriteLine("Total" + result.Total); 
            Console.ReadKey();
        }

        public void policySearch()
        {
            var result = client.Search<Policy>(s => s
                 .Index("policy_test_index")
                 .Type("_doc")
                 .Query(q => q.MatchPhrasePrefix(c => c.Field("Insured_Email").Query("jbenitz@hotmail.com"))
                 && q.MatchPhrasePrefix(c => c.Field("Insured_Mobile").Query("3259679130")) 
                 ));

            Console.WriteLine("\nResults for Policy Index");
            var resultval = result.Hits.ToDictionary(x => x.Id, z => z.Index);
            foreach (var res in resultval)
            {
                Console.WriteLine(res);

            }
            Console.WriteLine("\n Result");
            Console.WriteLine("Total" + result.Total);
            Console.ReadKey();
        }
    }
}
