using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020004E8 RID: 1256
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20005DC")]
	public sealed class EventSourceAttribute : global::System.Attribute
	{
		// Token: 0x1700065A RID: 1626
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x0001BAC4 File Offset: 0x00019CC4
		[global::Cpp2ILInjected.Token(Token = "0x170006F1")]
		public string Guid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C06940", Offset = "0x1C06940", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x0001BAC7 File Offset: 0x00019CC7
		[global::Cpp2ILInjected.Token(Token = "0x170006F2")]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C06948", Offset = "0x1C06948", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0001BACA File Offset: 0x00019CCA
		[global::Cpp2ILInjected.Token(Token = "0x6002D94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06950", Offset = "0x1C06950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EventSourceAttribute()
		{
			throw null;
		}

		// Token: 0x0400159F RID: 5535
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400198F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Guid>k__BackingField;

		// Token: 0x040015A0 RID: 5536
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001990")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Name>k__BackingField;
	}
}
