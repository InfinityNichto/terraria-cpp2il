using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006B6 RID: 1718
	[global::Cpp2ILInjected.Token(Token = "0x2000A90")]
	public interface IGroupOptionButton
	{
		// Token: 0x060043A2 RID: 17314
		[global::Cpp2ILInjected.Token(Token = "0x6004FDC")]
		void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked);

		// Token: 0x060043A3 RID: 17315
		[global::Cpp2ILInjected.Token(Token = "0x6004FDD")]
		void SetBorderColor(Color color);
	}
}
