using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public class OnValueChangedAttribute : MetaAttribute
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002152 File Offset: 0x00000352
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002155 File Offset: 0x00000355
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public string CallbackName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000057")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5958", Offset = "0x1CB5958", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000058")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5960", Offset = "0x1CB5960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002158 File Offset: 0x00000358
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5968", Offset = "0x1CB5968", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OnValueChangedAttribute(string callbackName)
		{
			throw null;
		}

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <CallbackName>k__BackingField;
	}
}
