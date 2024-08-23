using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x02000015 RID: 21
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	internal class NotNullAttribute : Attribute
	{
		// Token: 0x17000013 RID: 19
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public string Exception
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA40EC", Offset = "0x1FA40EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA40F4", Offset = "0x1FA40F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NotNullAttribute(string exception = "ArgumentNullException")
		{
			throw null;
		}

		// Token: 0x0400001C RID: 28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Exception>k__BackingField;
	}
}
