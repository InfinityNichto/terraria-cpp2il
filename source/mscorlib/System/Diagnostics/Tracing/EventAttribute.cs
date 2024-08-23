using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020004E6 RID: 1254
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D9")]
	public sealed class EventAttribute : global::System.Attribute
	{
		// Token: 0x06002A1A RID: 10778 RVA: 0x0001BA88 File Offset: 0x00019C88
		[global::Cpp2ILInjected.Token(Token = "0x6002D7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C063C0", Offset = "0x1C063C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EventAttribute(int eventId)
		{
			throw null;
		}

		// Token: 0x17000655 RID: 1621
		// (set) Token: 0x06002A1B RID: 10779 RVA: 0x0001BA8B File Offset: 0x00019C8B
		[global::Cpp2ILInjected.Token(Token = "0x170006E9")]
		private int EventId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C063E8", Offset = "0x1C063E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x0001BA8E File Offset: 0x00019C8E
		[global::Cpp2ILInjected.Token(Token = "0x170006EA")]
		public EventLevel Level
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C063F0", Offset = "0x1C063F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (set) Token: 0x06002A1D RID: 10781 RVA: 0x0001BA91 File Offset: 0x00019C91
		[global::Cpp2ILInjected.Token(Token = "0x170006EB")]
		public EventKeywords Keywords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C063F8", Offset = "0x1C063F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x0001BA94 File Offset: 0x00019C94
		[global::Cpp2ILInjected.Token(Token = "0x170006EC")]
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C06400", Offset = "0x1C06400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400159A RID: 5530
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001987")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <EventId>k__BackingField;

		// Token: 0x0400159B RID: 5531
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001988")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private EventLevel <Level>k__BackingField;

		// Token: 0x0400159C RID: 5532
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001989")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventKeywords <Keywords>k__BackingField;

		// Token: 0x0400159D RID: 5533
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400198A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <Message>k__BackingField;
	}
}
