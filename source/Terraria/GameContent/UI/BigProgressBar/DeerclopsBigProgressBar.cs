using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FB RID: 1787
	[global::Cpp2ILInjected.Token(Token = "0x2000AE9")]
	public class DeerclopsBigProgressBar : IBigProgressBar
	{
		// Token: 0x0600458E RID: 17806 RVA: 0x0002E727 File Offset: 0x0002C927
		[global::Cpp2ILInjected.Token(Token = "0x6005201")]
		[global::Cpp2ILInjected.Address(RVA = "0x938FF8", Offset = "0x938FF8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadTextureIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "IsDeerclopsHostile", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x0002E72A File Offset: 0x0002C92A
		[global::Cpp2ILInjected.Token(Token = "0x6005202")]
		[global::Cpp2ILInjected.Address(RVA = "0x9390DC", Offset = "0x9390DC", Length = "0x100")]
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

		// Token: 0x06004590 RID: 17808 RVA: 0x0002E72D File Offset: 0x0002C92D
		[global::Cpp2ILInjected.Token(Token = "0x6005203")]
		[global::Cpp2ILInjected.Address(RVA = "0x9391DC", Offset = "0x9391DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DeerclopsBigProgressBar()
		{
			throw null;
		}

		// Token: 0x04007110 RID: 28944
		[global::Cpp2ILInjected.Token(Token = "0x4008A62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007111 RID: 28945
		[global::Cpp2ILInjected.Token(Token = "0x4008A63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _headIndex;
	}
}
