using Vidracaria_Portal.Models.Cliente;

namespace Vidracaria_Portal.ViewModel
{
    public class ContatoViewModel
    {
        public ContatoModel Contato { get; set; }
    }

    public class GaleriaViewModel 
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Image { get; set; }
    }

    public class HomeViewModel
    {
        public ContatoModel Contato { get; set; }
    }
}
