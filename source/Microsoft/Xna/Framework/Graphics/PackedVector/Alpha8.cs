using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	[global::Cpp2ILInjected.Token(Token = "0x20003AE")]
	public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8>
	{
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700035E")]
		public byte PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001949")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7F64", Offset = "0xAC7F64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600194A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7F6C", Offset = "0xAC7F6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7F74", Offset = "0xAC7F74", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alpha8), Member = "Pack", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte))]
		public Alpha8(float alpha)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8080", Offset = "0xAC8080", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float ToAlpha()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8098", Offset = "0xAC8098", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alpha8), Member = "Pack", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC80B4", Offset = "0xAC80B4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8100", Offset = "0xAC8100", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001950")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8178", Offset = "0xAC8178", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Alpha8 other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001951")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8188", Offset = "0xAC8188", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001952")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81B8", Offset = "0xAC81B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001953")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81C0", Offset = "0xAC81C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Alpha8 lhs, Alpha8 rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001954")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81D0", Offset = "0xAC81D0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Alpha8 lhs, Alpha8 rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001955")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7F8C", Offset = "0xAC7F8C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alpha8), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alpha8), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static byte Pack(float alpha)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002799")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte packedValue;
	}
}
