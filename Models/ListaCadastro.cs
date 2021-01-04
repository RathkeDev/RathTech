using System.Collections.Generic;
using System;


namespace projetoMVC.Models
{
    public class ListaCadastro
    {
        private static List<Cadastro> cadastros = new List<Cadastro>();

        public static void Incluir(Cadastro cadastro){
           
                    cadastros.Add(cadastro);
                   
                }
            
                public static List<Cadastro> Listar(){
                    return cadastros;
        }

       
    }
}