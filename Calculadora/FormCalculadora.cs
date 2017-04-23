using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Caracteres cuja digitação é permitida no visor
        /// Inclui números, operadores, ponto, parêntesis, espaços e backspace (\b)
        /// </summary>
        private const string ALLOWED_CHARACTERS = "0123456789+-*/^.() \b";

        /// <summary>
        /// Construtor
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de clique em qualquer botão que seja um dígito (número, operador, parêntesis ou ponto)
        /// </summary>
        /// <param name="sender">Botão que disparou o evento</param>
        private void btnDigito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char chr = btn.Tag.ToString()[0], 
                    ultimoDigitado = string.IsNullOrEmpty(edVisor.Text) ? (char)0 : edVisor.Text[edVisor.Text.Length - 1];

            bool semEspaco = string.IsNullOrEmpty(edVisor.Text) || 
                ((char.IsNumber(ultimoDigitado) || ultimoDigitado == '.') && (char.IsNumber(chr) || chr == '.'));

            edVisor.Text += (semEspaco ? "" : " ") + chr;
        }

        /// <summary>
        /// Evento de digitação no visor
        /// </summary>
        private void edVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se o caractere digitado não estiver na lista permitida, bloqueia o evento
            e.Handled = !ALLOWED_CHARACTERS.Contains(e.KeyChar);
        }

        /// <summary>
        /// Limpa o visor
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            edVisor.Clear();
        }

        /// <summary>
        /// Evento de clique no botão de igual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIgual_Click(object sender, EventArgs e)
        {
            SequenciaInfixa infixa = new SequenciaInfixa(edVisor.Text);
            SequenciaPosfixa posfixa = new SequenciaPosfixa(infixa);

            lbSequencias.Text = "Infixa: " + infixa + "\r\nPosfixa: " + posfixa;

            try
            {
                edResultado.Text = string.Format("{0}", posfixa.Calcular());
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(this, "A expressão digitada é inválida :(", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
