using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200007B RID: 123
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	[global::System.Serializable]
	public class EntryPointNotFoundException : global::System.TypeLoadException
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x00015698 File Offset: 0x00013898
		[global::Cpp2ILInjected.Token(Token = "0x600066F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1ECC0", Offset = "0x1C1ECC0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EntryPointNotFoundException()
		{
			throw null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001569B File Offset: 0x0001389B
		[global::Cpp2ILInjected.Token(Token = "0x6000670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1ED1C", Offset = "0x1C1ED1C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public EntryPointNotFoundException(string message)
		{
			throw null;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001569E File Offset: 0x0001389E
		[global::Cpp2ILInjected.Token(Token = "0x6000671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1ED40", Offset = "0x1C1ED40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected EntryPointNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
