using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Ambience
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AF8")]
	public class AmbientSkyDrawCache
	{
		[global::Cpp2ILInjected.Token(Token = "0x600523A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B7EC", Offset = "0x93B7EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetUnderworldInfo(int drawIndex, float scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600523B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B7FC", Offset = "0x93B7FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateOceanWaterLineForAmbience", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600523C")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B804", Offset = "0x93B804", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSkyDrawCache), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AmbientSkyDrawCache()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600523D")]
		[global::Cpp2ILInjected.Address(RVA = "0x93B85C", Offset = "0x93B85C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSkyDrawCache), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static AmbientSkyDrawCache()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A7D")]
		public static AmbientSkyDrawCache Instance;

		[global::Cpp2ILInjected.Token(Token = "0x4008A7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AmbientSkyDrawCache.UnderworldCache[] Underworld;

		[global::Cpp2ILInjected.Token(Token = "0x4008A7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public AmbientSkyDrawCache.OceanLineCache OceanLineInfo;

		[global::Cpp2ILInjected.Token(Token = "0x2000AF9")]
		public struct UnderworldCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008A80")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float Scale;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000AFA")]
		public struct OceanLineCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008A81")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float YScreenPosition;

			[global::Cpp2ILInjected.Token(Token = "0x4008A82")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float OceanOpacity;
		}
	}
}
