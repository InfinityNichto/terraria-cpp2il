using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C3 RID: 707
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003C2")]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x00006FA7 File Offset: 0x000051A7
		[global::Cpp2ILInjected.Token(Token = "0x6001997")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F2E8", Offset = "0x1E5F2E8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TypeDescriptionProviderAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00006FAA File Offset: 0x000051AA
		[global::Cpp2ILInjected.Token(Token = "0x6001998")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F35C", Offset = "0x1E5F35C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TypeDescriptionProviderAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00006FAD File Offset: 0x000051AD
		[global::Cpp2ILInjected.Token(Token = "0x170005D6")]
		public string TypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001999")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5F438", Offset = "0x1E5F438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EB9 RID: 3769
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <TypeName>k__BackingField;
	}
}
