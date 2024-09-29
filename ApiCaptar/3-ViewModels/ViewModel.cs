using apiCaptar._1_Domain;

namespace apiCaptar.ViewModels;


public class UsuarioViewModel : Pesquisa
{
    public int Id
    {
        get; set;
    }
    public string Nome
    {
        get; set;
    }
    public string email
    {
        get; set;
    }
    public string senha
    {
        get; set;
    }
    
    public List<Pesquisa> pesquisas { get; set; }

}
