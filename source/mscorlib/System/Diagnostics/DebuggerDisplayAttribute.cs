using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004DF RID: 1247
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Delegate, AllowMultiple = true)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D1")]
	public sealed class DebuggerDisplayAttribute : global::System.Attribute
	{
		// Token: 0x060029F3 RID: 10739 RVA: 0x0001BA22 File Offset: 0x00019C22
		[global::Cpp2ILInjected.Token(Token = "0x6002D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C049AC", Offset = "0x1C049AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DebuggerDisplayAttribute(string value)
		{
			throw null;
		}

		// Token: 0x04001573 RID: 5491
		[global::Cpp2ILInjected.Token(Token = "0x400195C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04001574 RID: 5492
		[global::Cpp2ILInjected.Token(Token = "0x400195D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string value;

		// Token: 0x04001575 RID: 5493
		[global::Cpp2ILInjected.Token(Token = "0x400195E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string type;
	}
}
