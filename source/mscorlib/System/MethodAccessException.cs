using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000AB RID: 171
	[global::Cpp2ILInjected.Token(Token = "0x20000DB")]
	[global::System.Serializable]
	public class MethodAccessException : global::System.MemberAccessException
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00015B2D File Offset: 0x00013D2D
		[global::Cpp2ILInjected.Token(Token = "0x6000837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3733C", Offset = "0x1C3733C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MethodAccessException()
		{
			throw null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00015B30 File Offset: 0x00013D30
		[global::Cpp2ILInjected.Token(Token = "0x6000838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37398", Offset = "0x1C37398", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MethodAccessException(string message)
		{
			throw null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00015B33 File Offset: 0x00013D33
		[global::Cpp2ILInjected.Token(Token = "0x6000839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C373BC", Offset = "0x1C373BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MethodAccessException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
