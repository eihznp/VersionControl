using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks4
{
    public partial class Form1 : Form
    {
        RealEstateEntities2 context = new RealEstateEntities2();
        List<Flat> Flats;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            Flats = context.Flat.ToList();
        }

    }
}
