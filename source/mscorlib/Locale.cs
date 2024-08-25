using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Cryptography;

[global::Cpp2ILInjected.Token(Token = "0x200000C")]
internal sealed class Locale
{
	[global::Cpp2ILInjected.Token(Token = "0x600002E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA64C", Offset = "0x1AAA64C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "get_KeySize", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "DecryptValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.RSAParameters) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "CheckInput", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "TransformBlock", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(int),
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "ThrowBadPaddingException", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.PaddingMode),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "ImportParameters", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSAParameters) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "VerifySignature", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "CheckPermissionState", MemberParameters = new object[]
	{
		typeof(global::System.Security.Permissions.PermissionState),
		typeof(bool)
	}, ReturnType = typeof(global::System.Security.Permissions.PermissionState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "CheckSecurityElement", MemberParameters = new object[]
	{
		typeof(global::System.Security.SecurityElement),
		typeof(string),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "ThrowInvalidPermission", MemberParameters = new object[]
	{
		typeof(global::System.Security.IPermission),
		typeof(global::System.Type)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.NamedPermissionSet), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.PermissionSet), Member = "CopyTo", MemberParameters = new object[]
	{
		typeof(global::System.Array),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement.SecurityAttribute), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(global::System.Security.Permissions.ReflectionPermissionFlag) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(global::System.Security.Permissions.SecurityPermissionFlag) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeLongNumber", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DESTransform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.SymmetricAlgorithm),
		typeof(bool),
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "ExportParameters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Security.Cryptography.DSAParameters))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(string)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSAPKCS1SignatureDeformatter), Member = "VerifySignature", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSAPKCS1SignatureFormatter), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.TripleDES),
		typeof(bool),
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.IntPtr),
		typeof(global::System.IO.FileAccess),
		typeof(bool),
		typeof(int),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.IO.FileMode),
		typeof(global::System.IO.FileAccess),
		typeof(global::System.IO.FileShare),
		typeof(int),
		typeof(bool),
		typeof(global::System.IO.FileOptions)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "Validate", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SRDescriptionAttribute", Member = "get_Description", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriTypeConverter", Member = "ConvertFrom", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriTypeConverter", Member = "ConvertTo", MemberParameters = new object[]
	{
		"System.ComponentModel.ITypeDescriptorContext",
		typeof(global::System.Globalization.CultureInfo),
		typeof(object),
		typeof(global::System.Type)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.AuthenticationException", Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeDSA", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(global::System.Security.Cryptography.DSA))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(global::System.Security.Cryptography.RSA))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension", Member = "CopyFrom", MemberParameters = new object[] { "System.Security.Cryptography.AsnEncodedData" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new object[]
	{
		"System.Byte[]",
		typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle),
		typeof(global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocationOnChain", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainStatus", Member = "GetInformation", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags" }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension", Member = "CopyFrom", MemberParameters = new object[] { "System.Security.Cryptography.AsnEncodedData" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension", Member = "Decode", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Security.Cryptography.AsnDecodeStatus")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Extension", Member = "CopyFrom", MemberParameters = new object[] { "System.Security.Cryptography.AsnEncodedData" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetInvalidChainContextException", ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509KeyUsageExtension", Member = "CopyFrom", MemberParameters = new object[] { "System.Security.Cryptography.AsnEncodedData" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Open", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.OpenFlags" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = "CopyFrom", MemberParameters = new object[] { "System.Security.Cryptography.AsnEncodedData" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = "CreatePermission", ReturnType = typeof(global::System.Security.IPermission))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = "AlreadySet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
	public static string GetText(string msg)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AAA650", Offset = "0x1AAA650", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.SymmetricAlgorithm),
		typeof(bool),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RC2Transform), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.RC2),
		typeof(bool),
		typeof(byte[]),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "get_Key", ReturnType = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
	{
		"System.Security.Cryptography.X509Certificates.X509FindType",
		typeof(object),
		typeof(bool)
	}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Open", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.OpenFlags" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesTransform", Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::System.Security.Cryptography.Aes),
		typeof(bool),
		"System.Byte[]",
		"System.Byte[]"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	public static string GetText(string fmt, params object[] args)
	{
		throw null;
	}
}
