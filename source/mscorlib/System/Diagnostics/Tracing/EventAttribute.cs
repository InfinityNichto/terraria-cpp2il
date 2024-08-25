using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D9")]
	public sealed class EventAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C063C0", Offset = "0x1C063C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EventAttribute(int eventId)
		{
			throw null;
		}

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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001987")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <EventId>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001988")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private EventLevel <Level>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001989")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventKeywords <Keywords>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400198A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <Message>k__BackingField;
	}
}
