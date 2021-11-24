using System;
using net.Models;
using System.Collections.Generic;
namespace net.Models.Repositorios
{

public class FacturaRepositorio {

    public static List<Factura> Lista {get;set;}

    static FacturaRepositorio () {

        Lista=new List<Factura>();
        Factura f1= new Factura(1,"tablet",300,"SinIVA",true);
        Factura f2= new Factura(2,"auricular",100,"IVA",false);
        
    
        Lista.Add(f1);
        Lista.Add(f2);
        
    }
    public static void Insertar(Factura factura) {

        Lista.Add(factura);
    }

     public static Factura BuscarUna(int numero) {

       for (int i=0;i<Lista.Count;i++) {

           if (Lista[i].Numero==numero){
               return Lista[i];
           }
       }
       return  null;
    }
    
    }

}