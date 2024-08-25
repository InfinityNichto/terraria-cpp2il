using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000376")]
	public class ExpandableObjectConverter : TypeConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x600173D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BEB0", Offset = "0x1E4BEB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ExpandableObjectConverter()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600173F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BF20", Offset = "0x1E4BF20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}
	}
}
