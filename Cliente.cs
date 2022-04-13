namespace ExBiblioteca
{
    public class Cliente : Usuario
    {
        public string Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
}