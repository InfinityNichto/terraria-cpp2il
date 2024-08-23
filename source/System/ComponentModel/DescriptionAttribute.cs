using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000242 RID: 578
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000333")]
	public class DescriptionAttribute : Attribute
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00006509 File Offset: 0x00004709
		[global::Cpp2ILInjected.Token(Token = "0x6001566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BA44", Offset = "0x1E3BA44", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DescriptionAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DescriptionAttribute()
		{
			throw null;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0000650C File Offset: 0x0000470C
		[global::Cpp2ILInjected.Token(Token = "0x6001567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BAA0", Offset = "0x1E3BAA0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SRDescriptionAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonitoringDescriptionAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DescriptionAttribute(string description)
		{
			throw null;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0000650F File Offset: 0x0000470F
		[global::Cpp2ILInjected.Token(Token = "0x170004E1")]
		public virtual string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001568")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3BAC8", Offset = "0x1E3BAC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonitoringDescriptionAttribute), Member = "get_Description", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00006512 File Offset: 0x00004712
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00006515 File Offset: 0x00004715
		[global::Cpp2ILInjected.Token(Token = "0x170004E2")]
		protected string DescriptionValue
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001569")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3BAD0", Offset = "0x1E3BAD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600156A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3BAD8", Offset = "0x1E3BAD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00006518 File Offset: 0x00004718
		[global::Cpp2ILInjected.Token(Token = "0x600156B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BAE0", Offset = "0x1E3BAE0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0000651B File Offset: 0x0000471B
		[global::Cpp2ILInjected.Token(Token = "0x600156C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BBA4", Offset = "0x1E3BBA4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0000651E File Offset: 0x0000471E
		[global::Cpp2ILInjected.Token(Token = "0x600156D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BBC4", Offset = "0x1E3BBC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00006521 File Offset: 0x00004721
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600156E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BC2C", Offset = "0x1E3BC2C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DescriptionAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DescriptionAttribute()
		{
			throw null;
		}

		// Token: 0x04000D87 RID: 3463
		[global::Cpp2ILInjected.Token(Token = "0x4001184")]
		public static readonly DescriptionAttribute Default;

		// Token: 0x04000D88 RID: 3464
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001185")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <DescriptionValue>k__BackingField;
	}
}
