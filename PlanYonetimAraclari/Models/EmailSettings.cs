using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanYonetimAraclari.Models
{
    public class EmailSettings
    {
        public string MailServer { get; set; }
        public int MailPort { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
} 