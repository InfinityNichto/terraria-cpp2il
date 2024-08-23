using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039B RID: 923
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000445")]
	public sealed class OutAttribute : global::System.Attribute
	{
		// Token: 0x06001F2F RID: 7983 RVA: 0x00019C85 File Offset: 0x00017E85
		[global::Cpp2ILInjected.Token(Token = "0x6002170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70180", Offset = "0x1B70180", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OutAttribute()
		{
			throw null;
		}
	}
}
