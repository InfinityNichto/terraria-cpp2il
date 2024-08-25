using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Terraria.GameContent.Biomes;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004ED")]
	public class WorldGenRange
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700060A")]
		public int ScaledMinimum
		{
			[global::Cpp2ILInjected.Token(Token = "0x600308E")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FECE0", Offset = "0x12FECE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700060B")]
		public int ScaledMaximum
		{
			[global::Cpp2ILInjected.Token(Token = "0x600308F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FEDC4", Offset = "0x12FEDC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "get_MaximumWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenRange), Member = "ScaleValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003090")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FEDCC", Offset = "0x12FEDCC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WorldGenRange(int minimum, int maximum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003091")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FEDF8", Offset = "0x12FEDF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_1", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_21", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_22", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_58", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenRange), Member = "ScaleValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public int GetRandom(UnifiedRandom random)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003092")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FECE8", Offset = "0x12FECE8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenRange), Member = "get_ScaledMaximum", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenRange), Member = "GetRandom", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int ScaleValue(int value)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003093")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FEE3C", Offset = "0x12FEE3C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static WorldGenRange()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003A9C")]
		public static readonly WorldGenRange Empty;

		[JsonProperty("Min")]
		[global::Cpp2ILInjected.Token(Token = "0x4003A9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int Minimum;

		[JsonProperty("Max")]
		[global::Cpp2ILInjected.Token(Token = "0x4003A9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly int Maximum;

		[JsonConverter(typeof(StringEnumConverter))]
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4003A9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly WorldGenRange.ScalingMode ScaleWith;

		[global::Cpp2ILInjected.Token(Token = "0x20004EE")]
		public enum ScalingMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003AA1")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4003AA2")]
			WorldArea,
			[global::Cpp2ILInjected.Token(Token = "0x4003AA3")]
			WorldWidth
		}
	}
}
