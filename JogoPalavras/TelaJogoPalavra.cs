using System.Collections;
namespace JogoPalavras
{
    public partial class TelaJogoPalavra : Form
    {
        private Palavra jogoPalavra;
        private string palavraLetras;
        private Panel paineisPalavras;
        private int contadorPnl = 0;
        private int contEnter = 0;

        public TelaJogoPalavra()
        {
            InitializeComponent();
            jogoPalavra = new Palavra();
            ObterRegistro();
        }

        private void ObterRegistro()
        {
            AtualizarPaineis();
            foreach (Button btn in pnl_botoes.Controls)
            {
                btn.Click += ChutarLetra;
            }
        }

        private void AtualizarPaineis()
        {
            switch (contadorPnl)
            {
                case 0:
                    paineisPalavras = pnl_0;
                    break;

                case 1:
                    paineisPalavras = pnl_1;
                    break;

                case 2:
                    paineisPalavras = pnl_2;
                    break;

                case 3:
                    paineisPalavras = pnl_3;
                    break;

                case 4:
                    paineisPalavras = pnl_4;
                    break;
            }
        }

        private void ChutarLetra(object? sender, EventArgs e)
        {
            Button btnTeclado = (Button)sender;

            foreach (Button btn in paineisPalavras.Controls)
            {
                if (btn.Text == "" && btnTeclado.Text != "Enter" && btnTeclado.Text != "Del")
                {
                    palavraLetras = palavraLetras + btnTeclado.Text;
                    btn.Text = btnTeclado.Text;
                    break;
                }
            }
        }

        private void btn_enter_MouseClick_1(object sender, MouseEventArgs e)
        {
            contEnter++;
            if (palavraLetras.Length < 5)
            {
                MessageBox.Show("Precisa digitar 5 letras!");
            }
            else
            {
                int indiceBtn = 0;
                foreach (Button btn in paineisPalavras.Controls)
                {
                    if (jogoPalavra.JogadorAcertou(palavraLetras))
                    {
                        btn.BackColor = Color.Green;
                        lbl_mensagemF.Text = $"Parabéns você acertou a palavra {jogoPalavra.PalavraSecretaStr}!";
                        pnl_botoes.Enabled = false;
                    }
                    else
                    {
                        char letraBtn = Convert.ToChar(btn.Text);

                        if (jogoPalavra.VerificadorDePalavra(letraBtn, indiceBtn).Equals("Verde"))
                        {
                            btn.BackColor = Color.DarkGreen;
                        }
                        else if (jogoPalavra.VerificadorDePalavra(letraBtn, indiceBtn).Equals("Amarelo"))
                        {
                            btn.BackColor = Color.Yellow;
                        }
                        else if (jogoPalavra.VerificadorDePalavra(letraBtn, indiceBtn).Equals("Preto"))
                        {
                            btn.BackColor = Color.Black;
                        }

                        
                    }
                    indiceBtn++;
                }
                contadorPnl++;
                AtualizarPaineis();
                palavraLetras = "";
            }

            if (contEnter == 5 && !jogoPalavra.JogadorAcertou(palavraLetras))
            {
                pnl_botoes.Enabled = false;
                lbl_mensagemF.Text = $"Que pena você não acertou a palavra {jogoPalavra.PalavraSecretaStr}, clique em novo para uma nova chance!";
            }
        }

        private void btn_novo_MouseClick(object sender, MouseEventArgs e)
        {
            jogoPalavra = new Palavra();
            for (int i = 0; i < 5; i++)
            {
                contadorPnl = i;
                AtualizarPaineis();
                foreach (Button btn in paineisPalavras.Controls)
                {
                    btn.BackColor = Color.DimGray;
                    btn.Text = "";
                }
            }
            contEnter = 0;
            contadorPnl = 0;
            paineisPalavras = pnl_0;
            pnl_botoes.Enabled = true;

        }
    }

}