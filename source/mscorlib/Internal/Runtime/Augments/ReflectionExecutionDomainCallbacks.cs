using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000049 RID: 73
	[global::Cpp2ILInjected.Token(Token = "0x2000064")]
	internal class ReflectionExecutionDomainCallbacks
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00014B1F File Offset: 0x00012D1F
		[global::Cpp2ILInjected.Token(Token = "0x6000232")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6F68", Offset = "0x1AC6F68", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MissingMetadataException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.Exception CreateMissingMetadataException(global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00014B22 File Offset: 0x00012D22
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6F60", Offset = "0x1AC6F60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ReflectionExecutionDomainCallbacks()
		{
			throw null;
		}
	}
}
