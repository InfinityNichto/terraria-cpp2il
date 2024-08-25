using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004EC")]
	public class WorldGenerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003089")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE608", Offset = "0x12FE608", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WorldGenerator(int seed, WorldGenConfiguration configuration)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600308A")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE6A0", Offset = "0x12FE6A0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddGenerationPass", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddGenerationPass", MemberParameters = new object[] { typeof(GenPass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddGenerationPass", MemberParameters = new object[]
		{
			typeof(string),
			typeof(double),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Append(GenPass pass)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600308B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE750", Offset = "0x12FE750", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void LogGenSeedAtPoint(string tag)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600308C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE754", Offset = "0x12FE754", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SaveWorldAtPoint(string tag)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600308D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE758", Offset = "0x12FE758", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenerationProgress), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "CheckThreadTerminiate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenConfiguration), Member = "GetPassConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameConfiguration))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "ReleasePointers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public void GenerateWorld(GenerationProgress progress = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003A96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<GenPass> _passes;

		[global::Cpp2ILInjected.Token(Token = "0x4003A97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double _totalLoadWeight;

		[global::Cpp2ILInjected.Token(Token = "0x4003A98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int _seed;

		[global::Cpp2ILInjected.Token(Token = "0x4003A99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly WorldGenConfiguration _configuration;

		[global::Cpp2ILInjected.Token(Token = "0x4003A9A")]
		public static GenerationProgress CurrentGenerationProgress;

		[global::Cpp2ILInjected.Token(Token = "0x4003A9B")]
		public static bool TerminateWorldGen;
	}
}
