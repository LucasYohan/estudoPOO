using System;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Height = 130;
			Width = 150;
			Top = 5;
			Left = 660;
			Load("dragon.gif");
			direcao = 1;
			timerMovimento.Enabled = true;
			timerMovimento.Interval = 80;
			timerMovimento.Tick += Movimento;
		}
		
		int direcaoVertical = 1;
		public Timer timerMovimento = new Timer();
		
		void Movimento(object sender, EventArgs e)
		{
			Top += speed * direcaoVertical;
			
			if(Top >= 230)
				direcaoVertical = -1;
			
			if(Top <= -20)
				direcaoVertical = 1;
		}
	}
}