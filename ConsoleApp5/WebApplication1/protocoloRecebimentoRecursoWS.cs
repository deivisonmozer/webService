using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class protocoloRecebimentoRecursoWS
    {
        //private cabecalhoTransacao cabecalhoField;

        //private ct_recebimentoRecurso recebimentoRecursoField;

        public string hashField; //mudar pra public

        //private Signature signatureField;

        /// <remarks/>
        //public cabecalhoTransacao cabecalho
        //{
        //    get
        //    {
        //        return this.cabecalhoField;
        //    }
        //    set
        //    {
        //        this.cabecalhoField = value;
        //    }
        //}

        /// <remarks/>
        //public ct_recebimentoRecurso recebimentoRecurso
        //{
        //    get
        //    {
        //        return this.recebimentoRecursoField;
        //    }
        //    set
        //    {
        //        this.recebimentoRecursoField = value;
        //    }
        //}

        /// <remarks/>
        public string hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        //public Signature Signature
        //{
        //    get
        //    {
        //        return this.signatureField;
        //    }
        //    set
        //    {
        //        this.signatureField = value;
        //    }
        //}
    }
}
