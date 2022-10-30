using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace projetoIntegrador.Services
{
    public abstract class Backwork<T> where T : Backwork<T>, new()
    {
        private static object ChangeType(object value, Type conversionType) // Converter objetos para outro tipo de Objeto.
        {
            if (conversionType == null)
            {
                throw new ArgumentException("conversionType");
            }

            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                    return null;

                System.ComponentModel.NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }

            return Convert.ChangeType(value, conversionType);
        }

        //Metodos de Converção Json -----------------------------------------------------------------------
        public string ConvertObjectToJSon<T>(T obj) //Converter Objeto pra tipo Arquivo Json usano nas requery via post.
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                Console.WriteLine(jsonString);
                return jsonString;
            }
            catch
            {
                throw;
            }
        }
        public T ConvertJSonToObject<T>(string jsonString) //Converter arquivo json referente a response do post.
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }
        //-------------------------------------------------------------------------------------------------
    }
}
