using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000709 RID: 1801
	[global::Cpp2ILInjected.Token(Token = "0x2000AF7")]
	public class MartianSaucerBigProgressBar : IBigProgressBar
	{
		// Token: 0x060045C3 RID: 17859 RVA: 0x0002E7BD File Offset: 0x0002C9BD
		[global::Cpp2ILInjected.Token(Token = "0x6005236")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B278", Offset = "0x93B278", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public MartianSaucerBigProgressBar()
		{
			throw null;
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x0002E7C0 File Offset: 0x0002C9C0
		[global::Cpp2ILInjected.Token(Token = "0x6005237")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B398", Offset = "0x93B398", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSaucerBigProgressBar), Member = "TryFindingAnotherMartianSaucerPiece", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetMatchingSpawnParams", ReturnType = typeof(NPCSpawnParams))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x0002E7C3 File Offset: 0x0002C9C3
		[global::Cpp2ILInjected.Token(Token = "0x6005238")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B6B4", Offset = "0x93B6B4", Length = "0x138")]
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

		// Token: 0x060045C6 RID: 17862 RVA: 0x0002E7C6 File Offset: 0x0002C9C6
		[global::Cpp2ILInjected.Token(Token = "0x6005239")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B5F4", Offset = "0x93B5F4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSaucerBigProgressBar), Member = "ValidateAndCollectNecessaryInfo", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool TryFindingAnotherMartianSaucerPiece(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x04007127 RID: 28967
		[global::Cpp2ILInjected.Token(Token = "0x4008A79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007128 RID: 28968
		[global::Cpp2ILInjected.Token(Token = "0x4008A7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _referenceDummy;

		// Token: 0x04007129 RID: 28969
		[global::Cpp2ILInjected.Token(Token = "0x4008A7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HashSet<int> ValidIds;

		// Token: 0x0400712A RID: 28970
		[global::Cpp2ILInjected.Token(Token = "0x4008A7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private HashSet<int> ValidIdsToScanHp;
	}
}
