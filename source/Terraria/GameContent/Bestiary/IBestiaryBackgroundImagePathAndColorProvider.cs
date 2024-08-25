using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200094B")]
	public interface IBestiaryBackgroundImagePathAndColorProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047AE")]
		Asset<Texture2D> GetBackgroundImage();

		[global::Cpp2ILInjected.Token(Token = "0x60047AF")]
		Color? GetBackgroundColor();
	}
}
