using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000535")]
	public abstract class AWorkshopProgressReporter
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700062A")]
		public abstract bool HasOngoingTasks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600321D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600321E")]
		public abstract bool TryGetProgress(out float progress);

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
