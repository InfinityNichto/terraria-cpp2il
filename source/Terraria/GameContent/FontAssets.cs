using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007C5")]
	public static class FontAssets
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004090")]
		[global::Cpp2ILInjected.Address(RVA = "0x7717A8", Offset = "0x7717A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static FontAssets()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E41")]
		public static Asset<SpriteFont> ItemStack;

		[global::Cpp2ILInjected.Token(Token = "0x4007E42")]
		public static Asset<SpriteFont> MouseText;

		[global::Cpp2ILInjected.Token(Token = "0x4007E43")]
		public static Asset<SpriteFont> DeathText;

		[global::Cpp2ILInjected.Token(Token = "0x4007E44")]
		public static Asset<SpriteFont>[] CombatText;
	}
}
