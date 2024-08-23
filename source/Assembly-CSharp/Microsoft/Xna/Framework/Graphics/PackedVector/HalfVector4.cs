using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002E3 RID: 739
	[global::Cpp2ILInjected.Token(Token = "0x20003B7")]
	public struct HalfVector4 : IPackedVector<ulong>, IPackedVector, IEquatable<HalfVector4>
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x000262E5 File Offset: 0x000244E5
		[global::Cpp2ILInjected.Token(Token = "0x60019A9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC99F8", Offset = "0xAC99F8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector4), Member = "PackHelper", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		public HalfVector4(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000262E8 File Offset: 0x000244E8
		[global::Cpp2ILInjected.Token(Token = "0x60019AA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9A8C", Offset = "0xAC9A8C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector4), Member = "PackHelper", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		public HalfVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000262EB File Offset: 0x000244EB
		[global::Cpp2ILInjected.Token(Token = "0x60019AB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9AB8", Offset = "0xAC9AB8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector4), Member = "PackHelper", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000262EE File Offset: 0x000244EE
		[global::Cpp2ILInjected.Token(Token = "0x60019AC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9A2C", Offset = "0xAC9A2C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		private static ulong PackHelper(ref Vector4 vector)
		{
			throw null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000262F1 File Offset: 0x000244F1
		[global::Cpp2ILInjected.Token(Token = "0x60019AD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9AE4", Offset = "0xAC9AE4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x000262F4 File Offset: 0x000244F4
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x000262F7 File Offset: 0x000244F7
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000365")]
		public ulong PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019AE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC9B60", Offset = "0xAC9B60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019AF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC9B68", Offset = "0xAC9B68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x000262FA File Offset: 0x000244FA
		[global::Cpp2ILInjected.Token(Token = "0x60019B0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9B70", Offset = "0xAC9B70", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector4), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000262FD File Offset: 0x000244FD
		[global::Cpp2ILInjected.Token(Token = "0x60019B1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9B9C", Offset = "0xAC9B9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00026300 File Offset: 0x00024500
		[global::Cpp2ILInjected.Token(Token = "0x60019B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9BA4", Offset = "0xAC9BA4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Equals", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00026303 File Offset: 0x00024503
		[global::Cpp2ILInjected.Token(Token = "0x60019B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9C20", Offset = "0xAC9C20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Equals", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(bool))]
		public bool Equals(HalfVector4 other)
		{
			throw null;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00026306 File Offset: 0x00024506
		[global::Cpp2ILInjected.Token(Token = "0x60019B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9C28", Offset = "0xAC9C28", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Equals", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(bool))]
		public static bool operator ==(HalfVector4 a, HalfVector4 b)
		{
			throw null;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00026309 File Offset: 0x00024509
		[global::Cpp2ILInjected.Token(Token = "0x60019B5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9C48", Offset = "0xAC9C48", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Equals", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(bool))]
		public static bool operator !=(HalfVector4 a, HalfVector4 b)
		{
			throw null;
		}

		// Token: 0x04002140 RID: 8512
		[global::Cpp2ILInjected.Token(Token = "0x40027A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ulong packedValue;
	}
}
