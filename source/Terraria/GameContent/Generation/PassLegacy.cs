using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	[global::Cpp2ILInjected.Token(Token = "0x20008D6")]
	public class PassLegacy : GenPass
	{
		[global::Cpp2ILInjected.Token(Token = "0x600459F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BCA90", Offset = "0x7BCA90", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddGenerationPass", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PassLegacy), Member = "GetWeight", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PassLegacy(string name, WorldGenLegacyMethod method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BCBB4", Offset = "0x7BCBB4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "AddGenerationPass", MemberParameters = new object[]
		{
			typeof(string),
			typeof(double),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(double)
		}, ReturnType = typeof(void))]
		public PassLegacy(string name, WorldGenLegacyMethod method, double weight)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BCB10", Offset = "0x7BCB10", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PassLegacy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WorldGenLegacyMethod)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, float>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static float GetWeight(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BCBDC", Offset = "0x7BCBDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60045A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BCBF0", Offset = "0x7BCBF0", Length = "0x1DE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, float>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, float>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 109)]
		static PassLegacy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008208")]
		private static readonly Dictionary<string, float> _weightMap_135;

		[global::Cpp2ILInjected.Token(Token = "0x4008209")]
		private static readonly Dictionary<string, float> _weightMap;

		[global::Cpp2ILInjected.Token(Token = "0x400820A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly WorldGenLegacyMethod _method;
	}
}
