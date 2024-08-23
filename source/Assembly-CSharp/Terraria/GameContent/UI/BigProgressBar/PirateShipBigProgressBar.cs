using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000708 RID: 1800
	[global::Cpp2ILInjected.Token(Token = "0x2000AF6")]
	public class PirateShipBigProgressBar : IBigProgressBar
	{
		// Token: 0x060045BF RID: 17855 RVA: 0x0002E7B1 File Offset: 0x0002C9B1
		[global::Cpp2ILInjected.Token(Token = "0x6005232")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AD80", Offset = "0x93AD80", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PirateShipBigProgressBar()
		{
			throw null;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		[global::Cpp2ILInjected.Token(Token = "0x6005233")]
		[global::Cpp2ILInjected.Address(RVA = "0x93AE58", Offset = "0x93AE58", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PirateShipBigProgressBar), Member = "TryFindingAnotherPirateShipPiece", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetMatchingSpawnParams", ReturnType = typeof(NPCSpawnParams))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0002E7B7 File Offset: 0x0002C9B7
		[global::Cpp2ILInjected.Token(Token = "0x6005234")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B140", Offset = "0x93B140", Length = "0x138")]
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

		// Token: 0x060045C2 RID: 17858 RVA: 0x0002E7BA File Offset: 0x0002C9BA
		[global::Cpp2ILInjected.Token(Token = "0x6005235")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B080", Offset = "0x93B080", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PirateShipBigProgressBar), Member = "ValidateAndCollectNecessaryInfo", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool TryFindingAnotherPirateShipPiece(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x04007124 RID: 28964
		[global::Cpp2ILInjected.Token(Token = "0x4008A76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007125 RID: 28965
		[global::Cpp2ILInjected.Token(Token = "0x4008A77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _referenceDummy;

		// Token: 0x04007126 RID: 28966
		[global::Cpp2ILInjected.Token(Token = "0x4008A78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HashSet<int> ValidIds;
	}
}
