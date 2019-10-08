using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CRUD2.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }

        [ForeignKey("Did")]
        public Departments DeptId { get; set; }


    }
}
