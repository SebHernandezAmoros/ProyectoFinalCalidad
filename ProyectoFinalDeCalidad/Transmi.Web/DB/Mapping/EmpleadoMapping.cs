using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.DB.Mapping
{
    public class EmpleadoMapping : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado", "dbo");
            builder.HasKey(o => o.EmpleadoId);
        }
    }
}
