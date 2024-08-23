using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039A RID: 922
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000444")]
	public sealed class InAttribute : global::System.Attribute
	{
		// Token: 0x06001F2E RID: 7982 RVA: 0x00019C82 File Offset: 0x00017E82
		[global::Cpp2ILInjected.Token(Token = "0x600216F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70178", Offset = "0x1B70178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InAttribute()
		{
			throw null;
		}
	}
}
