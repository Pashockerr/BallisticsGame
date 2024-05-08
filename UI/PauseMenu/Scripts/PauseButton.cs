using Godot;
using System;

namespace Scripts.PauseMenu{
	public partial class PauseButton : Button
	{
		[Export]
		private Container _pauseMenuContainer;
		public override void _Ready()
		{
			Pressed += () =>{
				_pauseMenuContainer.Show();
			};
		}
	}
}
