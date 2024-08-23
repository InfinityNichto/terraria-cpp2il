using System;
using System.ComponentModel;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200004F RID: 79
	[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x06000246 RID: 582 RVA: 0x0000348E File Offset: 0x0000168E
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7B60", Offset = "0x1EA7B60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		public UriTypeConverter()
		{
			throw null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003491 File Offset: 0x00001691
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7B68", Offset = "0x1EA7B68", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriTypeConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriTypeConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool CanConvert(Type type)
		{
			throw null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00003494 File Offset: 0x00001694
		[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7C4C", Offset = "0x1EA7C4C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriTypeConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003497 File Offset: 0x00001697
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7CFC", Offset = "0x1EA7CFC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriTypeConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000349A File Offset: 0x0000169A
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7D74", Offset = "0x1EA7D74", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000349D File Offset: 0x0000169D
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7F10", Offset = "0x1EA7F10", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}
	}
}
