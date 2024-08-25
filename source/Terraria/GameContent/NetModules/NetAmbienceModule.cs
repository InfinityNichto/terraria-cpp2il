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
	[global::Cpp2ILInjected.Token(Token = "0x20009F2")]
	public class NetAmbienceModule : NetModule
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6004B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A7FDC", Offset = "0x8A7FDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetAmbienceModule()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20009F3")]
		private sealed class <>c__DisplayClass1_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004B6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8A7FD4", Offset = "0x8A7FD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass1_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40085B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public byte playerId;

			[global::Cpp2ILInjected.Token(Token = "0x40085B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
			public SkyEntityType type;

			[global::Cpp2ILInjected.Token(Token = "0x40085B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int seed;
		}
	}
}
