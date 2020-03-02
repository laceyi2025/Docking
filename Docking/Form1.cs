using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docking
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private int GetPanelSize()
      {
         return (pnlMain.Size.Width) / 2;
      }

      private void AdjustPanelSize()
      {
         pnlLeft.Size = pnlRight.Size = new Size(GetPanelSize(), 44);
         pnl1Left.Size = pnl2Right.Size = new Size(GetPanelSize(), 44);
      }

        private void Form1_Resize(object sender, EventArgs e)
        {
         AdjustPanelSize();
        }

     
    }
}
