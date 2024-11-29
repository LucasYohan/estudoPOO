using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			a
			Width = 90;
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.fundo;
		}
				
			public int hp = 100;
			public int xp = 0;
			public int ataque = 15;
			public int defesa = 10;
			public int speed = 20;
			public int direcao = 1;
			public Timer timerExplosao = new Timer();
			
			
			public void Destruir()
		{
			Left = 5900;
			
		}
			
		void Explosão(object sender, EventArgs e){
				
			timerExplosao.Enabled = false;
			Load("explosão.gif");
			this.Dispose();		
		}
	}
}