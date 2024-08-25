using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003EE")]
	public class TypeConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000629")]
		private static bool UseCompatibleTypeConversion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7798C", Offset = "0x1E7798C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter), Member = "IsValid", MemberParameters = new object[]
			{
				typeof(ITypeDescriptorContext),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E779DC", Offset = "0x1E779DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool CanConvertFrom(Type sourceType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6409C", Offset = "0x1E6409C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReferenceConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "CanConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E779F0", Offset = "0x1E779F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CanConvertToString", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "TryConvertToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool CanConvertTo(Type destinationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E641CC", Offset = "0x1E641CC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseNumberConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "CanConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77A04", Offset = "0x1E77A04", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFrom(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E645A0", Offset = "0x1E645A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetConvertFromException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77B70", Offset = "0x1E77B70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientValueAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "ConvertFromInvariantString", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFromInvariantString(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77BF8", Offset = "0x1E77BF8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77C78", Offset = "0x1E77C78", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertFromString(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77C90", Offset = "0x1E77C90", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77BEC", Offset = "0x1E77BEC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77D10", Offset = "0x1E77D10", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertTo(object value, Type destinationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61C70", Offset = "0x1E61C70", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseNumberConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MultilineStringConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReferenceConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "GetConvertToException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77E4C", Offset = "0x1E77E4C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "TryConvertToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ConvertToInvariantString(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E669B8", Offset = "0x1E669B8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertToString", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77F9C", Offset = "0x1E77F9C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InheritanceAttribute), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReferenceConverter.ReferenceComparer", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string ConvertToString(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7809C", Offset = "0x1E7809C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string ConvertToString(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77EC0", Offset = "0x1E77EC0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter), Member = "ConvertToInvariantString", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781A0", Offset = "0x1E781A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object CreateInstance(IDictionary propertyValues)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781B4", Offset = "0x1E781B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(IDictionary)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77A80", Offset = "0x1E77A80", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected Exception GetConvertFromException(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77D2C", Offset = "0x1E77D2C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected Exception GetConvertToException(object value, Type destinationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781BC", Offset = "0x1E781BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetCreateInstanceSupported()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781CC", Offset = "0x1E781CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetCreateInstanceSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781D4", Offset = "0x1E781D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PropertyDescriptorCollection GetProperties(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781E0", Offset = "0x1E781E0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782BC", Offset = "0x1E782BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782C4", Offset = "0x1E782C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetPropertiesSupported()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782D4", Offset = "0x1E782D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetPropertiesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782DC", Offset = "0x1E782DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ICollection GetStandardValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782EC", Offset = "0x1E782EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782F4", Offset = "0x1E782F4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetStandardValuesExclusive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78308", Offset = "0x1E78308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValuesExclusive", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78310", Offset = "0x1E78310", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetStandardValuesSupported()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78324", Offset = "0x1E78324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValuesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7832C", Offset = "0x1E7832C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsValid(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78344", Offset = "0x1E78344", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "get_UseCompatibleTypeConversion", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual bool IsValid(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78484", Offset = "0x1E78484", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E61EBC", Offset = "0x1E61EBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriTypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedProtectionPolicyTypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ByteConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomTypeDescriptor), Member = "GetConverter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExpandableObjectConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MultilineStringConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReferenceConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TypeConverter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400134F")]
		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

		[global::Cpp2ILInjected.Token(Token = "0x4001350")]
		private static bool useCompatibleTypeConversion;

		[global::Cpp2ILInjected.Token(Token = "0x20003EF")]
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E784B4", Offset = "0x1E784B4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78534", Offset = "0x1E78534", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ArrayConverter.ArrayPropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062A")]
			public override Type ComponentType
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B0B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78568", Offset = "0x1E78568", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062B")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B0C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78570", Offset = "0x1E78570", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new object[] { typeof(Attribute) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062C")]
			public override Type PropertyType
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B0D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E785EC", Offset = "0x1E785EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E785F4", Offset = "0x1E785F4", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool CanResetValue(object component)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7872C", Offset = "0x1E7872C", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void ResetValue(object component)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78850", Offset = "0x1E78850", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool ShouldSerializeValue(object component)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001351")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			private Type componentType;

			[global::Cpp2ILInjected.Token(Token = "0x4001352")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private Type propertyType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20003F0")]
		public class StandardValuesCollection : ICollection, IEnumerable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E66EC8", Offset = "0x1E66EC8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReferenceConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeListConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public StandardValuesCollection(ICollection values)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062D")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B12")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78858", Offset = "0x1E78858", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter.StandardValuesCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062E")]
			public object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B13")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E7890C", Offset = "0x1E7890C", Length = "0x1E4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78AF0", Offset = "0x1E78AF0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter.StandardValuesCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void CopyTo(Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78BA0", Offset = "0x1E78BA0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertFrom", MemberParameters = new object[]
			{
				typeof(ITypeDescriptorContext),
				typeof(CultureInfo),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter.StandardValuesCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public IEnumerator GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700062F")]
			private int System.Collections.ICollection.Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B16")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78C38", Offset = "0x1E78C38", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "get_Count", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000630")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B17")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78C3C", Offset = "0x1E78C3C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000631")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B18")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E78C44", Offset = "0x1E78C44", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78C4C", Offset = "0x1E78C4C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void System.Collections.ICollection.CopyTo(Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001B1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78C50", Offset = "0x1E78C50", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001353")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ICollection values;

			[global::Cpp2ILInjected.Token(Token = "0x4001354")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Array valueArray;
		}
	}
}
