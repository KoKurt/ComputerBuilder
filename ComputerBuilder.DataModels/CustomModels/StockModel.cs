using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComputerBuilder.DataModels.CustomModels
{
    public class StockModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }

        [Required(ErrorMessage ="*Product is Required")]
        public int? NewStock { get; set; }
        public string CategoryName { get; set; }


    }
}
