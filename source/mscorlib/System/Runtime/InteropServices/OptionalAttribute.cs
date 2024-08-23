using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039C RID: 924
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000446")]
	public sealed class OptionalAttribute : global::System.Attribute
	{
		// Token: 0x06001F30 RID: 7984 RVA: 0x00019C88 File Offset: 0x00017E88
		[global::Cpp2ILInjected.Token(Token = "0x6002171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70188", Offset = "0x1B70188", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OptionalAttribute()
		{
			throw null;
		}
	}
}
