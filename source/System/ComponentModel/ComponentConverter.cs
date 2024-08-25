using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003DB")]
	public class ComponentConverter : ReferenceConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E629BC", Offset = "0x1E629BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReferenceConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ComponentConverter(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62A24", Offset = "0x1E62A24", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62AF0", Offset = "0x1E62AF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}
	}
}
