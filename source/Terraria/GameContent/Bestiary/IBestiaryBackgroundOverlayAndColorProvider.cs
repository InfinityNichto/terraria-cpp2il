using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200094D")]
	public interface IBestiaryBackgroundOverlayAndColorProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047B1")]
		Asset<Texture2D> GetBackgroundOverlayImage();

		[global::Cpp2ILInjected.Token(Token = "0x60047B2")]
		Color? GetBackgroundOverlayColor();

		[global::Cpp2ILInjected.Token(Token = "0x17000823")]
		float DisplayPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60047B3")]
			get;
		}
	}
}
