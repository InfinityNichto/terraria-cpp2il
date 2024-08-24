using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000700 RID: 1792
	[global::Cpp2ILInjected.Token(Token = "0x2000AEE")]
	public class NeverValidProgressBar : IBigProgressBar
	{
		// Token: 0x060045A1 RID: 17825 RVA: 0x0002E760 File Offset: 0x0002C960
		[global::Cpp2ILInjected.Token(Token = "0x6005214")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A3E0", Offset = "0x93A3E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x0002E763 File Offset: 0x0002C963
		[global::Cpp2ILInjected.Token(Token = "0x6005215")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A3E8", Offset = "0x93A3E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x0002E766 File Offset: 0x0002C966
		[global::Cpp2ILInjected.Token(Token = "0x6005216")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A3EC", Offset = "0x93A3EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NeverValidProgressBar()
		{
			throw null;
		}
	}
}
