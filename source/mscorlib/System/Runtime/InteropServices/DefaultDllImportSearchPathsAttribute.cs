using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039E RID: 926
	[ComVisible(false)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Method, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000448")]
	public sealed class DefaultDllImportSearchPathsAttribute : global::System.Attribute
	{
		// Token: 0x06001F31 RID: 7985 RVA: 0x00019C8B File Offset: 0x00017E8B
		[global::Cpp2ILInjected.Token(Token = "0x6002172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70190", Offset = "0x1B70190", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			throw null;
		}

		// Token: 0x04000F71 RID: 3953
		[global::Cpp2ILInjected.Token(Token = "0x4001266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal DllImportSearchPath _paths;
	}
}
