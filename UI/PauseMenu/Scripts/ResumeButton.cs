using Godot;
using System;

namespace Scripts.PauseMenu{
	public partial class ResumeButton : Button
	{
		[Export]
		private Container _pauseMenuContainer;
		public override void _Ready()
		{
			Pressed += () =>{
				_pauseMenuContainer.Hide();
			};
		}
	}
}
