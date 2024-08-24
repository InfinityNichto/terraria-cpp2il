using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000338 RID: 824
	[global::Cpp2ILInjected.Token(Token = "0x200044C")]
	public struct NPCSpawnParams
	{
		// Token: 0x060026C6 RID: 9926 RVA: 0x00028E89 File Offset: 0x00027089
		[global::Cpp2ILInjected.Token(Token = "0x6002966")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AE10", Offset = "0x115AE10", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaultsFromNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaults_ForNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NPCSpawnParams WithScale(float scaleOverride)
		{
			throw null;
		}

		// Token: 0x04002EBA RID: 11962
		[global::Cpp2ILInjected.Token(Token = "0x400367F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float? sizeScaleOverride;

		// Token: 0x04002EBB RID: 11963
		[global::Cpp2ILInjected.Token(Token = "0x4003680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int? playerCountForMultiplayerDifficultyOverride;

		// Token: 0x04002EBC RID: 11964
		[global::Cpp2ILInjected.Token(Token = "0x4003681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public GameModeData gameModeData;

		// Token: 0x04002EBD RID: 11965
		[global::Cpp2ILInjected.Token(Token = "0x4003682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float? strengthMultiplierOverride;
	}
}
