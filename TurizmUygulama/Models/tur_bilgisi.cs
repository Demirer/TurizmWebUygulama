using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurizmUygulama.Models
{
    public class tur_bilgisi
    {
        
        [Key] public int TurID { get; set; }
        public string TurAdi { get; set; }
        public string BaslangicTarihi { get; set; }
        public string BaslangicSehri { get; set; }
        public string TurSuresi { get; set; }
        

    }
}