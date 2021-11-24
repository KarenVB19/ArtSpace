//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Orden
    {
        public int Id { get; set; }

        [DisplayName("Fecha de creación")]
        public System.DateTime fecha_creacion { get; set; }

        [DisplayName("Número de confirmación")]
        public int num_confirmacion { get; set; }

        [DisplayName("Total")]
        public decimal total { get; set; }

        [DisplayName("Cliente")]
        public int id_cliente { get; set; }

        public int id_dirEntrega { get; set; }

        [DisplayName("Paquetería")]
        public Nullable<int> id_paqueteria { get; set; }
        
        [DisplayName("Número de guía")]
        public string num_guia { get; set; }

        [DisplayName("Fecha de envío")]
        public Nullable<System.DateTime> fecha_envio { get; set; }

        [DisplayName("Fecha de entrega")]
        public Nullable<System.DateTime> fecha_entrega { get; set; }

        public string estatus { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual dirEntrega dirEntrega { get; set; }
        public virtual Paqueteria Paqueteria { get; set; }
    }
}