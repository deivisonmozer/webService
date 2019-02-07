using System;
using System.ServiceModel;
using WebApplication1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(string.Format("http://{0}:5050/Service.svc", Environment.MachineName)));
            //var channelFactory = new ChannelFactory<ISampleService>(binding, endpoint);
            //var serviceClient = channelFactory.CreateChannel();
            //var result = serviceClient.Ping("hey");


            //Cria a chamada para a interface que vai ler os dados(tiss) q serao enviados pelo client 
            var channelFactoryTiss = new ChannelFactory<ITissRecursoGlosaBinding>(binding, endpoint);
            var serviceClientTiss = channelFactoryTiss.CreateChannel();

            //objeto q vai ser passado (vai ser transformado em XML ou txt nao importa, isso quem vai fazer é o protocolo de transmissão)
            //preencher as informações desse objeto
            loteRecursoGlosaWS lote = new loteRecursoGlosaWS();
            lote.hashField = "teste_envio";

            //chamar o metodo igual é feita a chamada do serviceClient.Ping("hey");
            protocoloRecebimentoRecursoWS protocoloRecebimento = new protocoloRecebimentoRecursoWS();
            //protocoloRecebimento = TissRecursoGlosa_Binding.tissRecursoGlosa_Operation(lote);

            //chama o meu metodo de leitura de dados tiss
            protocoloRecebimento = serviceClientTiss.tissRecursoGlosa_Operation(lote);

            Console.WriteLine("Ping method result: {0}", protocoloRecebimento.hashField);
            Console.ReadKey();
        }
    }
}
