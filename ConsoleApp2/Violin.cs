namespace ConsoleApp2
{
    internal class Violin : StringFamily
    {
        enum Etype { Eletrical, Acoustic, Electroacoustic };
        enum Esize { menorque6anos = 42, entre4e7anos = 47, entre6e10anos = 51, entre9e11anos = 56, acimade11anos = 58, adulto = 58 }
    
        public Violin(): base()
        {

        }
    }
}
