using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003BE RID: 958
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200046D")]
	[global::System.Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x00019DD8 File Offset: 0x00017FD8
		[global::Cpp2ILInjected.Token(Token = "0x17000466")]
		public override object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600220A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73318", Offset = "0x1B73318", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FB5 RID: 4021
		[global::Cpp2ILInjected.Token(Token = "0x40012AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.DateTime _date;
	}
}
