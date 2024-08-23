using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Numerics
{
	// Token: 0x02000467 RID: 1127
	[global::System.Runtime.CompilerServices.Intrinsic]
	[global::Cpp2ILInjected.Token(Token = "0x200052D")]
	public static class Vector
	{
		// Token: 0x06002483 RID: 9347 RVA: 0x0001AA95 File Offset: 0x00018C95
		[global::Cpp2ILInjected.Token(Token = "0x6002727")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4484", Offset = "0x15A4484", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
		{
			throw null;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x0001AA98 File Offset: 0x00018C98
		[global::Cpp2ILInjected.Token(Token = "0x170005A2")]
		public static bool IsHardwareAccelerated
		{
			[global::System.Runtime.CompilerServices.Intrinsic]
			[global::Cpp2ILInjected.Token(Token = "0x6002728")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9593C", Offset = "0x1B9593C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
			{
				typeof(ref char),
				typeof(int),
				typeof(ref char),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
			{
				typeof(ref char),
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "LastIndexOf", MemberParameters = new object[]
			{
				typeof(ref char),
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector<>), Member = "Equals", MemberParameters = new object[] { "System.Numerics.Vector`1<T>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector<>), Member = "Equals", MemberParameters = new object[] { "System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>" }, ReturnType = "System.Numerics.Vector`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0001AA9B File Offset: 0x00018C9B
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002729")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4424", Offset = "0x15A4424", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
		{
			throw null;
		}
	}
}
