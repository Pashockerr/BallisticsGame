using Godot;
using System;

namespace Scripts.MainMenu{
	public partial class LevelsButton : Button
	{
		public override void _Ready()
		{
			Pressed += () =>{
				Engine.TimeScale = 1;
				GetTree().ChangeSceneToFile($"res://Levels/SelectLevels/SelectLevels.tscn");
			};
		}
	}
}
