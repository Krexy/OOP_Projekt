using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatkovni_sloj.Modals
{
    public sealed class JsonStream
    {
        private static string Link { get; set; }

        private static JsonStream instance = null;
        private static readonly object padlock = new object();
        public static JsonStream Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new JsonStream();
                    }
                    return instance;
                }
            }
        }
        private JsonStream()
        {
        }
        private JsonStream(string link)
        {
        }
        public static void Create(string link)
        {
            if (instance != null)
            {
                throw new Exception("Object already created");
            }
            instance = new JsonStream(link);
        }
    }
}
