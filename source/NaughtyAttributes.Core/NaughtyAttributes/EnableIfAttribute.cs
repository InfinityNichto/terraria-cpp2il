using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public class EnableIfAttribute : DrawerAttribute
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public string[] Conditions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55B8", Offset = "0x1CB55B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55C0", Offset = "0x1CB55C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public ConditionOperator ConditionOperator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55C8", Offset = "0x1CB55C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55D0", Offset = "0x1CB55D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020A7 File Offset: 0x000002A7
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public bool Reversed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55D8", Offset = "0x1CB55D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB55E0", Offset = "0x1CB55E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5480", Offset = "0x1CB5480", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DisableIfAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public EnableIfAttribute(string condition)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5550", Offset = "0x1CB5550", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EnableIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			throw null;
		}

		// Token: 0x0400000A RID: 10
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string[] <Conditions>k__BackingField;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ConditionOperator <ConditionOperator>k__BackingField;

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool <Reversed>k__BackingField;
	}
}
