using GestaoPessoal.Data;
using GestaoPessoal.Data.Models;
using GestaoPessoal.Pages.Interfaces;
using System;

namespace GestaoPessoal.Pages.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly GestaoPessoalContext _context;
        public PessoaService(GestaoPessoalContext context)
        {
            _context = context;
        }

        /*
         * Adiciona ou atualiza o registro de uma entidade Pessoa no banco de dados.
         */
        public bool AddUpdate(Pessoa pessoa)
        {
            try
            {
                pessoa.DataNascimento = DateTime.SpecifyKind(pessoa.DataNascimento, DateTimeKind.Utc);

                if (pessoa.Id == 0)
                _context.Pessoa.Add(pessoa);
                else
                    _context.Pessoa.Update(pessoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }

        /*
         * Remove o registro de uma entidade Pessoa no banco de dados.
         */
        public bool Delete(int id)
        {
            try
            {
                var pessoa = FindById(id);
                if (pessoa == null)
                    return false;
                _context.Pessoa.Remove(pessoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine($"Erro: {ex.Message}");

                return false;
            }
        }

        /*
         * Localiza o registro de uma entidade Pessoa no banco de dados.
         */
        public Pessoa FindById(int id)
        {
            return _context.Pessoa.Find(id);
        }

        /*
         * Busca todos os registros de entidade Pessoa no banco de dados.
         */
        public List<Pessoa> GetAll()
        {
            return _context.Pessoa.ToList();
        }
    }
}
