using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public static PictureBox fundo = new PictureBox();
		heroi julio = new heroi();
		Inimigo inimigo = new Inimigo();
		
		public static ListBox listaTiros = new ListBox();
		public static ProgressBar barra = new ProgressBar();

		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			//Fundo
			fundo.Parent = this;
			fundo.Height = this.Height - 120;
			fundo.Width = this.Width;
			fundo.Load("cenario.gif");
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
			//Barra de Progresso
			barra.Parent = this;
			barra.Left = 200;
			barra.Top = this.Height - 90;
			barra.Width = 200;
			barra.Maximum = 6;
			barra.Minimum = 0;
			barra.Step = 1;
			barra.Value = 6;
		}
	
		//Movimento do Heroi
		
		void MainFormKeyDown(object sender, KeyEventArgs e){
			
			if (e.KeyCode == Keys.D)
			{
				julio.MoveDir();
			}
			if (e.KeyCode == Keys.A)
			{
				julio.MoveEsq();
			}
			if (e.KeyCode == Keys.W)
			{
				julio.MoveCima();
			}
			if (e.KeyCode == Keys.S)
			{
				julio.MoveBaixo();
			}
			
			
			//Tiro do Heroi
			
			if(e.KeyCode == Keys.Space){
				
				if(barra.Value > 0){
				TiroHeroi tiro = new TiroHeroi();
				listaTiros.Items.Add(tiro);
				tiro.direcao = julio.direcao;
				tiro.Load("fireball.gif");
				tiro.Top = (int) julio.Top + (julio.Height/2) - tiro.Height;
				tiro.Left = julio.Left;
				tiro.personagemAlvo = inimigo;
				barra.Value -= 1;
				}
			}
		}
	}
}