using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000079 RID: 121
	[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
	[global::System.Serializable]
	public class DllNotFoundException : global::System.TypeLoadException
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00015620 File Offset: 0x00013820
		[global::Cpp2ILInjected.Token(Token = "0x6000647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D500", Offset = "0x1C1D500", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DllNotFoundException()
		{
			throw null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00015623 File Offset: 0x00013823
		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D55C", Offset = "0x1C1D55C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public DllNotFoundException(string message)
		{
			throw null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00015626 File Offset: 0x00013826
		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D580", Offset = "0x1C1D580", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected DllNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
