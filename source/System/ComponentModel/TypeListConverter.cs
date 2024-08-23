using System;
using System.Collections;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C4 RID: 708
	[global::Cpp2ILInjected.Token(Token = "0x20003C3")]
	public abstract class TypeListConverter : TypeConverter
	{
		// Token: 0x06001738 RID: 5944 RVA: 0x00006FB0 File Offset: 0x000051B0
		[global::Cpp2ILInjected.Token(Token = "0x600199A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F440", Offset = "0x1E5F440", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		protected TypeListConverter(Type[] types)
		{
			throw null;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00006FB3 File Offset: 0x000051B3
		[global::Cpp2ILInjected.Token(Token = "0x600199B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F468", Offset = "0x1E5F468", Length = "0xC8")]
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

		// Token: 0x0600173A RID: 5946 RVA: 0x00006FB6 File Offset: 0x000051B6
		[global::Cpp2ILInjected.Token(Token = "0x600199C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F530", Offset = "0x1E5F530", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00006FB9 File Offset: 0x000051B9
		[global::Cpp2ILInjected.Token(Token = "0x600199D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F5F8", Offset = "0x1E5F5F8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00006FBC File Offset: 0x000051BC
		[global::Cpp2ILInjected.Token(Token = "0x600199E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F6FC", Offset = "0x1E5F6FC", Length = "0x1B0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00006FBF File Offset: 0x000051BF
		[global::Cpp2ILInjected.Token(Token = "0x600199F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F8AC", Offset = "0x1E5F8AC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00006FC2 File Offset: 0x000051C2
		[global::Cpp2ILInjected.Token(Token = "0x60019A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F960", Offset = "0x1E5F960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00006FC5 File Offset: 0x000051C5
		[global::Cpp2ILInjected.Token(Token = "0x60019A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F968", Offset = "0x1E5F968", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x04000EBA RID: 3770
		[global::Cpp2ILInjected.Token(Token = "0x40012D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Type[] _types;

		// Token: 0x04000EBB RID: 3771
		[global::Cpp2ILInjected.Token(Token = "0x40012D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TypeConverter.StandardValuesCollection _values;
	}
}
