using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002AE RID: 686
	[global::Cpp2ILInjected.Token(Token = "0x20003AA")]
	public class NullableConverter : TypeConverter
	{
		// Token: 0x06001662 RID: 5730 RVA: 0x00006D52 File Offset: 0x00004F52
		[global::Cpp2ILInjected.Token(Token = "0x60018BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E562A8", Offset = "0x1E562A8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public NullableConverter(Type type)
		{
			throw null;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00006D55 File Offset: 0x00004F55
		[global::Cpp2ILInjected.Token(Token = "0x60018BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E563D0", Offset = "0x1E563D0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x06001664 RID: 5732 RVA: 0x00006D58 File Offset: 0x00004F58
		[global::Cpp2ILInjected.Token(Token = "0x60018BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56494", Offset = "0x1E56494", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00006D5B File Offset: 0x00004F5B
		[global::Cpp2ILInjected.Token(Token = "0x60018BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E565D0", Offset = "0x1E565D0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x06001666 RID: 5734 RVA: 0x00006D5E File Offset: 0x00004F5E
		[global::Cpp2ILInjected.Token(Token = "0x60018BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56694", Offset = "0x1E56694", Length = "0x1E4")]
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

		// Token: 0x06001667 RID: 5735 RVA: 0x00006D61 File Offset: 0x00004F61
		[global::Cpp2ILInjected.Token(Token = "0x60018BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56878", Offset = "0x1E56878", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(IDictionary)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			throw null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00006D64 File Offset: 0x00004F64
		[global::Cpp2ILInjected.Token(Token = "0x60018C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5689C", Offset = "0x1E5689C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetCreateInstanceSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00006D67 File Offset: 0x00004F67
		[global::Cpp2ILInjected.Token(Token = "0x60018C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E568C0", Offset = "0x1E568C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00006D6A File Offset: 0x00004F6A
		[global::Cpp2ILInjected.Token(Token = "0x60018C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E568E4", Offset = "0x1E568E4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetPropertiesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00006D6D File Offset: 0x00004F6D
		[global::Cpp2ILInjected.Token(Token = "0x60018C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56908", Offset = "0x1E56908", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00006D70 File Offset: 0x00004F70
		[global::Cpp2ILInjected.Token(Token = "0x60018C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56C84", Offset = "0x1E56C84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetStandardValuesExclusive", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00006D73 File Offset: 0x00004F73
		[global::Cpp2ILInjected.Token(Token = "0x60018C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56CAC", Offset = "0x1E56CAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetStandardValuesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00006D76 File Offset: 0x00004F76
		[global::Cpp2ILInjected.Token(Token = "0x60018C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56CD4", Offset = "0x1E56CD4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00006D79 File Offset: 0x00004F79
		[global::Cpp2ILInjected.Token(Token = "0x170005A7")]
		public Type NullableType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56D08", Offset = "0x1E56D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00006D7C File Offset: 0x00004F7C
		[global::Cpp2ILInjected.Token(Token = "0x170005A8")]
		public Type UnderlyingType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56D10", Offset = "0x1E56D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00006D7F File Offset: 0x00004F7F
		[global::Cpp2ILInjected.Token(Token = "0x170005A9")]
		public TypeConverter UnderlyingTypeConverter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56D18", Offset = "0x1E56D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000E7F RID: 3711
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Type <NullableType>k__BackingField;

		// Token: 0x04000E80 RID: 3712
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Type <UnderlyingType>k__BackingField;

		// Token: 0x04000E81 RID: 3713
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField;
	}
}
