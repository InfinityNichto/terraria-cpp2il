using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002DB RID: 731
	[global::Cpp2ILInjected.Token(Token = "0x20003AE")]
	public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8>
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000261C5 File Offset: 0x000243C5
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x000261C8 File Offset: 0x000243C8
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

		// Token: 0x060017CB RID: 6091 RVA: 0x000261CB File Offset: 0x000243CB
		[global::Cpp2ILInjected.Token(Token = "0x600194B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7F74", Offset = "0xAC7F74", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alpha8), Member = "Pack", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte))]
		public Alpha8(float alpha)
		{
			throw null;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000261CE File Offset: 0x000243CE
		[global::Cpp2ILInjected.Token(Token = "0x600194C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8080", Offset = "0xAC8080", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float ToAlpha()
		{
			throw null;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000261D1 File Offset: 0x000243D1
		[global::Cpp2ILInjected.Token(Token = "0x600194D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8098", Offset = "0xAC8098", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alpha8), Member = "Pack", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000261D4 File Offset: 0x000243D4
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

		// Token: 0x060017CF RID: 6095 RVA: 0x000261D7 File Offset: 0x000243D7
		[global::Cpp2ILInjected.Token(Token = "0x600194F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8100", Offset = "0xAC8100", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x000261DA File Offset: 0x000243DA
		[global::Cpp2ILInjected.Token(Token = "0x6001950")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8178", Offset = "0xAC8178", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Alpha8 other)
		{
			throw null;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000261DD File Offset: 0x000243DD
		[global::Cpp2ILInjected.Token(Token = "0x6001951")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8188", Offset = "0xAC8188", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000261E0 File Offset: 0x000243E0
		[global::Cpp2ILInjected.Token(Token = "0x6001952")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81B8", Offset = "0xAC81B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000261E3 File Offset: 0x000243E3
		[global::Cpp2ILInjected.Token(Token = "0x6001953")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81C0", Offset = "0xAC81C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Alpha8 lhs, Alpha8 rhs)
		{
			throw null;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000261E6 File Offset: 0x000243E6
		[global::Cpp2ILInjected.Token(Token = "0x6001954")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81D0", Offset = "0xAC81D0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Alpha8 lhs, Alpha8 rhs)
		{
			throw null;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000261E9 File Offset: 0x000243E9
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

		// Token: 0x04002139 RID: 8505
		[global::Cpp2ILInjected.Token(Token = "0x4002799")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte packedValue;
	}
}
