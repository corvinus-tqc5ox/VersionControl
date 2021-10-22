using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaR_TQC5OX.Entities;

namespace VaR_TQC5OX
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<PortfolioItem> Portfolios = new List<PortfolioItem>();

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;

            CreatePortfolio();
        }

        private void CreatePortfolio()
        {
            //PortfolioItem p = new PortfolioItem();
            //p.Index = "OTP";
            //p.Volume = 10;
            //Portfolios.Add(p); -->

            Portfolios.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolios.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolios.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolios;
        }
    }
}
