using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Effects;
using Terraria.Net;
using Terraria.Utilities;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x0200066D RID: 1645
	[global::Cpp2ILInjected.Token(Token = "0x20009F2")]
	public class NetAmbienceModule : NetModule
	{
		// Token: 0x060040E5 RID: 16613 RVA: 0x0002D98C File Offset: 0x0002BB8C
		[global::Cpp2ILInjected.Token(Token = "0x6004B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7D78", Offset = "0x8A7D78", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbienceServer), Member = "SpawnForPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static NetPacket SerializeSkyEntitySpawn(Player player, SkyEntityType type)
		{
			throw null;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0002D98F File Offset: 0x0002BB8F
		[global::Cpp2ILInjected.Token(Token = "0x6004B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7E78", Offset = "0x8A7E78", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "QueueMainThreadAction", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0002D992 File Offset: 0x0002BB92
		[global::Cpp2ILInjected.Token(Token = "0x6004B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7FDC", Offset = "0x8A7FDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetAmbienceModule()
		{
			throw null;
		}

		// Token: 0x02000A64 RID: 2660
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20009F3")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060050AF RID: 20655 RVA: 0x000303AA File Offset: 0x0002E5AA
			[global::Cpp2ILInjected.Token(Token = "0x6004B6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A7FD4", Offset = "0x8A7FD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass1_0()
			{
				throw null;
			}

			// Token: 0x060050B0 RID: 20656 RVA: 0x000303AD File Offset: 0x0002E5AD
			[global::Cpp2ILInjected.Token(Token = "0x6004B6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A7FE4", Offset = "0x8A7FE4", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void <Deserialize>b__0()
			{
				throw null;
			}

			// Token: 0x04008E46 RID: 36422
			[global::Cpp2ILInjected.Token(Token = "0x40085B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public byte playerId;

			// Token: 0x04008E47 RID: 36423
			[global::Cpp2ILInjected.Token(Token = "0x40085B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
			public SkyEntityType type;

			// Token: 0x04008E48 RID: 36424
			[global::Cpp2ILInjected.Token(Token = "0x40085B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int seed;
		}
	}
}
