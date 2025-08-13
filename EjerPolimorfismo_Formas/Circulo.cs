namespace EjerPolimorfismo_Formas
{
    public class Circulo : Forma
    {
        public double Radio { get; set; }
        public Circulo(double radio) : base("Circulo")
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
