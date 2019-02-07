using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class loteRecursoGlosaWS
    {
        //private cabecalhoTransacao cabecalhoField;

        //private ct_guiaRecursoLote loteRecursoField;

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
        //public ct_guiaRecursoLote loteRecurso
        //{
        //    get
        //    {
        //        return this.loteRecursoField;
        //    }
        //    set
        //    {
        //        this.loteRecursoField = value;
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
