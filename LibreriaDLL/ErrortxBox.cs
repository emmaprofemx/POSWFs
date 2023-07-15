using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaDLL
{
    public partial class ErrortxBox : TextBox
    {
        public ErrortxBox()
        {
            InitializeComponent();
        }

        //Se activara o desactivara segun lo que estemos intentando ingresar tanto en mantenimiento productos y clientes
        public Boolean Validar
        {
            set;
            get;
        }
    }
}
