﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtSpace.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class contextArtSpace : DbContext
    {
        public contextArtSpace()
            : base("name=contextArtSpace")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<subcategoria> subcategoria { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<dir_entrega> dir_entrega { get; set; }
        public virtual DbSet<metPago> metPago { get; set; }
    }
}