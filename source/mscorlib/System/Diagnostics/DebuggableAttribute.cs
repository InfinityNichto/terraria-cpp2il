using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004DB RID: 1243
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Module, AllowMultiple = false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005CC")]
	public sealed class DebuggableAttribute : global::System.Attribute
	{
		// Token: 0x060029F0 RID: 10736 RVA: 0x0001BA19 File Offset: 0x00019C19
		[global::Cpp2ILInjected.Token(Token = "0x6002D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04830", Offset = "0x1C04830", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			throw null;
		}

		// Token: 0x0400156C RID: 5484
		[global::Cpp2ILInjected.Token(Token = "0x400194F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		// Token: 0x0200063B RID: 1595
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20005CD")]
		public enum DebuggingModes
		{
			// Token: 0x04001A6A RID: 6762
			[global::Cpp2ILInjected.Token(Token = "0x4001951")]
			None = 0,
			// Token: 0x04001A6B RID: 6763
			[global::Cpp2ILInjected.Token(Token = "0x4001952")]
			Default = 1,
			// Token: 0x04001A6C RID: 6764
			[global::Cpp2ILInjected.Token(Token = "0x4001953")]
			DisableOptimizations = 256,
			// Token: 0x04001A6D RID: 6765
			[global::Cpp2ILInjected.Token(Token = "0x4001954")]
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x04001A6E RID: 6766
			[global::Cpp2ILInjected.Token(Token = "0x4001955")]
			EnableEditAndContinue = 4
		}
	}
}
