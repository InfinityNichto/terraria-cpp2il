using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	[global::Cpp2ILInjected.Token(Token = "0x20003B2")]
	public struct Byte4 : IPackedVector<uint>, IPackedVector, IEquatable<Byte4>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600197E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8F4C", Offset = "0xAC8F4C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Byte4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(uint))]
		public Byte4(Vector4 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600197F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9250", Offset = "0xAC9250", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Byte4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(uint))]
		public Byte4(float x, float y, float z, float w)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001980")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9284", Offset = "0xAC9284", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Byte4 a, Byte4 b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001981")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9290", Offset = "0xAC9290", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Byte4 a, Byte4 b)
		{
			throw null;
		}

		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000362")]
		public uint PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001982")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC929C", Offset = "0xAC929C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001983")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC92A4", Offset = "0xAC92A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001984")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC92AC", Offset = "0xAC92AC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001985")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9324", Offset = "0xAC9324", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Byte4 other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001986")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9334", Offset = "0xAC9334", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001987")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC933C", Offset = "0xAC933C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001988")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8F78", Offset = "0xAC8F78", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Byte4), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Byte4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Byte4), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static uint Pack(ref Vector4 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001989")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9388", Offset = "0xAC9388", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Byte4), Member = "Pack", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(uint))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC93B4", Offset = "0xAC93B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector4 ToVector4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400279D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
