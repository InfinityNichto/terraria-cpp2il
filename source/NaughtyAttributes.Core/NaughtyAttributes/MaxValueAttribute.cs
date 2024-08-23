using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	public class MaxValueAttribute : ValidatorAttribute
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000215E File Offset: 0x0000035E
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002161 File Offset: 0x00000361
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public float MaxValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600005B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5990", Offset = "0x1CB5990", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600005C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5998", Offset = "0x1CB5998", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002164 File Offset: 0x00000364
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB59A0", Offset = "0x1CB59A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MaxValueAttribute(float maxValue)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002167 File Offset: 0x00000367
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB59D0", Offset = "0x1CB59D0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MaxValueAttribute(int maxValue)
		{
			throw null;
		}

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float <MaxValue>k__BackingField;
	}
}
