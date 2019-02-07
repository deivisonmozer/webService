using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WebApplication1
{
    [ServiceContract]
    public interface ITissRecursoGlosaBinding
    {
        [OperationContract]
        protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation(loteRecursoGlosaWS loteRecursoGlosaWs);
    }
}
