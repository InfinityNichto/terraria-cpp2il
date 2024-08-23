using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	public class MinValueAttribute : ValidatorAttribute
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000216A File Offset: 0x0000036A
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000216D File Offset: 0x0000036D
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public float MinValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600005F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB59FC", Offset = "0x1CB59FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000060")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5A04", Offset = "0x1CB5A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002170 File Offset: 0x00000370
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5A0C", Offset = "0x1CB5A0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MinValueAttribute(float minValue)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002173 File Offset: 0x00000373
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5A34", Offset = "0x1CB5A34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MinValueAttribute(int minValue)
		{
			throw null;
		}

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float <MinValue>k__BackingField;
	}
}
