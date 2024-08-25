using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200044C")]
	public struct NPCSpawnParams
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400367F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float? sizeScaleOverride;

		[global::Cpp2ILInjected.Token(Token = "0x4003680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int? playerCountForMultiplayerDifficultyOverride;

		[global::Cpp2ILInjected.Token(Token = "0x4003681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public GameModeData gameModeData;

		[global::Cpp2ILInjected.Token(Token = "0x4003682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float? strengthMultiplierOverride;
	}
}
