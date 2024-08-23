using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002BF RID: 703
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003BD")]
	[Serializable]
	public sealed class ToolboxItemFilterAttribute : Attribute
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x00006F4A File Offset: 0x0000514A
		[global::Cpp2ILInjected.Token(Token = "0x6001977")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E624", Offset = "0x1E5E624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ToolboxItemFilterAttribute(string filterString)
		{
			throw null;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00006F4D File Offset: 0x0000514D
		[global::Cpp2ILInjected.Token(Token = "0x6001978")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E62C", Offset = "0x1E5E62C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
		{
			throw null;
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00006F50 File Offset: 0x00005150
		[global::Cpp2ILInjected.Token(Token = "0x170005D2")]
		public string FilterString
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001979")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5E6A0", Offset = "0x1E5E6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00006F53 File Offset: 0x00005153
		[global::Cpp2ILInjected.Token(Token = "0x170005D3")]
		public ToolboxItemFilterType FilterType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600197A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5E6A8", Offset = "0x1E5E6A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00006F56 File Offset: 0x00005156
		[global::Cpp2ILInjected.Token(Token = "0x170005D4")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x600197B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5E6B0", Offset = "0x1E5E6B0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00006F59 File Offset: 0x00005159
		[global::Cpp2ILInjected.Token(Token = "0x600197C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E6F4", Offset = "0x1E5E6F4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00006F5C File Offset: 0x0000515C
		[global::Cpp2ILInjected.Token(Token = "0x600197D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E7DC", Offset = "0x1E5E7DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00006F5F File Offset: 0x0000515F
		[global::Cpp2ILInjected.Token(Token = "0x600197E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E7EC", Offset = "0x1E5E7EC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Match(object obj)
		{
			throw null;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00006F62 File Offset: 0x00005162
		[global::Cpp2ILInjected.Token(Token = "0x600197F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E860", Offset = "0x1E5E860", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000EAD RID: 3757
		[global::Cpp2ILInjected.Token(Token = "0x40012CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeId;

		// Token: 0x04000EAE RID: 3758
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <FilterString>k__BackingField;

		// Token: 0x04000EAF RID: 3759
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ToolboxItemFilterType <FilterType>k__BackingField;
	}
}
