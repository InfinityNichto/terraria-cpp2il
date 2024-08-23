using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200024E RID: 590
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000340")]
	public sealed class InitializationEventAttribute : Attribute
	{
		// Token: 0x0600136C RID: 4972 RVA: 0x000065A8 File Offset: 0x000047A8
		[global::Cpp2ILInjected.Token(Token = "0x60015AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CA90", Offset = "0x1E3CA90", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InitializationEventAttribute(string eventName)
		{
			throw null;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000065AB File Offset: 0x000047AB
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

		// Token: 0x04000DA3 RID: 3491
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <EventName>k__BackingField;
	}
}
