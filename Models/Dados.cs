

namespace UC05AT3lucianasilvaa.Models
{
    public class Dados
    {
        public static Agendamento AgendamentoAtual { get; set;}
   static Dados()
   {
       AgendamentoAtual = new Agendamento();
   }
        
    }
}