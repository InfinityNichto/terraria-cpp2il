using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000005 RID: 5
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public class ShowIfAttribute : DrawConditionAttribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public string[] Conditions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000004")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB53F0", Offset = "0x1CB53F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB53F8", Offset = "0x1CB53F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public ConditionOperator ConditionOperator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5400", Offset = "0x1CB5400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5408", Offset = "0x1CB5408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public bool Reversed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5410", Offset = "0x1CB5410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5418", Offset = "0x1CB5418", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB52F0", Offset = "0x1CB52F0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HideIfAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ShowIfAttribute(string condition)
		{
			throw null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB53C0", Offset = "0x1CB53C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ShowIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			throw null;
		}

		// Token: 0x04000004 RID: 4
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string[] <Conditions>k__BackingField;

		// Token: 0x04000005 RID: 5
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ConditionOperator <ConditionOperator>k__BackingField;

		// Token: 0x04000006 RID: 6
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool <Reversed>k__BackingField;
	}
}
