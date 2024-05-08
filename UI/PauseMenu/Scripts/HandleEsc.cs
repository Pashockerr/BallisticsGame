using Godot;
using System;

namespace Scripts.PauseMenu{
	public partial class HandleEsc : Container
	{
        public override void _Input(InputEvent e)
        {
            if(e is InputEventKey key){
				if(key.IsPressed() && key.Keycode == Key.Escape){
					if(Visible){
						Hide();
					}
					else{
						Show();
					}
				}
			}
        }
    }
}