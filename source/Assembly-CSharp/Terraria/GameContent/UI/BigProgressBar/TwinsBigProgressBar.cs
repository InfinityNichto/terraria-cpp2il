using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000702 RID: 1794
	[global::Cpp2ILInjected.Token(Token = "0x2000AF0")]
	public class TwinsBigProgressBar : IBigProgressBar
	{
		// Token: 0x060045A6 RID: 17830 RVA: 0x0002E76F File Offset: 0x0002C96F
		[global::Cpp2ILInjected.Token(Token = "0x6005219")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A3FC", Offset = "0x93A3FC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadTextureIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x0002E772 File Offset: 0x0002C972
		[global::Cpp2ILInjected.Token(Token = "0x600521A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A520", Offset = "0x93A520", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBossBar), Member = "Draw", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x0002E775 File Offset: 0x0002C975
		[global::Cpp2ILInjected.Token(Token = "0x600521B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A620", Offset = "0x93A620", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TwinsBigProgressBar()
		{
			throw null;
		}

		// Token: 0x04007120 RID: 28960
		[global::Cpp2ILInjected.Token(Token = "0x4008A72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007121 RID: 28961
		[global::Cpp2ILInjected.Token(Token = "0x4008A73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _headIndex;
	}
}
