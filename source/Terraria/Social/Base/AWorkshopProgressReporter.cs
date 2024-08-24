using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	// Token: 0x02000398 RID: 920
	[global::Cpp2ILInjected.Token(Token = "0x2000535")]
	public abstract class AWorkshopProgressReporter
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002DC1 RID: 11713
		[global::Cpp2ILInjected.Token(Token = "0x1700062A")]
		public abstract bool HasOngoingTasks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600321D")]
			get;
		}

		// Token: 0x06002DC2 RID: 11714
		[global::Cpp2ILInjected.Token(Token = "0x600321E")]
		public abstract bool TryGetProgress(out float progress);

		// Token: 0x06002DC3 RID: 11715 RVA: 0x0002A2BA File Offset: 0x000284BA
		[global::Cpp2ILInjected.Token(Token = "0x600321F")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BE20", Offset = "0x132BE20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AWorkshopProgressReporter()
		{
			throw null;
		}
	}
}
