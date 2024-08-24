using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002DE RID: 734
	[global::Cpp2ILInjected.Token(Token = "0x20003B1")]
	public struct Bgra5551 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra5551>
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0002623D File Offset: 0x0002443D
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x00026240 File Offset: 0x00024440
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000361")]
		public ushort PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001971")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC8AB8", Offset = "0xAC8AB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001972")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC8AC0", Offset = "0xAC8AC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00026243 File Offset: 0x00024443
		[global::Cpp2ILInjected.Token(Token = "0x6001973")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8AC8", Offset = "0xAC8AC8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra5551), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgra5551(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00026246 File Offset: 0x00024446
		[global::Cpp2ILInjected.Token(Token = "0x6001974")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8DE0", Offset = "0xAC8DE0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra5551), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgra5551(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00026249 File Offset: 0x00024449
		[global::Cpp2ILInjected.Token(Token = "0x6001975")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8DF8", Offset = "0xAC8DF8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra5551), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x060017F6 RID: 6134 RVA: 0x0002624C File Offset: 0x0002444C
		[global::Cpp2ILInjected.Token(Token = "0x6001976")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8E58", Offset = "0xAC8E58", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra5551), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0002624F File Offset: 0x0002444F
		[global::Cpp2ILInjected.Token(Token = "0x6001977")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8E70", Offset = "0xAC8E70", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00026252 File Offset: 0x00024452
		[global::Cpp2ILInjected.Token(Token = "0x6001978")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8EE8", Offset = "0xAC8EE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Bgra5551 other)
		{
			throw null;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00026255 File Offset: 0x00024455
		[global::Cpp2ILInjected.Token(Token = "0x6001979")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8EF8", Offset = "0xAC8EF8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra5551), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00026258 File Offset: 0x00024458
		[global::Cpp2ILInjected.Token(Token = "0x600197A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8F24", Offset = "0xAC8F24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0002625B File Offset: 0x0002445B
		[global::Cpp2ILInjected.Token(Token = "0x600197B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8F2C", Offset = "0xAC8F2C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Bgra5551 lhs, Bgra5551 rhs)
		{
			throw null;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0002625E File Offset: 0x0002445E
		[global::Cpp2ILInjected.Token(Token = "0x600197C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8F3C", Offset = "0xAC8F3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Bgra5551 lhs, Bgra5551 rhs)
		{
			throw null;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00026261 File Offset: 0x00024461
		[global::Cpp2ILInjected.Token(Token = "0x600197D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8AE0", Offset = "0xAC8AE0", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra5551), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra5551), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra5551), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static ushort Pack(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x0400213C RID: 8508
		[global::Cpp2ILInjected.Token(Token = "0x400279C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ushort packedValue;
	}
}
