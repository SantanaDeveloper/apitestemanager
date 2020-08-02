using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Apimanager.Model.Entities
{
    public class JsonModel
    {

        [Column("LeftJson")]
        public string LeftJson { get; set; }

        [Column("RightJson")]
        public string RightJson { get; set; }
    }
}
