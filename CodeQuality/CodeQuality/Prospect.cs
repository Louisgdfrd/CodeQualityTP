using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality
{
    internal class Prospect
    {
		public Prospect(string aRaisonSocial, List<Contact> aContacts, DateTime aDateDeContact)
		{
			raisonSocial = aRaisonSocial;
			contacts = aContacts;
			dateContact = aDateDeContact;
			//
			// TODO: Add constructor logic here
			//
		}
		public string raisonSocial { get; set; }
		public List<Contact> contacts { get; set; }
		public DateTime dateContact { get; set; }
		public List<Offre> offresDispo { get; set; }
    }
}
