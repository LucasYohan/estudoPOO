using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class tiro: PictureBox
	{
		public tiro()
		{
			Width = 30;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.fundo;
			timerTiro.Enabled = true;
			timerTiro.Tick += timerTick;
		}
		
		public int direcao = 1;
		public int speed = 55;
		public int dano = 10;
		public Personagem personagemAlvo;
		public Timer timerTiro = new Timer();
		
		
		void timerTick(object sender, EventArgs e){
			
			Left += direcao * speed;
			
			if(Left > MainForm.fundo.Width || Left < 0){
				Destruir();
			}
			
			if(personagemAlvo.Bounds.IntersectsWith(this.Bounds)){
				(personagemAlvo as Inimigo).Destruir();
				Destruir();
			}
		}
		
		public void Destruir(){
			timerTiro.Enabled = false;
			Left = 600;
			MainForm.listaTiros.Items.Remove(this);
			MainForm.barra.Value += 1;
			this.Dispose();
		}
	}
}
