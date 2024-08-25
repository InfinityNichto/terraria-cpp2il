using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A90")]
	public interface IGroupOptionButton
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004FDC")]
		void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked);

		[global::Cpp2ILInjected.Token(Token = "0x6004FDD")]
		void SetBorderColor(Color color);
	}
}
