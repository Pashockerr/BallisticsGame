using Godot;
using System;

namespace Scripts.MainMenu{
	public partial class QuitGameButton : Button
	{
		public override void _Ready()
		{
			Pressed += () =>{
				GetTree().Quit();
			};
		}
	}
}
