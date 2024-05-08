using Godot;
using System;

namespace Scripts{
	public partial class SwitchLevelButton : Button
	{
		[Export]
		private string _levelName = "MainMenu";
		public override void _Ready()
		{
			Pressed += () =>{
				GetTree().ChangeSceneToFile($"res://Levels/{_levelName}/{_levelName}.tscn");
			};
		}
	}
}

