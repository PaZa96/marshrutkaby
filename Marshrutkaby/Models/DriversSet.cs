namespace Marshrutkaby.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DriversSet")]
    public partial class DriversSet
    {
        [Key]
        public int IdDriver { get; set; }

        [Display(Name = "�������")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "���")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "���� ��������")]
        public DateTime Birthday { get; set; }

        [Display(Name = "��������")]
        [Required]
        public string License { get; set; }

        [Display(Name = "����� ��������")]
        [Required]
        public string NumberPhone { get; set; }

        [Required]
        public string Email { get; set; }

        [Display(Name = "�������")]
        public int Raiting { get; set; }

        public int IdTransportCompany { get; set; }

        public virtual TransportCompanySet TransportCompanySet { get; set; }
    }
}
