using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.DB.Mapping
{
    public class PaqueteEmpleadoMapping : IEntityTypeConfiguration<PaqueteEmpleado>
    {
        public void Configure(EntityTypeBuilder<PaqueteEmpleado> builder)
        {
            builder.ToTable("PaqueteEmpleado", "dbo");
            builder.HasKey(o => new { o.IdPaquete , o.IdEmpleado});
        }
    }
}
