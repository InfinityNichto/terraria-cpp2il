using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x0200075C RID: 1884
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000B64")]
	public class Il2CppSetOptionAttribute : Attribute
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060047EE RID: 18414 RVA: 0x0002ED63 File Offset: 0x0002CF63
		// (set) Token: 0x060047EF RID: 18415 RVA: 0x0002ED66 File Offset: 0x0002CF66
		[global::Cpp2ILInjected.Token(Token = "0x1700093D")]
		public Option Option
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60054B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x94E8D0", Offset = "0x94E8D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60054B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x94E8D8", Offset = "0x94E8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x0002ED69 File Offset: 0x0002CF69
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x0002ED6C File Offset: 0x0002CF6C
		[global::Cpp2ILInjected.Token(Token = "0x1700093E")]
		public object Value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60054B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x94E8E0", Offset = "0x94E8E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60054B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x94E8E8", Offset = "0x94E8E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x0002ED6F File Offset: 0x0002CF6F
		[global::Cpp2ILInjected.Token(Token = "0x60054B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E8F0", Offset = "0x94E8F0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public Il2CppSetOptionAttribute(Option option, object value)
		{
			throw null;
		}

		// Token: 0x040073E3 RID: 29667
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008DAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Option <Option>k__BackingField;

		// Token: 0x040073E4 RID: 29668
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object <Value>k__BackingField;
	}
}
