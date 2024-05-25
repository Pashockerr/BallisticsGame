using Godot;
using Scripts.Projectiles;
using System;

namespace Scripts{
	public partial class WinArea : Area2D
	{
		[Export]
		private Button _showAreaButton;
		[Export]
		private Container _winMenuContainer;
		public override void _Ready()
		{
			BodyEntered += (Node2D n) =>{
				if(n.IsInGroup("Projectiles")){
					_winMenuContainer.Show(); 
					if(n is BaseProjectile){
						(n as BaseProjectile).TouchedWinArea = true;
					}
				}
			};
			_showAreaButton.Pressed += () =>{
				Visible = !Visible;
				_showAreaButton.Text = Visible ? "Скрыть цель" : "Показать цель";
			};
		}
	}
}
