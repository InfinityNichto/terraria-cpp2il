using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	public class SliderAttribute : DrawerAttribute
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002101 File Offset: 0x00000301
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public float MinValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5754", Offset = "0x1CB5754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB575C", Offset = "0x1CB575C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002104 File Offset: 0x00000304
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public float MaxValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5764", Offset = "0x1CB5764", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB576C", Offset = "0x1CB576C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5774", Offset = "0x1CB5774", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SliderAttribute(float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB57A0", Offset = "0x1CB57A0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SliderAttribute(int minValue, int maxValue)
		{
			throw null;
		}

		// Token: 0x0400001F RID: 31
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float <MinValue>k__BackingField;

		// Token: 0x04000020 RID: 32
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float <MaxValue>k__BackingField;
	}
}
