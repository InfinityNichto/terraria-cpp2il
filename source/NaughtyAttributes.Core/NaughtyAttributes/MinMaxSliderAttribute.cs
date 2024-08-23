using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public class MinMaxSliderAttribute : DrawerAttribute
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public float MinValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5624", Offset = "0x1CB5624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000026")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB562C", Offset = "0x1CB562C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public float MaxValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5634", Offset = "0x1CB5634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB563C", Offset = "0x1CB563C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020C8 File Offset: 0x000002C8
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5644", Offset = "0x1CB5644", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MinMaxSliderAttribute(float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float <MinValue>k__BackingField;

		// Token: 0x0400000F RID: 15
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float <MaxValue>k__BackingField;
	}
}
