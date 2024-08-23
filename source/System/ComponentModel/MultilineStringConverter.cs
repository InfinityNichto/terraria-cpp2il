using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002AC RID: 684
	[global::Cpp2ILInjected.Token(Token = "0x20003A7")]
	public class MultilineStringConverter : TypeConverter
	{
		// Token: 0x06001657 RID: 5719 RVA: 0x00006D31 File Offset: 0x00004F31
		[global::Cpp2ILInjected.Token(Token = "0x60018A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55624", Offset = "0x1E55624", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00006D34 File Offset: 0x00004F34
		[global::Cpp2ILInjected.Token(Token = "0x60018A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E557A4", Offset = "0x1E557A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00006D37 File Offset: 0x00004F37
		[global::Cpp2ILInjected.Token(Token = "0x60018A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E557AC", Offset = "0x1E557AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00006D3A File Offset: 0x00004F3A
		[global::Cpp2ILInjected.Token(Token = "0x60018AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E557B4", Offset = "0x1E557B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public MultilineStringConverter()
		{
			throw null;
		}
	}
}
