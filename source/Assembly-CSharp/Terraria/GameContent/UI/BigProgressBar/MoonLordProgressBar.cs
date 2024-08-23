using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FF RID: 1791
	[global::Cpp2ILInjected.Token(Token = "0x2000AED")]
	public class MoonLordProgressBar : IBigProgressBar
	{
		// Token: 0x0600459C RID: 17820 RVA: 0x0002E751 File Offset: 0x0002C951
		[global::Cpp2ILInjected.Token(Token = "0x600520F")]
		[global::Cpp2ILInjected.Address(RVA = "0x939D48", Offset = "0x939D48", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public MoonLordProgressBar()
		{
			throw null;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x0002E754 File Offset: 0x0002C954
		[global::Cpp2ILInjected.Token(Token = "0x6005210")]
		[global::Cpp2ILInjected.Address(RVA = "0x939E40", Offset = "0x939E40", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordProgressBar), Member = "TryFindingAnotherMoonLordPiece", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x0002E757 File Offset: 0x0002C957
		[global::Cpp2ILInjected.Token(Token = "0x6005211")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A108", Offset = "0x93A108", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsInBadAI(NPC npc)
		{
			throw null;
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0002E75A File Offset: 0x0002C95A
		[global::Cpp2ILInjected.Token(Token = "0x6005212")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A2A8", Offset = "0x93A2A8", Length = "0x138")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0002E75D File Offset: 0x0002C95D
		[global::Cpp2ILInjected.Token(Token = "0x6005213")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A168", Offset = "0x93A168", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordProgressBar), Member = "ValidateAndCollectNecessaryInfo", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool TryFindingAnotherMoonLordPiece(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x04007119 RID: 28953
		[global::Cpp2ILInjected.Token(Token = "0x4008A6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x0400711A RID: 28954
		[global::Cpp2ILInjected.Token(Token = "0x4008A6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _referenceDummy;

		// Token: 0x0400711B RID: 28955
		[global::Cpp2ILInjected.Token(Token = "0x4008A6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HashSet<int> ValidIds;
	}
}
