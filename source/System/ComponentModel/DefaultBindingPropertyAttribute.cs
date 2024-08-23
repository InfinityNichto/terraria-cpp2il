using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000271 RID: 625
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000367")]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		// Token: 0x06001470 RID: 5232 RVA: 0x00006881 File Offset: 0x00004A81
		[global::Cpp2ILInjected.Token(Token = "0x60016B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48BE4", Offset = "0x1E48BE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultBindingPropertyAttribute()
		{
			throw null;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00006884 File Offset: 0x00004A84
		[global::Cpp2ILInjected.Token(Token = "0x60016B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48BEC", Offset = "0x1E48BEC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultBindingPropertyAttribute(string name)
		{
			throw null;
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00006887 File Offset: 0x00004A87
		[global::Cpp2ILInjected.Token(Token = "0x1700052A")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48C14", Offset = "0x1E48C14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0000688A File Offset: 0x00004A8A
		[global::Cpp2ILInjected.Token(Token = "0x60016BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C1C", Offset = "0x1E48C1C", Length = "0x74")]
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

		// Token: 0x06001474 RID: 5236 RVA: 0x0000688D File Offset: 0x00004A8D
		[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C90", Offset = "0x1E48C90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00006890 File Offset: 0x00004A90
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48C98", Offset = "0x1E48C98", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DefaultBindingPropertyAttribute()
		{
			throw null;
		}

		// Token: 0x04000DF3 RID: 3571
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000DF4 RID: 3572
		[global::Cpp2ILInjected.Token(Token = "0x40011F9")]
		public static readonly DefaultBindingPropertyAttribute Default;
	}
}
