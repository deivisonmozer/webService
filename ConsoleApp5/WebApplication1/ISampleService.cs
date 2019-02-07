using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WebApplication1
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Ping(string s);

        //teste
        //[OperationContract]
        //protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation(loteRecursoGlosaWS loteRecursoGlosaWS);
        //teste

        [OperationContract]
        ComplexModelResponse PingComplexModel(ComplexModelInput inputModel);

        [OperationContract]
        void VoidMethod(out string s);

        [OperationContract]
        Task<int> AsyncMethod();

        [OperationContract]
        int? NullableMethod(bool? arg);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
    }
}
