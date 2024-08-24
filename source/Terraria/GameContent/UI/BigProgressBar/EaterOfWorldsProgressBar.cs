using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FC RID: 1788
	[global::Cpp2ILInjected.Token(Token = "0x2000AEA")]
	public class EaterOfWorldsProgressBar : IBigProgressBar
	{
		// Token: 0x06004591 RID: 17809 RVA: 0x0002E730 File Offset: 0x0002C930
		[global::Cpp2ILInjected.Token(Token = "0x6005204")]
		[global::Cpp2ILInjected.Address(RVA = "0x9391E4", Offset = "0x9391E4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EaterOfWorldsProgressBar()
		{
			throw null;
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x0002E733 File Offset: 0x0002C933
		[global::Cpp2ILInjected.Token(Token = "0x6005205")]
		[global::Cpp2ILInjected.Address(RVA = "0x939248", Offset = "0x939248", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EaterOfWorldsProgressBar), Member = "TryFindingAnotherEOWPiece", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetEaterOfWorldsSegmentsCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetMatchingSpawnParams", ReturnType = typeof(NPCSpawnParams))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x0002E736 File Offset: 0x0002C936
		[global::Cpp2ILInjected.Token(Token = "0x6005206")]
		[global::Cpp2ILInjected.Address(RVA = "0x939464", Offset = "0x939464", Length = "0x138")]
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

		// Token: 0x06004594 RID: 17812 RVA: 0x0002E739 File Offset: 0x0002C939
		[global::Cpp2ILInjected.Token(Token = "0x6005207")]
		[global::Cpp2ILInjected.Address(RVA = "0x9393C8", Offset = "0x9393C8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EaterOfWorldsProgressBar), Member = "ValidateAndCollectNecessaryInfo", MemberParameters = new object[] { typeof(ref BigProgressBarInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool TryFindingAnotherEOWPiece(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x04007112 RID: 28946
		[global::Cpp2ILInjected.Token(Token = "0x4008A64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007113 RID: 28947
		[global::Cpp2ILInjected.Token(Token = "0x4008A65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _segmentForReference;
	}
}
