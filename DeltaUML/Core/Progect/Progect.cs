using core.common;
namespace core.progect
{
    public class Progect : Element
    {
        public Progect()
        {
        }
        public override bool IsPackage()
        {
            // si bien un proyecto no es un paquete en si mismo, pero contiene a otros elementos, por lo que el consepto es el mismo 
            return true;
        }

    }

}