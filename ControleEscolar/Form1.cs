using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Aqui é comentário
            //criando as variaveis
            //criar as variaveis no começo do codigo
            
            decimal nota1 = decimal.Parse(textN1.Text); 
            decimal nota2 = decimal.Parse(textN2.Text); 
            decimal nota3 = decimal.Parse(textN3.Text); 
            decimal nota4 = decimal.Parse(textN4.Text);

            //
            if (nota1 > 10 || nota1 < 0) {
            
            //só para colocar cursor na caixinha que esta com erro   
                textN1.Focus();
                //mostrar mensagem pro usuario
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10","Erro Nota 1",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;

            }
            if (nota2 > 10 || nota2 < 0)
            {
  
                textN1.Focus();
                //mostrar mensagem pro usuario
                MessageBox.Show("A nota 2 está errada, notas entre 0 e 10", "Erro Nota 2", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;

            }
            if (nota3 > 10 || nota3 < 0)
            {
   
                textN1.Focus();
                //mostrar mensagem pro usuario
                MessageBox.Show("A nota 3 está errada, notas entre 0 e 10", "Erro Nota 3", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;

            }
            if (nota4 > 10 || nota4 < 0)
            {

                textN1.Focus();
                //mostrar mensagem pro usuario
                MessageBox.Show("A nota 4 está errada, notas entre 0 e 10", "Erro Nota 4", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;

            }

            decimal media1 = ((nota1 * 4) + (nota2 * 6)) / 10;
            decimal media2 = ((nota3 * 4) + (nota4 * 6)) / 10;
            decimal mediaFinal = (media1 + media2) / 2;
            
            //mostrar médias
            //.ToString() = transformar em texto isto é um metodo/função
            //como saber se é um método, icone do cubo roxo
            
            textBim1.Text = media1.ToString();
            textBim2.Text = media2.ToString();
            textMedia.Text = mediaFinal.ToString();
            
                

           
            
            
            
            
     




        }

        private void textN4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
