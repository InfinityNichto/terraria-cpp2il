using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002EB RID: 747
	[global::Cpp2ILInjected.Token(Token = "0x20003BF")]
	public struct Rgba1010102 : IPackedVector<uint>, IPackedVector, IEquatable<Rgba1010102>
	{
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000263D8 File Offset: 0x000245D8
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x000263DB File Offset: 0x000245DB
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700036C")]
		public uint PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019FE")]
			[global::Cpp2ILInjected.Address(RVA = "0xB40FC0", Offset = "0xB40FC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019FF")]
			[global::Cpp2ILInjected.Address(RVA = "0xB40FC8", Offset = "0xB40FC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000263DE File Offset: 0x000245DE
		[global::Cpp2ILInjected.Token(Token = "0x6001A00")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40FD0", Offset = "0xB40FD0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba1010102), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		public Rgba1010102(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000263E1 File Offset: 0x000245E1
		[global::Cpp2ILInjected.Token(Token = "0x6001A01")]
		[global::Cpp2ILInjected.Address(RVA = "0xB412F0", Offset = "0xB412F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba1010102), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		public Rgba1010102(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000263E4 File Offset: 0x000245E4
		[global::Cpp2ILInjected.Token(Token = "0x6001A02")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41308", Offset = "0xB41308", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba1010102), Member = "ToString", ReturnType = typeof(string))]
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

		// Token: 0x06001883 RID: 6275 RVA: 0x000263E7 File Offset: 0x000245E7
		[global::Cpp2ILInjected.Token(Token = "0x6001A03")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41384", Offset = "0xB41384", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba1010102), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000263EA File Offset: 0x000245EA
		[global::Cpp2ILInjected.Token(Token = "0x6001A04")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4139C", Offset = "0xB4139C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000263ED File Offset: 0x000245ED
		[global::Cpp2ILInjected.Token(Token = "0x6001A05")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41414", Offset = "0xB41414", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Rgba1010102 other)
		{
			throw null;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000263F0 File Offset: 0x000245F0
		[global::Cpp2ILInjected.Token(Token = "0x6001A06")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41424", Offset = "0xB41424", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rgba1010102), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000263F3 File Offset: 0x000245F3
		[global::Cpp2ILInjected.Token(Token = "0x6001A07")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41450", Offset = "0xB41450", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000263F6 File Offset: 0x000245F6
		[global::Cpp2ILInjected.Token(Token = "0x6001A08")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41458", Offset = "0xB41458", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			throw null;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000263F9 File Offset: 0x000245F9
		[global::Cpp2ILInjected.Token(Token = "0x6001A09")]
		[global::Cpp2ILInjected.Address(RVA = "0xB41464", Offset = "0xB41464", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			throw null;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000263FC File Offset: 0x000245FC
		[global::Cpp2ILInjected.Token(Token = "0x6001A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40FE8", Offset = "0xB40FE8", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba1010102), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba1010102), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rgba1010102), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static uint Pack(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x04002146 RID: 8518
		[global::Cpp2ILInjected.Token(Token = "0x40027A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
