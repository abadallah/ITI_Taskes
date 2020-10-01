namespace linq3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Em_Name { get; set; }

        public int? Salery { get; set; }

        public int? Department { get; set; }

        public virtual Department Department1 { get; set; }
    }
}
