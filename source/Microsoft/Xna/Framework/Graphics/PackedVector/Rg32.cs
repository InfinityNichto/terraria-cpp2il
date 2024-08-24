using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002EA RID: 746
	[global::Cpp2ILInjected.Token(Token = "0x20003BE")]
	public struct Rg32 : IPackedVector<uint>, IPackedVector, IEquatable<Rg32>
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000263AE File Offset: 0x000245AE
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x000263B1 File Offset: 0x000245B1
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700036B")]
		public uint PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019F0")]
			[global::Cpp2ILInjected.Address(RVA = "0xB40C60", Offset = "0xB40C60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019F1")]
			[global::Cpp2ILInjected.Address(RVA = "0xB40C68", Offset = "0xB40C68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x000263B4 File Offset: 0x000245B4
		[global::Cpp2ILInjected.Token(Token = "0x60019F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40C70", Offset = "0xB40C70", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rg32), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		public Rg32(float x, float y)
		{
			throw null;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000263B7 File Offset: 0x000245B7
		[global::Cpp2ILInjected.Token(Token = "0x60019F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40E44", Offset = "0xB40E44", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rg32), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		public Rg32(Vector2 vector)
		{
			throw null;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000263BA File Offset: 0x000245BA
		[global::Cpp2ILInjected.Token(Token = "0x60019F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40E5C", Offset = "0xB40E5C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector2 ToVector2()
		{
			throw null;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000263BD File Offset: 0x000245BD
		[global::Cpp2ILInjected.Token(Token = "0x60019F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40EA8", Offset = "0xB40EA8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rg32), Member = "Pack", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000263C0 File Offset: 0x000245C0
		[global::Cpp2ILInjected.Token(Token = "0x60019F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40EC0", Offset = "0xB40EC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rg32), Member = "ToVector2", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			throw null;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000263C3 File Offset: 0x000245C3
		[global::Cpp2ILInjected.Token(Token = "0x60019F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40EF8", Offset = "0xB40EF8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000263C6 File Offset: 0x000245C6
		[global::Cpp2ILInjected.Token(Token = "0x60019F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40F70", Offset = "0xB40F70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Rg32 other)
		{
			throw null;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000263C9 File Offset: 0x000245C9
		[global::Cpp2ILInjected.Token(Token = "0x60019F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40F80", Offset = "0xB40F80", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rg32), Member = "ToVector2", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000263CC File Offset: 0x000245CC
		[global::Cpp2ILInjected.Token(Token = "0x60019FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40FA0", Offset = "0xB40FA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000263CF File Offset: 0x000245CF
		[global::Cpp2ILInjected.Token(Token = "0x60019FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40FA8", Offset = "0xB40FA8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Rg32 lhs, Rg32 rhs)
		{
			throw null;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000263D2 File Offset: 0x000245D2
		[global::Cpp2ILInjected.Token(Token = "0x60019FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40FB4", Offset = "0xB40FB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Rg32 lhs, Rg32 rhs)
		{
			throw null;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000263D5 File Offset: 0x000245D5
		[global::Cpp2ILInjected.Token(Token = "0x60019FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xB40C88", Offset = "0xB40C88", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rg32), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static uint Pack(float x, float y)
		{
			throw null;
		}

		// Token: 0x04002145 RID: 8517
		[global::Cpp2ILInjected.Token(Token = "0x40027A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
