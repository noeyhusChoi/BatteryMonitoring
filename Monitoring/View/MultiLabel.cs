using NFA_RCOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring.View
{
    public partial class MultiLabel : UserControl
    {
        public MultiLabel()
        {
            InitializeComponent();

            lblTitle.Text = "";
            lblBottomLeft.Text = "";
            lblBottomRight.Text = "";
            lblCenterLeft.Text = "";
            lblCenterRight.Text = "";
        }

        public string Title
        { 
            get { return lblTitle.Text; } 
            set { lblTitle.Text = value; } 
        }

        public string BottomLeft
        { 
            get { return lblBottomLeft.Text; } 
            set { lblBottomLeft.Text = value; }
        }

        public string BottomRight
        { 
            get { return lblBottomRight.Text; } 
            set { lblBottomRight.Text = value;}
        }

        public string CenterLeft
        { 
            get { return lblCenterLeft.Text; } 
            set { lblCenterLeft.Text = value; }
        }

        public string CenterRight
        { 
            get { return lblCenterRight.Text; } 
            set { lblCenterRight.Text = value; }
        }
    }
}
