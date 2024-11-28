using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeObjetoHeroi
{
	public class heroi: Personagem
	{	
		public heroi()
		{
			Left = 50;
			Top = 100;
			speed = 20;
			Load("GargoyleDir.gif");
			direcao = 1;
		}
		
		public void MoveDir()
		{
			Left += speed;
			if(Left >= 1000)
			{
				Left = 0;
			}
			
			if(direcao == -1)
			{
				direcao = 1;
				Load("GargoyleDir.gif");
			}
			
			if(Left > 660){
				Left = 660;
			}
			
		}
		public void MoveEsq()
		{	
			Left -= speed;
			if(Left == 0){
				Left = 1000;
			}
			
			if(direcao == 1){
				direcao = -1;
				Load("GargoyleEsq.gif");
			}
			
			if(Left < 0){
				Left = 0;
			}
			
		}
		
		public void MoveCima()
		{	
			Top -= speed;
			if(Top <= 0){
				Top = 0;
			}	
		}
		
		public void MoveBaixo()
		{	
			Top += speed;
			if(Top >= 275){
				Top = 275;
			}	
		}
		
	}
}