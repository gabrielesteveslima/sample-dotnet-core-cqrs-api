﻿namespace SampleProject.Infrastructure.Processing.InternalCommands
{
    using Database;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class InternalCommandEntityTypeConfiguration : IEntityTypeConfiguration<InternalCommand>
    {
        public void Configure(EntityTypeBuilder<InternalCommand> builder)
        {
            builder.ToTable("InternalCommands", SchemaNames.Application);

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedNever();
        }
    }
}