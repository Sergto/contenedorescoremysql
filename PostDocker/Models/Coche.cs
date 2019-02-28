using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostDocker.Models
{
    [Table("COCHES")]
    public class Coche
    {
        [Key]
        [Column("COCHE_NO")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }
        [Column("MARCA")]
        public String Marca { get; set; }
        [Column("MODELO")]
        public String Modelo { get; set; }
        [Column("PRECIO")]
        public int Precio { get; set; }
        [Column("TIPO")]
        public String Tipo { get; set; }
    }
}
