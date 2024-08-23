using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000113 RID: 275
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200014E")]
	[global::System.Serializable]
	public abstract class Enum : global::System.ValueType, global::System.IComparable, global::System.IFormattable, global::System.IConvertible
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x000168B3 File Offset: 0x00014AB3
		[global::Cpp2ILInjected.Token(Token = "0x6000D1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6520C", Offset = "0x1C6520C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalGetValues", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(ulong[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalGetNames", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Comparer<ulong>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "Sort", MemberTypeParameters = new object[]
		{
			typeof(ulong),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(ulong[]),
			typeof(object[]),
			typeof(global::System.Collections.Generic.IComparer<ulong>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static global::System.Enum.ValuesAndNames GetCachedValuesAndNames(global::System.RuntimeType enumType, bool getNames)
		{
			throw null;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000168B6 File Offset: 0x00014AB6
		[global::Cpp2ILInjected.Token(Token = "0x6000D20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65380", Offset = "0x1C65380", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "GetTypeCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private static string InternalFormattedHexString(object value)
		{
			throw null;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000168B9 File Offset: 0x00014AB9
		[global::Cpp2ILInjected.Token(Token = "0x6000D21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C657F4", Offset = "0x1C657F4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string InternalFormat(global::System.RuntimeType eT, object value)
		{
			throw null;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000168BC File Offset: 0x00014ABC
		[global::Cpp2ILInjected.Token(Token = "0x6000D22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C659C8", Offset = "0x1C659C8", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetCachedValuesAndNames", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(bool)
		}, ReturnType = typeof(global::System.Enum.ValuesAndNames))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string InternalFlagsFormat(global::System.RuntimeType eT, object value)
		{
			throw null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000168BF File Offset: 0x00014ABF
		[global::Cpp2ILInjected.Token(Token = "0x6000D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65B78", Offset = "0x1C65B78", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "GetTypeCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static ulong ToUInt64(object value)
		{
			throw null;
		}

		// Token: 0x06000C52 RID: 3154
		[global::Cpp2ILInjected.Token(Token = "0x6000D24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65CE4", Offset = "0x1C65CE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int InternalCompareTo(object o1, object o2);

		// Token: 0x06000C53 RID: 3155
		[global::Cpp2ILInjected.Token(Token = "0x6000D25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65CE8", Offset = "0x1C65CE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.RuntimeType InternalGetUnderlyingType(global::System.RuntimeType enumType);

		// Token: 0x06000C54 RID: 3156
		[global::Cpp2ILInjected.Token(Token = "0x6000D26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65350", Offset = "0x1C65350", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool GetEnumValuesAndNames(global::System.RuntimeType enumType, out ulong[] values, out string[] names);

		// Token: 0x06000C55 RID: 3157
		[global::Cpp2ILInjected.Token(Token = "0x6000D27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65CEC", Offset = "0x1C65CEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object InternalBoxEnum(global::System.RuntimeType enumType, long value);

		// Token: 0x06000C56 RID: 3158 RVA: 0x000168C2 File Offset: 0x00014AC2
		[global::Cpp2ILInjected.Token(Token = "0x6000D28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579B08", Offset = "0x1579B08", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
		{
			throw null;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000168C5 File Offset: 0x00014AC5
		[global::Cpp2ILInjected.Token(Token = "0x6000D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579B80", Offset = "0x1579B80", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "Init", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			throw null;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000168C8 File Offset: 0x00014AC8
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65CF0", Offset = "0x1C65CF0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Localisation", Member = "GetLanguage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIKeyboardMappings", Member = "LoadKeyCode", MemberParameters = new object[]
		{
			"Terraria.IO.Preferences",
			typeof(string),
			typeof(ref bool)
		}, ReturnType = "UnityEngine.KeyCode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Include", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Remove", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "FromXml", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputDevice", Member = "GetInputControlTypeByName", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.InputControlType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object Parse(global::System.Type enumType, string value)
		{
			throw null;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000168CB File Offset: 0x00014ACB
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65D58", Offset = "0x1C65D58", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "SetCustomErrorsMode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			"System.Net.NetworkAccess"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = "CreatePermission", ReturnType = typeof(global::System.Security.IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DefaultValueAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EnsureType", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "Init", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "GetEnumParseException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static object Parse(global::System.Type enumType, string value, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000168CE File Offset: 0x00014ACE
		[global::Cpp2ILInjected.Token(Token = "0x6000D2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65E7C", Offset = "0x1C65E7C", Length = "0x60C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParse", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			"TEnum&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Enum.ParseFailureKind),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "SetFailure", MemberParameters = new object[]
		{
			typeof(global::System.Enum.ParseFailureKind),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetCachedValuesAndNames", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(bool)
		}, ReturnType = typeof(global::System.Enum.ValuesAndNames))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ulong)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private static bool TryParseEnum(global::System.Type enumType, string value, bool ignoreCase, ref global::System.Enum.EnumResult parseResult)
		{
			throw null;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000168D1 File Offset: 0x00014AD1
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66664", Offset = "0x1C66664", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions._Value", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "GetTypeCode", ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "TryConvertToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsConvertibleToPrimitiveType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "arg_type_match", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "return_type_match", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EqualityComparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EnumEqualityComparer<>), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "GetTypeCode", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref bool)
		}, ReturnType = "Newtonsoft.Json.Utilities.PrimitiveTypeCode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static global::System.Type GetUnderlyingType(global::System.Type enumType)
		{
			throw null;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000168D4 File Offset: 0x00014AD4
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66DA8", Offset = "0x1C66DA8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPulldownSetting", Member = "GetNumberOfOptions", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetProgressNumberOfTimesKilledAllBosses", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNormlBossCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetHardBossCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNumberOfTimesKilledAllBosses", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNumberOfRequiredSlimesKilled", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FileMetadata", Member = "Read", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static global::System.Array GetValues(global::System.Type enumType)
		{
			throw null;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000168D7 File Offset: 0x00014AD7
		[global::Cpp2ILInjected.Token(Token = "0x6000D2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66E64", Offset = "0x1C66E64", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumValues", ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetCachedValuesAndNames", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(bool)
		}, ReturnType = typeof(global::System.Enum.ValuesAndNames))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ulong[] InternalGetValues(global::System.RuntimeType enumType)
		{
			throw null;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000168DA File Offset: 0x00014ADA
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C658FC", Offset = "0x1C658FC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FileMetadata", Member = "Read", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"Terraria.IO.FileType"
		}, ReturnType = "Terraria.IO.FileMetadata")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.AttributeUtilities", Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(global::System.Enum) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ToolboxItemFilterAttribute", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string GetName(global::System.Type enumType, object value)
		{
			throw null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000168DD File Offset: 0x00014ADD
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66EC4", Offset = "0x1C66EC4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "Initialise", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Effects.OverlayManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string[] GetNames(global::System.Type enumType)
		{
			throw null;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000168E0 File Offset: 0x00014AE0
		[global::Cpp2ILInjected.Token(Token = "0x6000D32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66F80", Offset = "0x1C66F80", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetCachedValuesAndNames", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(bool)
		}, ReturnType = typeof(global::System.Enum.ValuesAndNames))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string[] InternalGetNames(global::System.RuntimeType enumType)
		{
			throw null;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000168E3 File Offset: 0x00014AE3
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66720", Offset = "0x1C66720", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			"System.ComponentModel.PropertyDescriptor",
			"System.Attribute[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EnsureType", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "ToObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "GetTypeCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(short)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(sbyte)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ulong)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(char)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(byte)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(uint)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ushort)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(long)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public static object ToObject(global::System.Type enumType, object value)
		{
			throw null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000168E6 File Offset: 0x00014AE6
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C67FC8", Offset = "0x1C67FC8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Localisation", Member = "GetLanguage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lighting", Member = "NextLightMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "ProcessData", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "set_PriorityClass", MemberParameters = new object[] { "System.Diagnostics.ProcessPriorityClass" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.LinuxNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "IsValid", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SystemInfo", Member = "IsValidEnumValue", MemberParameters = new object[] { typeof(global::System.Enum) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool IsDefined(global::System.Type enumType, object value)
		{
			throw null;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000168E9 File Offset: 0x00014AE9
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C68094", Offset = "0x1C68094", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		public static string Format(global::System.Type enumType, object value, string format)
		{
			throw null;
		}

		// Token: 0x06000C64 RID: 3172
		[global::Cpp2ILInjected.Token(Token = "0x6000D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685E4", Offset = "0x1C685E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern object get_value();

		// Token: 0x06000C65 RID: 3173 RVA: 0x000168EC File Offset: 0x00014AEC
		[global::Cpp2ILInjected.Token(Token = "0x6000D37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685E0", Offset = "0x1C685E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeTypedArgument), Member = "CanonicalizeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal object GetValue()
		{
			throw null;
		}

		// Token: 0x06000C66 RID: 3174
		[global::Cpp2ILInjected.Token(Token = "0x6000D38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685E8", Offset = "0x1C685E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool InternalHasFlag(global::System.Enum flags);

		// Token: 0x06000C67 RID: 3175
		[global::Cpp2ILInjected.Token(Token = "0x6000D39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685EC", Offset = "0x1C685EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern int get_hashcode();

		// Token: 0x06000C68 RID: 3176 RVA: 0x000168EF File Offset: 0x00014AEF
		[global::Cpp2ILInjected.Token(Token = "0x6000D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685F0", Offset = "0x1C685F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ToolboxItemFilterAttribute", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceDriverType", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceTransportType", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = "DefaultEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000168F2 File Offset: 0x00014AF2
		[global::Cpp2ILInjected.Token(Token = "0x6000D3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685F8", Offset = "0x1C685F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000168F5 File Offset: 0x00014AF5
		[global::Cpp2ILInjected.Token(Token = "0x6000D3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C685FC", Offset = "0x1C685FC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 303)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000168F8 File Offset: 0x00014AF8
		[global::System.Obsolete("The provider argument is not used. Please use ToString(String).")]
		[global::Cpp2ILInjected.Token(Token = "0x6000D3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C686C8", Offset = "0x1C686C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000168FB File Offset: 0x00014AFB
		[global::Cpp2ILInjected.Token(Token = "0x6000D3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6890C", Offset = "0x1C6890C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIItemDuplication", Member = "CompareItemOrder", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.SortingSteps.ByCreativeSortingId", Member = "Compare", MemberParameters = new object[] { "Terraria.Item", "Terraria.Item" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public int CompareTo(object target)
		{
			throw null;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000168FE File Offset: 0x00014AFE
		[global::Cpp2ILInjected.Token(Token = "0x6000D3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C686CC", Offset = "0x1C686CC", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssApiException", Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
		{
			"Interop.NetSecurityNative.Status",
			"Interop.NetSecurityNative.Status",
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(global::System.Enum) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			"System.Diagnostics.TraceLevel",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.StringEnumConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalFlagsFormat", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00016901 File Offset: 0x00014B01
		[global::System.Obsolete("The provider argument is not used. Please use ToString().")]
		[global::Cpp2ILInjected.Token(Token = "0x6000D40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C68AC0", Offset = "0x1C68AC0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00016904 File Offset: 0x00014B04
		[global::Cpp2ILInjected.Token(Token = "0x6000D41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C68ACC", Offset = "0x1C68ACC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool HasFlag(global::System.Enum flag)
		{
			throw null;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00016907 File Offset: 0x00014B07
		[global::Cpp2ILInjected.Token(Token = "0x6000D42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C68C1C", Offset = "0x1C68C1C", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0001690A File Offset: 0x00014B0A
		[global::Cpp2ILInjected.Token(Token = "0x6000D43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69018", Offset = "0x1C69018", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0001690D File Offset: 0x00014B0D
		[global::Cpp2ILInjected.Token(Token = "0x6000D44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C690B8", Offset = "0x1C690B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00016910 File Offset: 0x00014B10
		[global::Cpp2ILInjected.Token(Token = "0x6000D45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69158", Offset = "0x1C69158", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00016913 File Offset: 0x00014B13
		[global::Cpp2ILInjected.Token(Token = "0x6000D46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C691F8", Offset = "0x1C691F8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00016916 File Offset: 0x00014B16
		[global::Cpp2ILInjected.Token(Token = "0x6000D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69298", Offset = "0x1C69298", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00016919 File Offset: 0x00014B19
		[global::Cpp2ILInjected.Token(Token = "0x6000D48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69338", Offset = "0x1C69338", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0001691C File Offset: 0x00014B1C
		[global::Cpp2ILInjected.Token(Token = "0x6000D49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C693D8", Offset = "0x1C693D8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.States.UICreativePowersMenu.MenuTree`1", Member = ".ctor", MemberParameters = new object[] { "TEnum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.States.UICreativePowersMenu", Member = "ToggleCategory", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			"MenuTree`1<TEnum>",
			typeof(int),
			"TEnum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0001691F File Offset: 0x00014B1F
		[global::Cpp2ILInjected.Token(Token = "0x6000D4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69478", Offset = "0x1C69478", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00016922 File Offset: 0x00014B22
		[global::Cpp2ILInjected.Token(Token = "0x6000D4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69518", Offset = "0x1C69518", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00016925 File Offset: 0x00014B25
		[global::Cpp2ILInjected.Token(Token = "0x6000D4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C695B8", Offset = "0x1C695B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00016928 File Offset: 0x00014B28
		[global::Cpp2ILInjected.Token(Token = "0x6000D4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69658", Offset = "0x1C69658", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0001692B File Offset: 0x00014B2B
		[global::Cpp2ILInjected.Token(Token = "0x6000D4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C696F8", Offset = "0x1C696F8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0001692E File Offset: 0x00014B2E
		[global::Cpp2ILInjected.Token(Token = "0x6000D4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69798", Offset = "0x1C69798", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00016931 File Offset: 0x00014B31
		[global::Cpp2ILInjected.Token(Token = "0x6000D50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69838", Offset = "0x1C69838", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00016934 File Offset: 0x00014B34
		[global::Cpp2ILInjected.Token(Token = "0x6000D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C698FC", Offset = "0x1C698FC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00016937 File Offset: 0x00014B37
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C671A4", Offset = "0x1C671A4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, sbyte value)
		{
			throw null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0001693A File Offset: 0x00014B3A
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C67368", Offset = "0x1C67368", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, short value)
		{
			throw null;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0001693D File Offset: 0x00014B3D
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66FE0", Offset = "0x1C66FE0", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, int value)
		{
			throw null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00016940 File Offset: 0x00014B40
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C678B4", Offset = "0x1C678B4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, byte value)
		{
			throw null;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00016943 File Offset: 0x00014B43
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C67A78", Offset = "0x1C67A78", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, ushort value)
		{
			throw null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00016946 File Offset: 0x00014B46
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C676F0", Offset = "0x1C676F0", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, uint value)
		{
			throw null;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00016949 File Offset: 0x00014B49
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6752C", Offset = "0x1C6752C", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, long value)
		{
			throw null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0001694C File Offset: 0x00014B4C
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C66BE4", Offset = "0x1C66BE4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumValues", ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static object ToObject(global::System.Type enumType, ulong value)
		{
			throw null;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0001694F File Offset: 0x00014B4F
		[global::Cpp2ILInjected.Token(Token = "0x6000D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C67C3C", Offset = "0x1C67C3C", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static object ToObject(global::System.Type enumType, char value)
		{
			throw null;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00016952 File Offset: 0x00014B52
		[global::Cpp2ILInjected.Token(Token = "0x6000D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C67E00", Offset = "0x1C67E00", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static object ToObject(global::System.Type enumType, bool value)
		{
			throw null;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00016955 File Offset: 0x00014B55
		[global::Cpp2ILInjected.Token(Token = "0x6000D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6996C", Offset = "0x1C6996C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = ".ctor", ReturnType = typeof(void))]
		protected Enum()
		{
			throw null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00016958 File Offset: 0x00014B58
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69974", Offset = "0x1C69974", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Enum()
		{
			throw null;
		}

		// Token: 0x04000398 RID: 920
		[global::Cpp2ILInjected.Token(Token = "0x400050E")]
		private static readonly char[] enumSeperatorCharArray;

		// Token: 0x04000399 RID: 921
		[global::Cpp2ILInjected.Token(Token = "0x400050F")]
		private const string enumSeperator = ", ";

		// Token: 0x0200058F RID: 1423
		[global::Cpp2ILInjected.Token(Token = "0x200014F")]
		private enum ParseFailureKind
		{
			// Token: 0x0400181E RID: 6174
			[global::Cpp2ILInjected.Token(Token = "0x4000511")]
			None,
			// Token: 0x0400181F RID: 6175
			[global::Cpp2ILInjected.Token(Token = "0x4000512")]
			Argument,
			// Token: 0x04001820 RID: 6176
			[global::Cpp2ILInjected.Token(Token = "0x4000513")]
			ArgumentNull,
			// Token: 0x04001821 RID: 6177
			[global::Cpp2ILInjected.Token(Token = "0x4000514")]
			ArgumentWithParameter,
			// Token: 0x04001822 RID: 6178
			[global::Cpp2ILInjected.Token(Token = "0x4000515")]
			UnhandledException
		}

		// Token: 0x02000590 RID: 1424
		[global::Cpp2ILInjected.Token(Token = "0x2000150")]
		private struct EnumResult
		{
			// Token: 0x06003FC1 RID: 16321 RVA: 0x0001FA03 File Offset: 0x0001DC03
			[global::Cpp2ILInjected.Token(Token = "0x6000D5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C65E18", Offset = "0x1C65E18", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParse", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				"TEnum&"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Parse", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void Init(bool canMethodThrow)
			{
				throw null;
			}

			// Token: 0x06003FC2 RID: 16322 RVA: 0x0001FA06 File Offset: 0x0001DC06
			[global::Cpp2ILInjected.Token(Token = "0x6000D5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C66BD4", Offset = "0x1C66BD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void SetFailure(global::System.Exception unhandledException)
			{
				throw null;
			}

			// Token: 0x06003FC3 RID: 16323 RVA: 0x0001FA09 File Offset: 0x0001DC09
			[global::Cpp2ILInjected.Token(Token = "0x6000D60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C665E8", Offset = "0x1C665E8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(bool),
				typeof(ref global::System.Enum.EnumResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "GetEnumParseException", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void SetFailure(global::System.Enum.ParseFailureKind failure, string failureParameter)
			{
				throw null;
			}

			// Token: 0x06003FC4 RID: 16324 RVA: 0x0001FA0C File Offset: 0x0001DC0C
			[global::Cpp2ILInjected.Token(Token = "0x6000D61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C66624", Offset = "0x1C66624", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(bool),
				typeof(ref global::System.Enum.EnumResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum.EnumResult), Member = "GetEnumParseException", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void SetFailure(global::System.Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
				throw null;
			}

			// Token: 0x06003FC5 RID: 16325 RVA: 0x0001FA0F File Offset: 0x0001DC0F
			[global::Cpp2ILInjected.Token(Token = "0x6000D62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C66488", Offset = "0x1C66488", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum.EnumResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Enum.ParseFailureKind",
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum.EnumResult), Member = "SetFailure", MemberParameters = new object[]
			{
				"System.Enum.ParseFailureKind",
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "Parse", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal global::System.Exception GetEnumParseException()
			{
				throw null;
			}

			// Token: 0x04001823 RID: 6179
			[global::Cpp2ILInjected.Token(Token = "0x4000516")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal object parsedEnum;

			// Token: 0x04001824 RID: 6180
			[global::Cpp2ILInjected.Token(Token = "0x4000517")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal bool canThrow;

			// Token: 0x04001825 RID: 6181
			[global::Cpp2ILInjected.Token(Token = "0x4000518")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal global::System.Enum.ParseFailureKind m_failure;

			// Token: 0x04001826 RID: 6182
			[global::Cpp2ILInjected.Token(Token = "0x4000519")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string m_failureMessageID;

			// Token: 0x04001827 RID: 6183
			[global::Cpp2ILInjected.Token(Token = "0x400051A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal string m_failureParameter;

			// Token: 0x04001828 RID: 6184
			[global::Cpp2ILInjected.Token(Token = "0x400051B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal object m_failureMessageFormatArgument;

			// Token: 0x04001829 RID: 6185
			[global::Cpp2ILInjected.Token(Token = "0x400051C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal global::System.Exception m_innerException;
		}

		// Token: 0x02000591 RID: 1425
		[global::Cpp2ILInjected.Token(Token = "0x2000151")]
		private class ValuesAndNames
		{
			// Token: 0x06003FC6 RID: 16326 RVA: 0x0001FA12 File Offset: 0x0001DC12
			[global::Cpp2ILInjected.Token(Token = "0x6000D63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C65354", Offset = "0x1C65354", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ValuesAndNames(ulong[] values, string[] names)
			{
				throw null;
			}

			// Token: 0x0400182A RID: 6186
			[global::Cpp2ILInjected.Token(Token = "0x400051D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ulong[] Values;

			// Token: 0x0400182B RID: 6187
			[global::Cpp2ILInjected.Token(Token = "0x400051E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string[] Names;
		}
	}
}
