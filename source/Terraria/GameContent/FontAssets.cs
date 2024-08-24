using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x02000549 RID: 1353
	[global::Cpp2ILInjected.Token(Token = "0x20007C5")]
	public static class FontAssets
	{
		// Token: 0x060039BA RID: 14778 RVA: 0x0002C4FE File Offset: 0x0002A6FE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004090")]
		[global::Cpp2ILInjected.Address(RVA = "0x7717A8", Offset = "0x7717A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static FontAssets()
		{
			throw null;
		}

		// Token: 0x040068DC RID: 26844
		[global::Cpp2ILInjected.Token(Token = "0x4007E41")]
		public static Asset<SpriteFont> ItemStack;

		// Token: 0x040068DD RID: 26845
		[global::Cpp2ILInjected.Token(Token = "0x4007E42")]
		public static Asset<SpriteFont> MouseText;

		// Token: 0x040068DE RID: 26846
		[global::Cpp2ILInjected.Token(Token = "0x4007E43")]
		public static Asset<SpriteFont> DeathText;

		// Token: 0x040068DF RID: 26847
		[global::Cpp2ILInjected.Token(Token = "0x4007E44")]
		public static Asset<SpriteFont>[] CombatText;
	}
}
