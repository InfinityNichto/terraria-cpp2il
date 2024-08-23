using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000FC RID: 252
	[global::Cpp2ILInjected.Token(Token = "0x200012E")]
	[global::System.Serializable]
	public class AppDomainUnloadedException : global::System.SystemException
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x00016562 File Offset: 0x00014762
		[global::Cpp2ILInjected.Token(Token = "0x6000BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C561C8", Offset = "0x1C561C8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AppDomainUnloadedException()
		{
			throw null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00016565 File Offset: 0x00014765
		[global::Cpp2ILInjected.Token(Token = "0x6000BCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56220", Offset = "0x1C56220", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected AppDomainUnloadedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
