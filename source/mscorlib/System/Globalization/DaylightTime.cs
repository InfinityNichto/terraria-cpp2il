using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004AF RID: 1199
	[global::Cpp2ILInjected.Token(Token = "0x200058F")]
	[global::System.Serializable]
	public class DaylightTime
	{
		// Token: 0x060027E9 RID: 10217 RVA: 0x0001B455 File Offset: 0x00019655
		[global::Cpp2ILInjected.Token(Token = "0x6002B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1030", Offset = "0x1BE1030", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DaylightTime(global::System.DateTime start, global::System.DateTime end, global::System.TimeSpan delta)
		{
			throw null;
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0001B458 File Offset: 0x00019658
		[global::Cpp2ILInjected.Token(Token = "0x17000654")]
		public global::System.DateTime Start
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE106C", Offset = "0x1BE106C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x0001B45B File Offset: 0x0001965B
		[global::Cpp2ILInjected.Token(Token = "0x17000655")]
		public global::System.DateTime End
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE1074", Offset = "0x1BE1074", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x0001B45E File Offset: 0x0001965E
		[global::Cpp2ILInjected.Token(Token = "0x17000656")]
		public global::System.TimeSpan Delta
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE107C", Offset = "0x1BE107C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400140C RID: 5132
		[global::Cpp2ILInjected.Token(Token = "0x4001770")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.DateTime _start;

		// Token: 0x0400140D RID: 5133
		[global::Cpp2ILInjected.Token(Token = "0x4001771")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.DateTime _end;

		// Token: 0x0400140E RID: 5134
		[global::Cpp2ILInjected.Token(Token = "0x4001772")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.TimeSpan _delta;
	}
}
