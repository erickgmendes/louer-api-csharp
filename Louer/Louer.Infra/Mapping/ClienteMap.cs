using Louer.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Louer.Infra.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            //string schema = SimentaQConnection.CurrentConnection.DefaultSchema;

            // ToTable("BOLETIM_CIMENTACAO", schema);
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("ID_CLIENTE")
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.TrabalhoID).HasColumnName("TRAB_SQ_TRABALHO");
            Property(x => x.Numero).HasColumnName("BOCI_NR_BOLETIM");

            Property(x => x.BoletimNumero).HasColumnName("BOCI_NR_BOLETIM_NUMERO");
            Property(x => x.BoletimVersao).HasColumnName("BOCI_VL_BOLETIM_VERSAO");
            Property(x => x.BoletimAno).HasColumnName("BOCI_VL_BOLETIM_ANO");

            Property(x => x.Descricao).HasColumnName("BOCI_NM_BOLETIM");
            Property(x => x.Estado).HasColumnName("BOCI_IN_ESTADO");
            Property(x => x.OperacaoCimentacaoID).HasColumnName("TIOP_SQ_TIPO_OPER");
            Property(x => x.PocoID).HasColumnName("POCO_CD_POCO");
            Property(x => x.DiametroPocoID).HasColumnName("DMVL_MD_DIAM_VAL_POCO");
            Property(x => x.DiametroRevestimentoID).HasColumnName("DMVL_MD_DIAM_VAL_REVESTIMENTO");
            Property(x => x.SondaID).HasColumnName("PPET_SQ_PLATAFORMA_PETROLIFERA");
            Property(x => x.ProfundidadeVertical).HasColumnName("BOCI_VL_PROF_VERTICAL");
            Property(x => x.ProfundidadeMedida).HasColumnName("BOCI_VL_PROF_MEDIDA");
            Property(x => x.GradienteGeotermico).HasColumnName("BOCI_VL_GRAD_GEOTERMICO");
            Property(x => x.TemperaturaBHST).HasColumnName("BOCI_VL_TEMPERATURA_BHST");
            Property(x => x.TemperaturaBHCT).HasColumnName("BOCI_VL_TEMPERATURA_BHCT");
            Property(x => x.Observacoes).HasColumnName("BOCI_DS_OBSERVACOES");
            Property(x => x.ObservacoesCondicoesTeste).HasColumnName("BOCI_DS_OBS_COND_TESTE");
            Property(x => x.UsuarioSolicitanteID).HasColumnName("USER_ID_SOLICITANTE");
            Property(x => x.UsuarioCriacaoID).HasColumnName("USER_ID_CRIACAO").IsRequired();
            Property(x => x.DataCriacao).HasColumnName("BOCI_DT_CRIACAO");
            Property(x => x.UsuarioModificacaoID).HasColumnName("USER_ID_MODIFICACAO");
            Property(x => x.DataModificacao).HasColumnName("BOCI_DT_MODIFICACAO");
            Property(x => x.TipoClasseCimento).HasColumnName("BOCI_TP_CLASSE_CIMENTO");

            HasOptional(bo => bo.Formulacao)
                .WithRequired(fo => fo.Boletim)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Anexos)
                .WithOptional()
                .HasForeignKey(y => y.BoletimID)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Ensaios)
                .WithOptional()
                .HasForeignKey(y => y.BoletimID)
                .WillCascadeOnDelete(true);

            HasMany(x => x.FormulacoesColchao)
                .WithOptional()
                .HasForeignKey(y => y.BoletimID)
                .WillCascadeOnDelete(true);
        }

    }
}