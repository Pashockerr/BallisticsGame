using Godot;
using System;

namespace Scripts
{
	public partial class VerticalMeasureLine : Node2D
	{
		[Export]
		private Vector2 _startPosition;

		[Export]
		private float _height;

		[Export]
		private float _bumpersLength = 0;

		[Export]
		private float _verticalOffset = 0;

		[Export]
		private float _lineWidth = 3;

		[Export]
		private float _bumpersHorizontalOffset = 0;

		[Export]
		private float _labelVerticalOffset = 0;

		[Export]
		private float _labelHorizontalOffset = 0;

		[Export]
		private LabelSettings _labelSettings;
		private Font _labelFont;
		private int _labelFontSize;

		[Export]
		private Color _color = new Color
		{
			R = 1.0f,
			G = 1.0f,
			B = 1.0f,
			A = 1.0f
		};

		private Color _fontColor;
		public override void _Ready()
		{
			_labelFont = _labelSettings.Font;
			_labelFontSize = _labelSettings.FontSize;
			_fontColor = _labelSettings.FontColor;
			_labelVerticalOffset += _verticalOffset;
		}

        public override void _Draw()
        {
            var lP1 = _startPosition;
			var lP2 = new Vector2(lP1.X, lP1.Y - _height);

			var b1P1 = lP1;
			var b1P2 = lP1 + Vector2.Right * _bumpersLength;

			var b2P1 = lP2;
			var b2P2 = lP2 + Vector2.Right * _bumpersLength;

			b1P1 += Vector2.Right * _bumpersHorizontalOffset;
			b1P2 += Vector2.Right * _bumpersHorizontalOffset;
			b2P1 += Vector2.Right * _bumpersHorizontalOffset;
			b2P2 += Vector2.Right * _bumpersHorizontalOffset;

			DrawLine(lP1, lP2, _color, _lineWidth, true);
			DrawLine(b1P1, b1P2, _color, _lineWidth, true);
			DrawLine(b2P1, b2P2, _color, _lineWidth, true);

			var len = _height / 100;

			var labelText = $"H = {len}м";
			var labelSize = _labelFont.GetStringSize(labelText);
			var lX = _startPosition.X + _labelHorizontalOffset;
			var lY = _startPosition.Y - _height / 2 - _labelVerticalOffset;

			DrawString(_labelFont, new Vector2(lX, lY), labelText, fontSize: _labelFontSize, modulate: _fontColor);
        }
    }
}
