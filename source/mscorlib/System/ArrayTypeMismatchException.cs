using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000063 RID: 99
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	[global::System.Serializable]
	public class ArrayTypeMismatchException : global::System.SystemException
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00014F63 File Offset: 0x00013163
		[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6254", Offset = "0x1BB6254", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(global::System.ArrayTypeMismatchException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArrayTypeMismatchException()
		{
			throw null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00014F66 File Offset: 0x00013166
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB62B0", Offset = "0x1BB62B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected ArrayTypeMismatchException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
