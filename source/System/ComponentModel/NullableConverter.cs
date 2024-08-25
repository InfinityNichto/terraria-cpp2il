using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003AA")]
	public class NullableConverter : TypeConverter
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60018C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5689C", Offset = "0x1E5689C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetCreateInstanceSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60018C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E568E4", Offset = "0x1E568E4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetPropertiesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60018C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56C84", Offset = "0x1E56C84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetStandardValuesExclusive", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56CAC", Offset = "0x1E56CAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetStandardValuesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Type <NullableType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Type <UnderlyingType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400129C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField;
	}
}
