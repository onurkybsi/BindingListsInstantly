using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingListsInstantly
{
    public delegate void DelegateOfUpdate();

    public class PersonRepo
    {
        public PersonRepo()
        {
            this.PersonsRepo = new List<Person>();
            this.ListBoxesToBeUpdate = new List<ListBox>();
        }
        public List<Person> PersonsRepo { get; }
        public void AddElementWithUpdateProcess(Person person)
        {
            PersonsRepo.Add(person);

            EventOfUpdate();
        }
        public List<ListBox> ListBoxesToBeUpdate { get; set; }

        public event DelegateOfUpdate EventOfUpdate;
    }
}
