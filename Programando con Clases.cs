using System;

namespace clases{

    class program {


        static void Main(string[] args){

            circulo circulo1 = new circulo(15); 

            Triangulo triangulo1 = new Triangulo(10,5);

            Rectangulo rectangulo1 = new Rectangulo (2,2);

            Console.WriteLine("el area del Circulo es: "+circulo1.getvbase());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("el area del Triangulo es: "+triangulo1.getarea());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("el area del Rectangulo es: "+rectangulo1.getvbase());
        }



    }

    public class circulo
    {

        public circulo(double Radio){

            radio = Radio;

            resultado = pi* (radio*radio);
        }    


     public  double getvbase(){


            return resultado  ;


        }   

        double pi = 3.14;
 
        double radio;

        double resultado;
    }
        

    class Rectangulo{
        public Rectangulo (double vbase, double Altura){

            double vbase1 = vbase;

            double  altura1 = Altura;

            resultado = vbase1*altura1;

        }

         public  double getvbase(){


            return resultado  ;


        }   
 

        double pi = 3.14;
        double Altura;

        double vbase;

        double resultado;
    } 


    class Triangulo{

        public Triangulo (Double altura1,Double vbase1){


            Altura = altura1;

            vbase=vbase1;

            resultado = (vbase*Altura)/2;

        }


        public Double getarea(){

            return resultado;
        }

        Double Altura;

        Double vbase;

        Double resultado;


    }   

    
       


}    



