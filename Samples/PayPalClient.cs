using System;
using CheckoutNetsdk.Core;
using BraintreeHttp;

using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace Samples
{
    public class PayPalClient
    {
        /**
            Setting up PayPal environment with credentials with sandbox cerdentails. 
            For Live, this should be LiveEnvironment Instance. 
         */
        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment("AVNCVvV9oQ7qee5O8OW4LSngEeU1dI7lJAGCk91E_bjrXF2LXB2TK2ICXQuGtpcYSqs4mz1BMNQWuso1", "EDQzd81k-1z2thZw6typSPOTEjxC_QbJh6IithFQuXdRFc7BjVht5rQapPiTaFt5RC-HCa1ir6mi-H5l");
        }

        /**
            Returns PayPalHttpClient instance which can be used to invoke PayPal API's.
         */
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
        }

        /**
            This method can be used to Serialize Object to JSON string.
        */
        public static String ObjectToJSONString(Object serializableObject)
        {
            MemoryStream memoryStream = new MemoryStream();
            var writer = JsonReaderWriterFactory.CreateJsonWriter(
                        memoryStream, Encoding.UTF8, true, true, "  ");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializableObject.GetType(), new DataContractJsonSerializerSettings{UseSimpleDictionaryFormat = true});
            ser.WriteObject(writer, serializableObject);
            memoryStream.Position = 0;
            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
