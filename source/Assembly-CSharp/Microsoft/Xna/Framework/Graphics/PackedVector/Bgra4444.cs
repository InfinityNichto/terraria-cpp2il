using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002DD RID: 733
	[global::Cpp2ILInjected.Token(Token = "0x20003B0")]
	public struct Bgra4444 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra4444>
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x00026216 File Offset: 0x00024416
		[global::Cpp2ILInjected.Token(Token = "0x6001964")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC864C", Offset = "0xAC864C", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra4444), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra4444), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra4444), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
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

		// Token: 0x060017E5 RID: 6117 RVA: 0x00026219 File Offset: 0x00024419
		[global::Cpp2ILInjected.Token(Token = "0x6001965")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC891C", Offset = "0xAC891C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra4444), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgra4444(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0002621C File Offset: 0x0002441C
		[global::Cpp2ILInjected.Token(Token = "0x6001966")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8934", Offset = "0xAC8934", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra4444), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgra4444(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0002621F File Offset: 0x0002441F
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x00026222 File Offset: 0x00024422
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000360")]
		public ushort PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001967")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC894C", Offset = "0xAC894C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001968")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC8954", Offset = "0xAC8954", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00026225 File Offset: 0x00024425
		[global::Cpp2ILInjected.Token(Token = "0x6001969")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC895C", Offset = "0xAC895C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgra4444), Member = "ToString", ReturnType = typeof(string))]
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

		// Token: 0x060017EA RID: 6122 RVA: 0x00026228 File Offset: 0x00024428
		[global::Cpp2ILInjected.Token(Token = "0x600196A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC89C4", Offset = "0xAC89C4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra4444), Member = "Pack", MemberParameters = new object[]
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

		// Token: 0x060017EB RID: 6123 RVA: 0x0002622B File Offset: 0x0002442B
		[global::Cpp2ILInjected.Token(Token = "0x600196B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC89DC", Offset = "0xAC89DC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0002622E File Offset: 0x0002442E
		[global::Cpp2ILInjected.Token(Token = "0x600196C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8A64", Offset = "0xAC8A64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Bgra4444 other)
		{
			throw null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00026231 File Offset: 0x00024431
		[global::Cpp2ILInjected.Token(Token = "0x600196D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8A74", Offset = "0xAC8A74", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgra4444), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00026234 File Offset: 0x00024434
		[global::Cpp2ILInjected.Token(Token = "0x600196E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8AA0", Offset = "0xAC8AA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00026237 File Offset: 0x00024437
		[global::Cpp2ILInjected.Token(Token = "0x600196F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8A54", Offset = "0xAC8A54", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Bgra4444 lhs, Bgra4444 rhs)
		{
			throw null;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0002623A File Offset: 0x0002443A
		[global::Cpp2ILInjected.Token(Token = "0x6001970")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8AA8", Offset = "0xAC8AA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Bgra4444 lhs, Bgra4444 rhs)
		{
			throw null;
		}

		// Token: 0x0400213B RID: 8507
		[global::Cpp2ILInjected.Token(Token = "0x400279B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ushort _packedValue;
	}
}
