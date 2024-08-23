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
	// Token: 0x020002ED RID: 749
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003EE")]
	public class TypeConverter
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x000072C8 File Offset: 0x000054C8
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

		// Token: 0x0600186B RID: 6251 RVA: 0x000072CB File Offset: 0x000054CB
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

		// Token: 0x0600186C RID: 6252 RVA: 0x000072CE File Offset: 0x000054CE
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

		// Token: 0x0600186D RID: 6253 RVA: 0x000072D1 File Offset: 0x000054D1
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

		// Token: 0x0600186E RID: 6254 RVA: 0x000072D4 File Offset: 0x000054D4
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

		// Token: 0x0600186F RID: 6255 RVA: 0x000072D7 File Offset: 0x000054D7
		[global::Cpp2ILInjected.Token(Token = "0x6001AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77A04", Offset = "0x1E77A04", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFrom(object value)
		{
			throw null;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000072DA File Offset: 0x000054DA
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

		// Token: 0x06001871 RID: 6257 RVA: 0x000072DD File Offset: 0x000054DD
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

		// Token: 0x06001872 RID: 6258 RVA: 0x000072E0 File Offset: 0x000054E0
		[global::Cpp2ILInjected.Token(Token = "0x6001AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77BF8", Offset = "0x1E77BF8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			throw null;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000072E3 File Offset: 0x000054E3
		[global::Cpp2ILInjected.Token(Token = "0x6001AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77C78", Offset = "0x1E77C78", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertFromString(string text)
		{
			throw null;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000072E6 File Offset: 0x000054E6
		[global::Cpp2ILInjected.Token(Token = "0x6001AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77C90", Offset = "0x1E77C90", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			throw null;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000072E9 File Offset: 0x000054E9
		[global::Cpp2ILInjected.Token(Token = "0x6001AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77BEC", Offset = "0x1E77BEC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			throw null;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000072EC File Offset: 0x000054EC
		[global::Cpp2ILInjected.Token(Token = "0x6001AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77D10", Offset = "0x1E77D10", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ConvertTo(object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000072EF File Offset: 0x000054EF
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

		// Token: 0x06001878 RID: 6264 RVA: 0x000072F2 File Offset: 0x000054F2
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

		// Token: 0x06001879 RID: 6265 RVA: 0x000072F5 File Offset: 0x000054F5
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

		// Token: 0x0600187A RID: 6266 RVA: 0x000072F8 File Offset: 0x000054F8
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

		// Token: 0x0600187B RID: 6267 RVA: 0x000072FB File Offset: 0x000054FB
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

		// Token: 0x0600187C RID: 6268 RVA: 0x000072FE File Offset: 0x000054FE
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

		// Token: 0x0600187D RID: 6269 RVA: 0x00007301 File Offset: 0x00005501
		[global::Cpp2ILInjected.Token(Token = "0x6001AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781A0", Offset = "0x1E781A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object CreateInstance(IDictionary propertyValues)
		{
			throw null;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00007304 File Offset: 0x00005504
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

		// Token: 0x0600187F RID: 6271 RVA: 0x00007307 File Offset: 0x00005507
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

		// Token: 0x06001880 RID: 6272 RVA: 0x0000730A File Offset: 0x0000550A
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

		// Token: 0x06001881 RID: 6273 RVA: 0x0000730D File Offset: 0x0000550D
		[global::Cpp2ILInjected.Token(Token = "0x6001AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781BC", Offset = "0x1E781BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetCreateInstanceSupported()
		{
			throw null;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00007310 File Offset: 0x00005510
		[global::Cpp2ILInjected.Token(Token = "0x6001AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781CC", Offset = "0x1E781CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetCreateInstanceSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00007313 File Offset: 0x00005513
		[global::Cpp2ILInjected.Token(Token = "0x6001AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781D4", Offset = "0x1E781D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PropertyDescriptorCollection GetProperties(object value)
		{
			throw null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00007316 File Offset: 0x00005516
		[global::Cpp2ILInjected.Token(Token = "0x6001AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E781E0", Offset = "0x1E781E0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
		{
			throw null;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00007319 File Offset: 0x00005519
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

		// Token: 0x06001886 RID: 6278 RVA: 0x0000731C File Offset: 0x0000551C
		[global::Cpp2ILInjected.Token(Token = "0x6001AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782C4", Offset = "0x1E782C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetPropertiesSupported()
		{
			throw null;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000731F File Offset: 0x0000551F
		[global::Cpp2ILInjected.Token(Token = "0x6001AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782D4", Offset = "0x1E782D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetPropertiesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00007322 File Offset: 0x00005522
		[global::Cpp2ILInjected.Token(Token = "0x6001AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782DC", Offset = "0x1E782DC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ICollection GetStandardValues()
		{
			throw null;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00007325 File Offset: 0x00005525
		[global::Cpp2ILInjected.Token(Token = "0x6001B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782EC", Offset = "0x1E782EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00007328 File Offset: 0x00005528
		[global::Cpp2ILInjected.Token(Token = "0x6001B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E782F4", Offset = "0x1E782F4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetStandardValuesExclusive()
		{
			throw null;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000732B File Offset: 0x0000552B
		[global::Cpp2ILInjected.Token(Token = "0x6001B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78308", Offset = "0x1E78308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValuesExclusive", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000732E File Offset: 0x0000552E
		[global::Cpp2ILInjected.Token(Token = "0x6001B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78310", Offset = "0x1E78310", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetStandardValuesSupported()
		{
			throw null;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00007331 File Offset: 0x00005531
		[global::Cpp2ILInjected.Token(Token = "0x6001B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78324", Offset = "0x1E78324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = "GetStandardValuesSupported", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00007334 File Offset: 0x00005534
		[global::Cpp2ILInjected.Token(Token = "0x6001B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7832C", Offset = "0x1E7832C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsValid(object value)
		{
			throw null;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00007337 File Offset: 0x00005537
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

		// Token: 0x06001890 RID: 6288 RVA: 0x0000733A File Offset: 0x0000553A
		[global::Cpp2ILInjected.Token(Token = "0x6001B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78484", Offset = "0x1E78484", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
		{
			throw null;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000733D File Offset: 0x0000553D
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

		// Token: 0x04000F26 RID: 3878
		[global::Cpp2ILInjected.Token(Token = "0x400134F")]
		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

		// Token: 0x04000F27 RID: 3879
		[global::Cpp2ILInjected.Token(Token = "0x4001350")]
		private static bool useCompatibleTypeConversion;

		// Token: 0x02000463 RID: 1123
		[global::Cpp2ILInjected.Token(Token = "0x20003EF")]
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor
		{
			// Token: 0x06001F0D RID: 7949 RVA: 0x000085A6 File Offset: 0x000067A6
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

			// Token: 0x06001F0E RID: 7950 RVA: 0x000085A9 File Offset: 0x000067A9
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

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000085AC File Offset: 0x000067AC
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

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000085AF File Offset: 0x000067AF
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

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06001F11 RID: 7953 RVA: 0x000085B2 File Offset: 0x000067B2
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

			// Token: 0x06001F12 RID: 7954 RVA: 0x000085B5 File Offset: 0x000067B5
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

			// Token: 0x06001F13 RID: 7955 RVA: 0x000085B8 File Offset: 0x000067B8
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

			// Token: 0x06001F14 RID: 7956 RVA: 0x000085BB File Offset: 0x000067BB
			[global::Cpp2ILInjected.Token(Token = "0x6001B10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78850", Offset = "0x1E78850", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool ShouldSerializeValue(object component)
			{
				throw null;
			}

			// Token: 0x040013AD RID: 5037
			[global::Cpp2ILInjected.Token(Token = "0x4001351")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			private Type componentType;

			// Token: 0x040013AE RID: 5038
			[global::Cpp2ILInjected.Token(Token = "0x4001352")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private Type propertyType;
		}

		// Token: 0x02000464 RID: 1124
		[global::Cpp2ILInjected.Token(Token = "0x20003F0")]
		public class StandardValuesCollection : ICollection, IEnumerable
		{
			// Token: 0x06001F15 RID: 7957 RVA: 0x000085BE File Offset: 0x000067BE
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

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000085C1 File Offset: 0x000067C1
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

			// Token: 0x17000760 RID: 1888
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

			// Token: 0x06001F18 RID: 7960 RVA: 0x000085C7 File Offset: 0x000067C7
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

			// Token: 0x06001F19 RID: 7961 RVA: 0x000085CA File Offset: 0x000067CA
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

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000085CD File Offset: 0x000067CD
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

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000085D0 File Offset: 0x000067D0
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

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x06001F1C RID: 7964 RVA: 0x000085D3 File Offset: 0x000067D3
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

			// Token: 0x06001F1D RID: 7965 RVA: 0x000085D6 File Offset: 0x000067D6
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

			// Token: 0x06001F1E RID: 7966 RVA: 0x000085D9 File Offset: 0x000067D9
			[global::Cpp2ILInjected.Token(Token = "0x6001B1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78C50", Offset = "0x1E78C50", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter.StandardValuesCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040013AF RID: 5039
			[global::Cpp2ILInjected.Token(Token = "0x4001353")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ICollection values;

			// Token: 0x040013B0 RID: 5040
			[global::Cpp2ILInjected.Token(Token = "0x4001354")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Array valueArray;
		}
	}
}
