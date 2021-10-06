using System;

namespace NutriTic.App.Dominio.Entidades
{
    public class Sesion
    {
        private static Sesion instance =null;
        public string IdUsuario { get; set; }
        public static object _lock = new object();

        private Sesion()
        {
          
        }

        public static Sesion Instance{
            get{
                if(instance==null)
                   instance=new Sesion();
                return instance;
            }
        }

        public static void Login(string IdUsuario){
            lock (_lock){
                if(instance==null){
                    instance=new Sesion();
                    instance.IdUsuario=IdUsuario;
                }else{
                    throw new Exception("Sesión ya iniciada");
                }
            }
           
           
        }

        public static void Logout(){
            lock (_lock){
                if(instance!=null){
                    instance=null;               
                }else{
                    throw new Exception("Sesión no iniciada");
                }
            }
           
           
        }

        public static Sesion GetSesion(){
            if(instance==null)
            throw new Exception("Sesión no iniciada");
            return instance;           
        }


    }
}
