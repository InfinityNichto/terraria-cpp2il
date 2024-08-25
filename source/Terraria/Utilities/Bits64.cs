using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F0")]
	public struct Bits64
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700060C")]
		public bool this[int i]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600309F")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF398", Offset = "0x12FF398", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60030A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF3B0", Offset = "0x12FF3B0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700060D")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x12FF3D4", Offset = "0x12FF3D4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshStrip", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF3E4", Offset = "0x12FF3E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator ulong(Bits64 b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF3E8", Offset = "0x12FF3E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator Bits64(ulong v)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003AA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ulong v;
	}
}
