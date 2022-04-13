namespace ExBiblioteca
{
    public class Funcionario : Usuario
    {
        public string Senha { get; set; }
        public DateTime DataEmprestimo { get; set; }
    }
}