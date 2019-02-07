using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class TissRecursoGlosaBinding : ITissRecursoGlosaBinding
    {
        public protocoloRecebimentoRecursoWS tissRecursoGlosa_Operation(loteRecursoGlosaWS loteRecursoGlosaWs)
        {
            protocoloRecebimentoRecursoWS retorno = new protocoloRecebimentoRecursoWS();

            if (loteRecursoGlosaWs.hashField.Equals("teste_envio"))
                retorno.hashField = "teste_envio retorno";

            return retorno;
        }
    }
}
