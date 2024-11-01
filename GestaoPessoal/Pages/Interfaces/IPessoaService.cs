using GestaoPessoal.Data.Models;

namespace GestaoPessoal.Pages.Interfaces
{
    public interface IPessoaService
    {
        bool AddUpdate(Pessoa pessoa);
        bool Delete(int id);
        Pessoa FindById(int id);
        List<Pessoa> GetAll();
    }
}
