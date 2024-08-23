using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027F RID: 639
	[global::Cpp2ILInjected.Token(Token = "0x2000376")]
	public class ExpandableObjectConverter : TypeConverter
	{
		// Token: 0x060014F2 RID: 5362 RVA: 0x000069F8 File Offset: 0x00004BF8
		[global::Cpp2ILInjected.Token(Token = "0x600173D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BEB0", Offset = "0x1E4BEB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ExpandableObjectConverter()
		{
			throw null;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000069FB File Offset: 0x00004BFB
		[global::Cpp2ILInjected.Token(Token = "0x600173E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BEB8", Offset = "0x1E4BEB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000069FE File Offset: 0x00004BFE
		[global::Cpp2ILInjected.Token(Token = "0x600173F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BF20", Offset = "0x1E4BF20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}
	}
}
