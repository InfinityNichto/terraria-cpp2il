using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public class ProgressBarAttribute : DrawerAttribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000020CB File Offset: 0x000002CB
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000020CE File Offset: 0x000002CE
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5670", Offset = "0x1CB5670", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5678", Offset = "0x1CB5678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000020D1 File Offset: 0x000002D1
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public float MaxValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5680", Offset = "0x1CB5680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5688", Offset = "0x1CB5688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000020D7 File Offset: 0x000002D7
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public ProgressBarColor Color
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5690", Offset = "0x1CB5690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5698", Offset = "0x1CB5698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB56A0", Offset = "0x1CB56A0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ProgressBarAttribute(string name = "", float maxValue = 100f, ProgressBarColor color = ProgressBarColor.Blue)
		{
			throw null;
		}

		// Token: 0x04000010 RID: 16
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x04000011 RID: 17
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float <MaxValue>k__BackingField;

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private ProgressBarColor <Color>k__BackingField;
	}
}
