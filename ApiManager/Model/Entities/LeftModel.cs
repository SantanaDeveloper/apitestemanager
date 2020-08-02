using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Model.Entities
{

    [Table("leftdiff")]
    public class LeftModel
    {
        /// <summary>
        /// A chave deve ser o ID
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Column("json")]
        public string Json { get; set; }

    }
}
