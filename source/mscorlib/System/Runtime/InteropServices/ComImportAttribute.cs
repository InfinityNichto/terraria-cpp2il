using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000397 RID: 919
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000441")]
	public sealed class ComImportAttribute : global::System.Attribute
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x00019C79 File Offset: 0x00017E79
		[global::Cpp2ILInjected.Token(Token = "0x600216C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70140", Offset = "0x1B70140", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComImportAttribute()
		{
			throw null;
		}
	}
}
