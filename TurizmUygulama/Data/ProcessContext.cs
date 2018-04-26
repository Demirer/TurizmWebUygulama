using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TurizmUygulama.Models;

namespace TurizmUygulama.Data
{
    public class ProcessContext : DbContext
    {
        public ProcessContext() : base("ProcessDatabase")
        {

        }

        public DbSet<tur_bilgisi> TurBilgileri { get; set; }

    }
}