using Louer.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Louer.Domain.Entities
{
    public class Cliente
    {

        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

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

        public virtual IList<ClienteTelefone> Telefones { get; set; }

        public virtual IList<ClienteEmail> Emails { get; set; }

        public virtual IList<ClienteReferencia> Referencias { get; set; }
    }
}
