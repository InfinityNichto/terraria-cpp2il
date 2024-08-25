using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000340")]
	public sealed class InitializationEventAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CA90", Offset = "0x1E3CA90", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InitializationEventAttribute(string eventName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F1")]
		public string EventName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3CAB8", Offset = "0x1E3CAB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <EventName>k__BackingField;
	}
}
