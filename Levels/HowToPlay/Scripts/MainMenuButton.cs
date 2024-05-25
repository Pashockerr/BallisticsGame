using Godot;
using System;

namespace Scripts{
	public partial class MainMenuButton : Button
	{
		public override void _Ready()
		{
			Pressed += () =>{
				Engine.TimeScale = 1;
				GetTree().ChangeSceneToFile($"res://Levels/MainMenu/MainMenu.tscn");
			};
		}
	}
}
