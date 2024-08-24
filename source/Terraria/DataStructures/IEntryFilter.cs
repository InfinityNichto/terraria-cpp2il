using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x0200042A RID: 1066
	[global::Cpp2ILInjected.Token(Token = "0x2000625")]
	public interface IEntryFilter<T>
	{
		// Token: 0x060030D4 RID: 12500
		[global::Cpp2ILInjected.Token(Token = "0x60035F1")]
		bool FitsFilter(T entry);

		// Token: 0x060030D5 RID: 12501
		[global::Cpp2ILInjected.Token(Token = "0x60035F2")]
		string GetDisplayNameKey();

		// Token: 0x060030D6 RID: 12502
		[global::Cpp2ILInjected.Token(Token = "0x60035F3")]
		UIElement GetImage();

		// Token: 0x060030D7 RID: 12503
		[global::Cpp2ILInjected.Token(Token = "0x60035F4")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
