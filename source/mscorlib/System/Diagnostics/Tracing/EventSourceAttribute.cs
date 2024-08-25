using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20005DC")]
	public sealed class EventSourceAttribute : global::System.Attribute
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002D94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06950", Offset = "0x1C06950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EventSourceAttribute()
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400198F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Guid>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001990")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Name>k__BackingField;
	}
}
