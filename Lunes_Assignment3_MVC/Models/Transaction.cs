using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lunes_Assignment3_MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        [Required(ErrorMessage = "This field cannot be empty")]
        [DisplayName("Definition of the Transaction")]
        public string TransactionName { get; set; }
        [Column(TypeName = "int")]
        [Required(ErrorMessage = "This field cannot be empty")]
        [DisplayName("Amount of the Transaction (+/-)")]
        public int TransactionAmount { get; set; }
    }
}
