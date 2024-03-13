using SMS.BusinessObjectLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessObjectLayer.ViewModels
{
    public class ContactInfoViewcs
    {
        public ContactInfo  Contact { get; set; } = new ContactInfo();
        public IEnumerable<ContactInfo> ContactsList { get; set; } = new List<ContactInfo>();
    }
}
