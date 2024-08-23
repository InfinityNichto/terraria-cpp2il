using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public class LabelAttribute : DrawerAttribute
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000020B6 File Offset: 0x000002B6
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public string Label
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55EC", Offset = "0x1CB55EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55F4", Offset = "0x1CB55F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB55FC", Offset = "0x1CB55FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LabelAttribute(string label)
		{
			throw null;
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Label>k__BackingField;
	}
}
