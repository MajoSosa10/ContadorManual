namespace ControladorManual.Maui.Models
{
    public class Contador //clase de coneto 
    {
        private int _conteo;
        public int Conteo => _conteo; //propiedad de solo lectura
        public Contador()
        {

            _conteo = 0; 
        }
        public void Contar()
        {
            _conteo++;
        }
        public void Reiniciar()
        {
            _conteo = 0;
        }
    }
}
