using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200095F")]
	public interface IFilterInfoProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004802")]
		UIElement GetFilterImage();

		[global::Cpp2ILInjected.Token(Token = "0x6004803")]
		string GetDisplayNameKey();

		[global::Cpp2ILInjected.Token(Token = "0x6004804")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
