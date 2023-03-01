using Apiprodutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiprodutos.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento pata a entidade  categoria
    /// </summary>
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //DEFINIR O NOME DA TABELANO BANCO
            builder.ToTable("CATEGORIA");

            //DEFININO A CHHAVE PRIMARIA
            builder.HasKey(c => c.Idcategoria);

            builder.Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(150)
                .IsRequired();


        }
    }
}
