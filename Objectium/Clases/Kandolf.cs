using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objectium.Colores;
namespace Objectium.Clases
{
    public class Kandolf
    {
        string colorEspecie = "Rojo";
        string Forma = "Circular";
        public virtual string EmitirSonido()
        {
            string sonido = "arww";
            return sonido;
        }

        public void CambiarColor(int colorNuevo)
        {
            if(this.colorEspecie == Enum.GetName(typeof(Colores.Color), 1) && colorNuevo != (int)Colores.Color.Verde
                || this.colorEspecie == Enum.GetName(typeof(Colores.Color), 4) && colorNuevo != (int)Colores.Color.Rojo)
            {
                this.colorEspecie = Enum.GetName(typeof(Colores.Color), colorNuevo);
            }
            else if(this.colorEspecie == Enum.GetName(typeof(Colores.Color), 2) && colorNuevo != (int)Colores.Color.Azul
                || this.colorEspecie == Enum.GetName(typeof(Colores.Color), 3) && colorNuevo != (int)Colores.Color.Amarillo)
            {
                this.colorEspecie = Enum.GetName(typeof(Colores.Color), colorNuevo);
            }
        }

        public string GetColorEspecie()
        {
            return this.colorEspecie;
        }

        public void CambiarForma(int nuevaForma)
        {
            this.Forma = Enum.GetName(typeof(Colores.Forma), nuevaForma);
        }

        public string GetFormaEspecie()
        {
            return this.Forma;
        }
    }
}
