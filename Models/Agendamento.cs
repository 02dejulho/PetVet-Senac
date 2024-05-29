using System.Collections.Generic;


namespace UC05AT3lucianasilvaa.Models
{
    public class Agendamento
    {
        private List<DadosAgendamento> listaDados = new List<DadosAgendamento>(); //nova lista de agendamento

        public void addLista(DadosAgendamento da)

        {
            listaDados.Add(da);
            
        } //funcao que traz informações para dentro da lista     



         public  List<DadosAgendamento> mostrarLista() // apresentação da lista

         {    
               return listaDados;
         }

          
        }
        
        
        
    }
