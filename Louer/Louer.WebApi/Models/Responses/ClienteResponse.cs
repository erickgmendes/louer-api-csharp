using System;

namespace Louer.WebApi.Models.Responses
{
    public class ClienteResponse
    {
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public string TipoCliente { get; set; }

        public string TipoPessoa { get; set; }

        public string RazaoSocial { get; set; }

        public string Nome { get; set; }

        public string CpfCnpj { get; set; }

        public string Inscricao { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }

        public string UF { get; set; }

        public string Complemento { get; set; }

        public string Observacoes { get; set; }
    }
}
