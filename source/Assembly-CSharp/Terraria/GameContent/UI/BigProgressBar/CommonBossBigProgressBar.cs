using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FA RID: 1786
	[global::Cpp2ILInjected.Token(Token = "0x2000AE8")]
	public class CommonBossBigProgressBar : IBigProgressBar
	{
		// Token: 0x0600458B RID: 17803 RVA: 0x0002E71E File Offset: 0x0002C91E
		[global::Cpp2ILInjected.Token(Token = "0x60051FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x938E38", Offset = "0x938E38", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadTextureIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x0002E721 File Offset: 0x0002C921
		[global::Cpp2ILInjected.Token(Token = "0x60051FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x938EF0", Offset = "0x938EF0", Length = "0x100")]
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

		// Token: 0x0600458D RID: 17805 RVA: 0x0002E724 File Offset: 0x0002C924
		[global::Cpp2ILInjected.Token(Token = "0x6005200")]
		[global::Cpp2ILInjected.Address(RVA = "0x938FF0", Offset = "0x938FF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CommonBossBigProgressBar()
		{
			throw null;
		}

		// Token: 0x0400710E RID: 28942
		[global::Cpp2ILInjected.Token(Token = "0x4008A60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x0400710F RID: 28943
		[global::Cpp2ILInjected.Token(Token = "0x4008A61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _headIndex;
	}
}
