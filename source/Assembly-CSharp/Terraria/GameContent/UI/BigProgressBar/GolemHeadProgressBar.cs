using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FE RID: 1790
	[global::Cpp2ILInjected.Token(Token = "0x2000AEC")]
	public class GolemHeadProgressBar : IBigProgressBar
	{
		// Token: 0x06004598 RID: 17816 RVA: 0x0002E745 File Offset: 0x0002C945
		[global::Cpp2ILInjected.Token(Token = "0x600520B")]
		[global::Cpp2ILInjected.Address(RVA = "0x9398C4", Offset = "0x9398C4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public GolemHeadProgressBar()
		{
			throw null;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x0002E748 File Offset: 0x0002C948
		[global::Cpp2ILInjected.Token(Token = "0x600520C")]
		[global::Cpp2ILInjected.Address(RVA = "0x9399AC", Offset = "0x9399AC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolemHeadProgressBar), Member = "TryFindingAnotherGolemPiece", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetMatchingSpawnParams", ReturnType = typeof(NPCSpawnParams))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x0002E74B File Offset: 0x0002C94B
		[global::Cpp2ILInjected.Token(Token = "0x600520D")]
		[global::Cpp2ILInjected.Address(RVA = "0x939C10", Offset = "0x939C10", Length = "0x138")]
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

		// Token: 0x0600459B RID: 17819 RVA: 0x0002E74E File Offset: 0x0002C94E
		[global::Cpp2ILInjected.Token(Token = "0x600520E")]
		[global::Cpp2ILInjected.Address(RVA = "0x939B50", Offset = "0x939B50", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolemHeadProgressBar), Member = "ValidateAndCollectNecessaryInfo", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool TryFindingAnotherGolemPiece(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x04007116 RID: 28950
		[global::Cpp2ILInjected.Token(Token = "0x4008A68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007117 RID: 28951
		[global::Cpp2ILInjected.Token(Token = "0x4008A69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _referenceDummy;

		// Token: 0x04007118 RID: 28952
		[global::Cpp2ILInjected.Token(Token = "0x4008A6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HashSet<int> ValidIds;
	}
}
