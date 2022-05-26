using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.DB.Mapping
{
    public class PaqueteClienteMapping : IEntityTypeConfiguration<PaqueteCliente>
    {
        public void Configure(EntityTypeBuilder<PaqueteCliente> builder)
        {
            builder.ToTable("PaqueteCliente", "dbo");
            builder.HasKey(o => new { o.IdPaquete, o.IdCliente });

            builder.HasOne<Cliente>(o => o.Clientë)
                .WithMany()
                .HasForeignKey(o => o.IdCliente);
        }
    }
}
