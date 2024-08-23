using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000262 RID: 610
	[global::Cpp2ILInjected.Token(Token = "0x2000356")]
	public class CharConverter : TypeConverter
	{
		// Token: 0x06001418 RID: 5144 RVA: 0x00006785 File Offset: 0x00004985
		[global::Cpp2ILInjected.Token(Token = "0x600165A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40324", Offset = "0x1E40324", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00006788 File Offset: 0x00004988
		[global::Cpp2ILInjected.Token(Token = "0x600165B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E403EC", Offset = "0x1E403EC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0000678B File Offset: 0x0000498B
		[global::Cpp2ILInjected.Token(Token = "0x600165C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4051C", Offset = "0x1E4051C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0000678E File Offset: 0x0000498E
		[global::Cpp2ILInjected.Token(Token = "0x600165D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40694", Offset = "0x1E40694", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public CharConverter()
		{
			throw null;
		}
	}
}
