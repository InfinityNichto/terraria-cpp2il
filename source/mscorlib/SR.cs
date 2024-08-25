using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200000D")]
internal static class SR
{
	[global::Cpp2ILInjected.Token(Token = "0x6000030")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA658", Offset = "0x1AAA658", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CreateThis", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		"System.UriKind"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CreateHelper", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		"System.UriKind",
		"System.UriFormatException&"
	}, ReturnType = "System.Uri")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriParser", Member = "Resolve", MemberParameters = new object[] { "System.Uri", "System.Uri", "System.UriFormatException&" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriParser", Member = "GetComponents", MemberParameters = new object[] { "System.Uri", "System.UriComponents", "System.UriFormat" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "GetProcessHandle", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = "Microsoft.Win32.SafeHandles.SafeProcessHandle")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialCache", Member = "Add", MemberParameters = new object[]
	{
		"System.Uri",
		typeof(string),
		"System.Net.NetworkCredential"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialCache", Member = "Add", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(string),
		"System.Net.NetworkCredential"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialCache", Member = "GetCredential", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(string)
	}, ReturnType = "System.Net.NetworkCredential")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DnsEndPoint", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		"System.Net.Sockets.AddressFamily"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestPrefixElement", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.Type)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "set_Item", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Set", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "SetInternal", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "AddWithoutValidate", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "CheckBadChars", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Set", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "SetInternal", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermissionAttribute", Member = "set_Connect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermissionAttribute", Member = "set_Accept", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermissionAttribute", Member = "set_ConnectPattern", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermissionAttribute", Member = "set_AcceptPattern", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetRes", Member = "GetWebStatusCodeString", MemberParameters = new object[]
	{
		"System.Net.HttpStatusCode",
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetRes", Member = "GetWebStatusCodeString", MemberParameters = new object[]
	{
		"System.Net.FtpStatusCode",
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxyDataBuilder", Member = "CreateInvalidProxyStringException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.FormatException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new object[]
	{
		"System.Net.CookieVariant",
		"System.Uri",
		typeof(bool),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "Add", MemberParameters = new object[] { "System.Net.Cookie" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "Add", MemberParameters = new object[]
	{
		"System.Net.Cookie",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "CookieCutter", MemberParameters = new object[]
	{
		"System.Uri",
		typeof(string),
		typeof(string),
		typeof(bool)
	}, ReturnType = "System.Net.CookieCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.TcpClient", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.AddressFamily" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.UdpClient", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.AddressFamily" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Container", Member = "ValidateName", MemberParameters = new object[]
	{
		"System.ComponentModel.IComponent",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.LicenseException", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.LicenseException", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		typeof(string),
		typeof(global::System.Type),
		"System.Attribute[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		"System.ComponentModel.PropertyDescriptor",
		"System.Attribute[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_GetMethodValue", ReturnType = typeof(global::System.Reflection.MethodInfo))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter", Member = "GetConvertFromException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter", Member = "GetConvertToException", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Type)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = "System.ComponentModel.TypeConverter")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent", ReturnType = "System.ComponentModel.EventDescriptor")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty", ReturnType = "System.ComponentModel.PropertyDescriptor")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", ReturnType = "System.ComponentModel.EventDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = "System.ComponentModel.EventDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new object[] { "System.ComponentModel.PropertyDescriptor" }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = "System.ComponentModel.TypeConverter")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent", ReturnType = "System.ComponentModel.EventDescriptor")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty", ReturnType = "System.ComponentModel.PropertyDescriptor")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", ReturnType = "System.ComponentModel.EventDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = "System.ComponentModel.EventDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new object[] { "System.ComponentModel.PropertyDescriptor" }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "GetDescriptor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(bool)
	}, ReturnType = "System.ComponentModel.ICustomTypeDescriptor")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineFilter", MemberParameters = new object[]
	{
		typeof(int),
		typeof(global::System.Collections.ICollection),
		typeof(object),
		typeof(global::System.Collections.IDictionary)
	}, ReturnType = typeof(global::System.Collections.ICollection))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase.KeysCollection", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
	{
		typeof(global::System.Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
	{
		typeof(global::System.Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string GetString(string name, params object[] args)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000031")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA6C8", Offset = "0x1AAA6C8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	internal static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000032")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA6D0", Offset = "0x1AAA6D0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetException", MemberParameters = new object[] { "System.ParsingError" }, ReturnType = "System.UriFormatException")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_AbsolutePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_AbsoluteUri", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_LocalPath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Authority", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_HostNameType", ReturnType = "System.UriHostNameType")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_IsFile", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_IsLoopback", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Segments", ReturnType = "System.String[]")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_IsUnc", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Host", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Port", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Query", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Fragment", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Scheme", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_UserInfo", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetComponents", MemberParameters = new object[] { "System.UriComponents", "System.UriFormat" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "EscapeString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(int),
		"System.Char[]",
		typeof(ref int),
		typeof(bool),
		typeof(char),
		typeof(char),
		typeof(char)
	}, ReturnType = "System.Char[]")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
	{
		"System.Char*",
		typeof(int),
		typeof(int),
		"System.Char[]",
		typeof(ref int),
		typeof(char),
		typeof(char),
		typeof(char),
		"System.UnescapeMode",
		"System.UriParser",
		typeof(bool)
	}, ReturnType = "System.Char[]")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriParser", Member = "Resolve", MemberParameters = new object[] { "System.Uri", "System.Uri", "System.UriFormatException&" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriParser", Member = "GetComponents", MemberParameters = new object[] { "System.Uri", "System.UriComponents", "System.UriFormat" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
	{
		"System.Char*",
		typeof(int),
		typeof(int),
		typeof(ref bool),
		typeof(ref string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
	{
		"System.Char*",
		typeof(int),
		typeof(int),
		typeof(ref bool),
		typeof(ref bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = "Add", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.InteropServices.HandleCollector", Member = "Remove", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListener", Member = "set_IndentSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = "System.Collections.IList.Insert", MemberParameters = new object[]
	{
		typeof(int),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "get_StandardInput", ReturnType = typeof(global::System.IO.StreamWriter))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "get_StandardOutput", ReturnType = typeof(global::System.IO.StreamReader))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "EnsureState", MemberParameters = new object[] { "System.Diagnostics.Process.State" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "GetProcessHandle", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = "Microsoft.Win32.SafeHandles.SafeProcessHandle")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "Start", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithShellExecuteEx", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ServiceNameCollection", Member = "AddIfNew", MemberParameters = new object[]
	{
		typeof(global::System.Collections.ArrayList),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialCache.CredentialEnumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialCache.CredentialEnumerator", Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DnsEndPoint", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		"System.Net.Sockets.AddressFamily"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_MethodNotImplementedException", ReturnType = typeof(global::System.NotImplementedException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_PropertyNotImplementedException", ReturnType = typeof(global::System.NotImplementedException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_MethodNotSupportedException", ReturnType = typeof(global::System.NotSupportedException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ExceptionHelper", Member = "get_PropertyNotSupportedException", ReturnType = typeof(global::System.NotSupportedException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpProtocolUtils", Member = "string2date", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "get_Item", MemberParameters = new object[] { "System.Net.HttpRequestHeader" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "set_Item", MemberParameters = new object[]
	{
		"System.Net.HttpRequestHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "get_Item", MemberParameters = new object[] { "System.Net.HttpResponseHeader" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "set_Item", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[]
	{
		"System.Net.HttpRequestHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Set", MemberParameters = new object[]
	{
		"System.Net.HttpRequestHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Set", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "SetInternal", MemberParameters = new object[]
	{
		"System.Net.HttpResponseHeader",
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Remove", MemberParameters = new object[] { "System.Net.HttpRequestHeader" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Remove", MemberParameters = new object[] { "System.Net.HttpResponseHeader" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "CheckBadChars", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "IsSubsetOf", MemberParameters = new object[] { typeof(global::System.Security.IPermission) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "Union", MemberParameters = new object[] { typeof(global::System.Security.IPermission) }, ReturnType = typeof(global::System.Security.IPermission))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "Intersect", MemberParameters = new object[] { typeof(global::System.Security.IPermission) }, ReturnType = typeof(global::System.Security.IPermission))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "FromXml", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "Create", MemberParameters = new object[]
	{
		"System.Uri",
		typeof(bool)
	}, ReturnType = "System.Net.WebRequest")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "CreateHttp", MemberParameters = new object[] { "System.Uri" }, ReturnType = "System.Net.HttpWebRequest")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetRes", Member = "GetWebStatusString", MemberParameters = new object[]
	{
		typeof(string),
		"System.Net.WebExceptionStatus"
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetRes", Member = "GetWebStatusString", MemberParameters = new object[] { "System.Net.WebExceptionStatus" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ProxyChain.ProxyEnumerator", Member = "get_Current", ReturnType = "System.Uri")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieCollection.CookieCollectionEnumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieCollection.CookieCollectionEnumerator", Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "Add", MemberParameters = new object[] { "System.Net.Cookie" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "Add", MemberParameters = new object[]
	{
		"System.Net.Cookie",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "CookieCutter", MemberParameters = new object[]
	{
		"System.Uri",
		typeof(string),
		typeof(string),
		typeof(bool)
	}, ReturnType = "System.Net.CookieCollection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "set_ContentLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "set_Method", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "set_Timeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetRequestStream", MemberParameters = new object[]
	{
		typeof(global::System.AsyncCallback),
		typeof(object)
	}, ReturnType = typeof(global::System.IAsyncResult))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetResponse", MemberParameters = new object[]
	{
		typeof(global::System.AsyncCallback),
		typeof(object)
	}, ReturnType = typeof(global::System.IAsyncResult))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(global::System.IO.Stream))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "EndGetResponse", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = "System.Net.WebResponse")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionSelectorDelegate", MemberParameters = new object[] { "System.Net.HttpListener.ExtendedProtectionSelector" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { "System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation", Member = "SetDisposed", MemberParameters = new object[] { typeof(ref global::System.Runtime.ExceptionServices.ExceptionDispatchInfo) }, ReturnType = "System.ValueTuple`2<ExceptionDispatchInfo, Boolean>")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = "WriteAsync", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int),
		typeof(global::System.Threading.CancellationToken)
	}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "Add", MemberParameters = new object[] { "System.Net.NetworkInformation.UnicastIPAddressInformation" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "Remove", MemberParameters = new object[] { "System.Net.NetworkInformation.UnicastIPAddressInformation" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "set_ExclusiveAddressUse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "set_DontFragment", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "get_DualMode", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "set_DualMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SetIPProtectionLevel", MemberParameters = new object[] { "System.Net.Sockets.IPProtectionLevel" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.TcpClient", Member = "GetStream", ReturnType = "System.Net.Sockets.NetworkStream")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.TcpListener", Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.TcpListener", Member = "AcceptTcpClient", ReturnType = "System.Net.Sockets.TcpClient")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.UdpClient", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		"System.Net.Sockets.AddressFamily"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "Send", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		"System.Net.IPEndPoint"
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.AuthenticatedStream", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.IO.Stream),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "set_Position", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "Seek", MemberParameters = new object[]
	{
		typeof(long),
		typeof(global::System.IO.SeekOrigin)
	}, ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AsyncCompletedEventArgs", Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CollectionConverter", Member = "ConvertTo", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object),
		typeof(global::System.Type)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		"System.Attribute[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter", Member = "GetConvertFromException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter", Member = "GetConvertToException", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Type)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode", Member = "CreateInstance", MemberParameters = new object[]
	{
		typeof(global::System.IServiceProvider),
		typeof(global::System.Type),
		"System.Type[]",
		"System.Object[]"
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "CreateAssociation", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "CreateInstance", MemberParameters = new object[]
	{
		typeof(global::System.IServiceProvider),
		typeof(global::System.Type),
		"System.Type[]",
		"System.Object[]"
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase.NameObjectKeysEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase.NameObjectKeysEnumerator", Member = "Reset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase.NameObjectKeysEnumerator", Member = "get_Current", ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase.KeysCollection", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
	{
		typeof(global::System.Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "BaseAdd", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "BaseRemove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "BaseClear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "BaseSet", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
	{
		typeof(global::System.Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 139)]
	internal static string GetString(string name)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000033")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA6D4", Offset = "0x1AAA6D4", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyTabAttribute", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		"System.ComponentModel.PropertyTabScope"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyTabAttribute", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		"System.ComponentModel.PropertyTabScope"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.Globalization.CultureInfo),
		typeof(bool),
		typeof(char),
		typeof(char),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string Format(string resourceFormat, params object[] args)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000034")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA9634", Offset = "0x1AA9634", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
	{
		typeof(global::Interop.ErrorInfo),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
	{
		typeof(global::System.ReadOnlySpan<char>),
		typeof(int),
		typeof(global::System.StringSplitOptions)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[]),
		typeof(int),
		typeof(global::System.StringSplitOptions)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.TimeSpan),
		typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArgumentOutOfRangeException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BadImageFormatException), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Guid.GuidResult", Member = "GetGuidParseException", ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeInitializationException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.Exception)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<>), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<>), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.Collections.IStructuralComparable.CompareTo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Collections.IComparer)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetAddingDuplicateWithKeyArgumentException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.ArgumentException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Collections.Generic.KeyNotFoundException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidTypeWithPointersNotSupported", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OperatingSystem), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.PlatformID),
		typeof(global::System.Version),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingFieldException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(byte*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(global::System.Security.Cryptography.HMAC))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.IO.Stream),
		typeof(global::System.Security.Cryptography.ICryptoTransform),
		typeof(global::System.Security.Cryptography.CryptoStreamMode),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ValidateKeyStorageFlags", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileLoadException), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileNotFoundException), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "Move", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureNotFoundException), Member = "get_Message", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
	{
		"System.Globalization.TimeSpanParse.ParseFailureKind",
		typeof(string),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "ThrowKeyNotFoundException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.KeyedCollection<, >), Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TItem")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.KeyedCollection<, >), Member = "AddKey", MemberParameters = new object[] { "TKey", "TItem" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssApiException", Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
	{
		"Interop.NetSecurityNative.Status",
		"Interop.NetSecurityNative.Status",
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "SetFromProperty", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexFCD", Member = "CalculateFC", MemberParameters = new object[]
	{
		typeof(int),
		"System.Text.RegularExpressions.RegexNode",
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "ScanRegex", ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "ScanCharClass", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool)
	}, ReturnType = "System.Text.RegularExpressions.RegexCharClass")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "ScanGroupOpen", ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "ScanCharEscape", ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexWriter", Member = "EmitFragment", MemberParameters = new object[]
	{
		typeof(int),
		"System.Text.RegularExpressions.RegexNode",
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CommandStream", Member = "GenerateException", MemberParameters = new object[]
	{
		"System.Net.FtpStatusCode",
		typeof(string),
		typeof(global::System.Exception)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "QueueOrCreateDataConection", MemberParameters = new object[]
	{
		"System.Net.CommandStream.PipelineEntry",
		"System.Net.ResponseDescription",
		typeof(bool),
		typeof(ref global::System.IO.Stream),
		typeof(ref bool)
	}, ReturnType = "System.Net.CommandStream.PipelineInstruction")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetContentLengthFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateResponseUri", MemberParameters = new object[]
	{
		typeof(string),
		"System.Net.FtpWebRequest"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetResponse", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = "System.Net.WebResponse")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(global::System.IO.Stream))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "CreateRequestAbortedException", ReturnType = "System.Net.WebException")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new object[] { "System.Span`1<Byte>" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginRead", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int),
		typeof(global::System.AsyncCallback),
		typeof(object)
	}, ReturnType = typeof(global::System.IAsyncResult))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginWrite", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int),
		typeof(global::System.AsyncCallback),
		typeof(object)
	}, ReturnType = typeof(global::System.IAsyncResult))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int),
		typeof(global::System.Threading.CancellationToken)
	}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new object[]
	{
		"System.Memory`1<Byte>",
		typeof(global::System.Threading.CancellationToken)
	}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int),
		typeof(int),
		typeof(global::System.Threading.CancellationToken)
	}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new object[]
	{
		"System.ReadOnlyMemory`1<Byte>",
		typeof(global::System.Threading.CancellationToken)
	}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs", Member = "CreateException", MemberParameters = new object[] { "System.Net.Sockets.SocketError" }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "GetException", MemberParameters = new object[]
	{
		"System.Net.Sockets.SocketError",
		typeof(bool)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncEventArgs", Member = "SetBuffer", MemberParameters = new object[] { "System.Memory`1<Byte>" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslClientAuthenticationOptions", Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509RevocationMode" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslClientAuthenticationOptions", Member = "set_EncryptionPolicy", MemberParameters = new object[] { "System.Net.Security.EncryptionPolicy" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslServerAuthenticationOptions", Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509RevocationMode" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslServerAuthenticationOptions", Member = "set_EncryptionPolicy", MemberParameters = new object[] { "System.Net.Security.EncryptionPolicy" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifyValidationCallback", MemberParameters = new object[] { "System.Net.Security.RemoteCertificateValidationCallback" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifySelectionCallback", MemberParameters = new object[] { "System.Net.Security.LocalCertificateSelectionCallback" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ArrayConverter", Member = "ConvertTo", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object),
		typeof(global::System.Type)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyTabAttribute", Member = "get_TabClasses", ReturnType = "System.Type[]")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ToolboxItemAttribute", Member = "get_ToolboxItemType", ReturnType = typeof(global::System.Type))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		typeof(string),
		typeof(global::System.Type),
		"System.Attribute[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Type),
		typeof(global::System.Reflection.EventInfo)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "AddEventHandler", MemberParameters = new object[]
	{
		typeof(object),
		typeof(global::System.Delegate)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.ListDictionary", Member = "Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "Add", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 120)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal unsafe static string Format(string resourceFormat, object p1)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000035")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA750", Offset = "0x1AAA750", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(global::System.Globalization.Calendar)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "FromUnixTimeSeconds", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Round", MemberParameters = new object[]
	{
		typeof(double),
		typeof(int),
		typeof(global::System.MidpointRounding)
	}, ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "ThrowMinMaxException", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "Next", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ToCachedStringBuilder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
	{
		typeof(ref decimal),
		typeof(int),
		typeof(global::System.MidpointRounding)
	}, ReturnType = typeof(decimal))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.ASCIIEncoding), Member = "GetByteCount", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.ASCIIEncoding), Member = "GetBytes", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(byte*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.InternalEncoderBestFitFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
	{
		typeof(char),
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
	{
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
	{
		typeof(char),
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderFallbackException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(char),
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
	{
		typeof(char),
		typeof(char),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetByteCount", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(byte*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF8Encoding), Member = "GetByteCount", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(byte*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "GetByteCount", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
	{
		typeof(char*),
		typeof(int),
		typeof(byte*),
		typeof(int),
		typeof(global::System.Text.EncoderNLS)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
	{
		typeof(int),
		typeof(global::System.Globalization.MonthNameStyles),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ListDictionaryInternal), Member = "Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Queue), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.SortedList), Member = "Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "Insert", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssApiException", Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
	{
		"Interop.NetSecurityNative.Status",
		"Interop.NetSecurityNative.Status",
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssBuffer", Member = "Copy", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitDefaultMatchTimeout", ReturnType = typeof(global::System.TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "SetFromProperty", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.ArgumentException))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPEndPoint", Member = "Create", MemberParameters = new object[] { "System.Net.SocketAddress" }, ReturnType = "System.Net.EndPoint")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new object[]
	{
		"System.Net.CommandStream.PipelineEntry",
		"System.Net.ResponseDescription",
		typeof(bool),
		typeof(ref global::System.IO.Stream)
	}, ReturnType = "System.Net.CommandStream.PipelineInstruction")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BaseNumberConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BooleanConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CharConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.IDictionary.Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 90)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal unsafe static string Format(string resourceFormat, object p1, object p2)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000036")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA7C8", Offset = "0x1AAA7C8", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPEndPoint", Member = "Create", MemberParameters = new object[] { "System.Net.SocketAddress" }, ReturnType = "System.Net.EndPoint")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.InvalidEnumArgumentException", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(global::System.Type)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(global::System.IFormatProvider),
		typeof(string),
		typeof(object),
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000037")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA850", Offset = "0x1AAA850", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Guid.GuidResult", Member = "GetGuidParseException", ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanResult", Member = "SetFailure", MemberParameters = new object[]
	{
		"System.Globalization.TimeSpanParse.ParseFailureKind",
		typeof(string),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	internal static string GetResourceString(string str)
	{
		throw null;
	}
}
