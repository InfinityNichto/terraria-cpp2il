using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004DE RID: 1246
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct, AllowMultiple = true)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D0")]
	public sealed class DebuggerTypeProxyAttribute : global::System.Attribute
	{
		// Token: 0x060029F2 RID: 10738 RVA: 0x0001BA1F File Offset: 0x00019C1F
		[global::Cpp2ILInjected.Token(Token = "0x6002D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C048D0", Offset = "0x1C048D0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public DebuggerTypeProxyAttribute(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x04001572 RID: 5490
		[global::Cpp2ILInjected.Token(Token = "0x400195B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string typeName;
	}
}
