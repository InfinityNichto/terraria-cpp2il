using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002DC RID: 732
	[global::Cpp2ILInjected.Token(Token = "0x20003AF")]
	public struct Bgr565 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgr565>
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x000261EC File Offset: 0x000243EC
		[global::Cpp2ILInjected.Token(Token = "0x6001956")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC81E0", Offset = "0xAC81E0", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static ushort Pack(float x, float y, float z)
		{
			throw null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000261EF File Offset: 0x000243EF
		[global::Cpp2ILInjected.Token(Token = "0x6001957")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8434", Offset = "0xAC8434", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgr565), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgr565(float x, float y, float z)
		{
			throw null;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000261F2 File Offset: 0x000243F2
		[global::Cpp2ILInjected.Token(Token = "0x6001958")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC844C", Offset = "0xAC844C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgr565), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ushort))]
		public Bgr565(Vector3 vector)
		{
			throw null;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000261F5 File Offset: 0x000243F5
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x000261F8 File Offset: 0x000243F8
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700035F")]
		public ushort PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001959")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC8464", Offset = "0xAC8464", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600195A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC846C", Offset = "0xAC846C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000261FB File Offset: 0x000243FB
		[global::Cpp2ILInjected.Token(Token = "0x600195B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8474", Offset = "0xAC8474", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bgr565), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector3 ToVector3()
		{
			throw null;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x000261FE File Offset: 0x000243FE
		[global::Cpp2ILInjected.Token(Token = "0x600195C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC84DC", Offset = "0xAC84DC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00026201 File Offset: 0x00024401
		[global::Cpp2ILInjected.Token(Token = "0x600195D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC853C", Offset = "0xAC853C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgr565), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			throw null;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00026204 File Offset: 0x00024404
		[global::Cpp2ILInjected.Token(Token = "0x600195E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8570", Offset = "0xAC8570", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00026207 File Offset: 0x00024407
		[global::Cpp2ILInjected.Token(Token = "0x600195F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC85F8", Offset = "0xAC85F8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Bgr565 other)
		{
			throw null;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0002620A File Offset: 0x0002440A
		[global::Cpp2ILInjected.Token(Token = "0x6001960")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8608", Offset = "0xAC8608", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bgr565), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0002620D File Offset: 0x0002440D
		[global::Cpp2ILInjected.Token(Token = "0x6001961")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC8634", Offset = "0xAC8634", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00026210 File Offset: 0x00024410
		[global::Cpp2ILInjected.Token(Token = "0x6001962")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC85E8", Offset = "0xAC85E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Bgr565 lhs, Bgr565 rhs)
		{
			throw null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00026213 File Offset: 0x00024413
		[global::Cpp2ILInjected.Token(Token = "0x6001963")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC863C", Offset = "0xAC863C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Bgr565 lhs, Bgr565 rhs)
		{
			throw null;
		}

		// Token: 0x0400213A RID: 8506
		[global::Cpp2ILInjected.Token(Token = "0x400279A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ushort _packedValue;
	}
}
