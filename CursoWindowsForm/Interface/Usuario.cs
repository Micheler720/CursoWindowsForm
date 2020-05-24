namespace CursoWindowsForm.Interface
{
    internal class Usuario
    {
        private string nomeUsuario;
        private string senha;

        public Usuario(string nomeUsuario, string senha)
        {
            this.nomeUsuario = nomeUsuario;
            this.senha = senha;
        }
    }
}