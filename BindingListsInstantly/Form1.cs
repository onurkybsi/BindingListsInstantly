using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingListsInstantly
{
    public partial class Form1 : Form
    {
        PersonRepo personRepo;

        public Form1()
        {
            this.personRepo = new PersonRepo();

            this.personRepo.EventOfUpdate += PersonRepo_EventOfUpdate;

            InitializeComponent();

            this.personRepo.ListBoxesToBeUpdate.Add(this.listBox);

            this.listBox.DisplayMember = "Person";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            personRepo.AddElementWithUpdateProcess(new Person { Name = nameTextBox.Text, SurName = surNameTextBox.Text });
        }

        private void PersonRepo_EventOfUpdate()
        {
            foreach (var item in this.personRepo.ListBoxesToBeUpdate)
            {
                item.Items.Clear();

                for (int i = 0; i < this.personRepo.PersonsRepo.Count; i++)
                {
                    item.Items.Insert(i, this.personRepo.PersonsRepo[i]);
                }
            }
        }
    }
}
