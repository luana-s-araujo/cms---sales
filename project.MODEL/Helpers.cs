﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.br.com.projeto.MODEL
{
    public class Helpers
    {
        public void limparTela(Form tela)
        {
            foreach (Control ctlPai in tela.Controls)
            {
                foreach(Control ctr1 in ctlPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty;
                            }
                            if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
