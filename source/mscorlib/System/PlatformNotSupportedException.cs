using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;
using Unity;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	[global::System.Serializable]
	public class PlatformNotSupportedException : global::System.NotSupportedException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45290", Offset = "0x1C45290", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetJapaneseCalendarDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetTaiwanCalendarDefaultInstance", ReturnType = typeof(global::System.Globalization.Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OperatingSystem), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "CryptDeriveKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ExportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Security.Cryptography.PbeParameters)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ExportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Security.Cryptography.PbeParameters)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ExportPkcs8PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ExportSubjectPublicKeyInfo", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ImportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ImportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ImportPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "ImportSubjectPublicKeyInfo", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "TryExportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Security.Cryptography.PbeParameters),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "TryExportEncryptedPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Security.Cryptography.PbeParameters),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "TryExportPkcs8PrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AsymmetricAlgorithm), Member = "TryExportSubjectPublicKeyInfo", MemberParameters = new object[]
		{
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "ExportRSAPrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "ExportRSAPublicKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "ImportRSAPrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "ImportRSAPublicKey", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryExportRSAPrivateKey", MemberParameters = new object[]
		{
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryExportRSAPublicKey", MemberParameters = new object[]
		{
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "AddOID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "get_NonceByteSizes", ReturnType = typeof(global::System.Security.Cryptography.KeySizes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "get_TagByteSizes", ReturnType = typeof(global::System.Security.Cryptography.KeySizes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.ReadOnlySpan<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesCcm), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.ReadOnlySpan<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "get_NonceByteSizes", ReturnType = typeof(global::System.Security.Cryptography.KeySizes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "get_TagByteSizes", ReturnType = typeof(global::System.Security.Cryptography.KeySizes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.ReadOnlySpan<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.AesGcm), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.ReadOnlySpan<byte>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Missing), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Pointer), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.MethodAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "get_DeclaringType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "GetParameters", ReturnType = typeof(global::System.Reflection.ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "GetMethodImplementationFlags", ReturnType = typeof(global::System.Reflection.MethodImplAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "get_MethodHandle", ReturnType = typeof(global::System.RuntimeMethodHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "get_ReflectedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.ConstructorBuilder), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.MethodAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "get_DeclaringType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "GetParameters", ReturnType = typeof(global::System.Reflection.ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "get_MethodHandle", ReturnType = typeof(global::System.RuntimeMethodHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "get_ReflectedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "GetMethodImplementationFlags", ReturnType = typeof(global::System.Reflection.MethodImplAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "GetBaseDefinition", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.DynamicMethod), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_Assembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_AssemblyQualifiedName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_BaseType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_Namespace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "get_UnderlyingSystemType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetAttributeFlagsImpl", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetConstructorImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetConstructors", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetEvents", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.EventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetFields", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetInterfaces", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetMethodImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetMethods", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetProperties", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.PropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsArrayImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsByRefImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsPointerImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.EnumBuilder), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.FieldBuilder), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_Assembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_AssemblyQualifiedName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_BaseType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_Namespace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "get_UnderlyingSystemType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetAttributeFlagsImpl", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetConstructorImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetConstructors", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetEvents", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.EventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetFields", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetInterfaces", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetMethodImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetMethods", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetProperties", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.PropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsArrayImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsByRefImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsPointerImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.GenericTypeParameterBuilder), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.MethodAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "get_DeclaringType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "get_MethodHandle", ReturnType = typeof(global::System.RuntimeMethodHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "get_ReflectedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "GetBaseDefinition", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "GetMethodImplementationFlags", ReturnType = typeof(global::System.Reflection.MethodImplAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "GetParameters", ReturnType = typeof(global::System.Reflection.ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.MethodBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_CanRead", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_CanWrite", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_DeclaringType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_PropertyType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "get_ReflectedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetGetMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetIndexParameters", ReturnType = typeof(global::System.Reflection.ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetSetMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.PropertyBuilder), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_Assembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_AssemblyQualifiedName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_BaseType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_Namespace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "get_UnderlyingSystemType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetAttributeFlagsImpl", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetConstructorImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetConstructors", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetEvents", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.EventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetFields", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetInterfaces", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetMethodImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetMethods", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetProperties", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.PropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsArrayImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsByRefImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsPointerImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Emit.TypeBuilder), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(global::System.Globalization.Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "IsJapaneseCalendar", MemberParameters = new object[] { typeof(global::System.Globalization.Calendar) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CalendarData), Member = "GetJapaneseEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CalendarData), Member = "InitializeAbbreviatedEraNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Hashtable.SyncHashtable", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Hashtable.SyncHashtable", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Unity.ThrowStub), Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "ReleaseGssBuffer", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "DisplayMinorStatus", MemberParameters = new object[] { "Status&", "Interop.NetSecurityNative.Status", "GssBuffer&" }, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "DisplayMajorStatus", MemberParameters = new object[] { "Status&", "Interop.NetSecurityNative.Status", "GssBuffer&" }, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "ImportUserName", MemberParameters = new object[]
		{
			"Status&",
			typeof(string),
			typeof(int),
			"Microsoft.Win32.SafeHandles.SafeGssNameHandle&"
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "ImportPrincipalName", MemberParameters = new object[]
		{
			"Status&",
			typeof(string),
			typeof(int),
			"Microsoft.Win32.SafeHandles.SafeGssNameHandle&"
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "ReleaseName", MemberParameters = new object[]
		{
			"Status&",
			typeof(ref global::System.IntPtr)
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "InitiateCredSpNego", MemberParameters = new object[] { "Status&", "Microsoft.Win32.SafeHandles.SafeGssNameHandle", "Microsoft.Win32.SafeHandles.SafeGssCredHandle&" }, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "InitiateCredWithPassword", MemberParameters = new object[]
		{
			"Status&",
			typeof(bool),
			"Microsoft.Win32.SafeHandles.SafeGssNameHandle",
			typeof(string),
			typeof(int),
			"Microsoft.Win32.SafeHandles.SafeGssCredHandle&"
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "ReleaseCred", MemberParameters = new object[]
		{
			"Status&",
			typeof(ref global::System.IntPtr)
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "InitSecContext", MemberParameters = new object[]
		{
			"Status&",
			"Microsoft.Win32.SafeHandles.SafeGssCredHandle",
			"Microsoft.Win32.SafeHandles.SafeGssContextHandle&",
			typeof(bool),
			"Microsoft.Win32.SafeHandles.SafeGssNameHandle",
			typeof(uint),
			"System.Byte[]",
			typeof(int),
			"GssBuffer&",
			typeof(ref uint),
			typeof(ref int)
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "DeleteSecContext", MemberParameters = new object[]
		{
			"Status&",
			typeof(ref global::System.IntPtr)
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "Wrap", MemberParameters = new object[]
		{
			"Status&",
			"Microsoft.Win32.SafeHandles.SafeGssContextHandle",
			typeof(bool),
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"GssBuffer&"
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative", Member = "Unwrap", MemberParameters = new object[]
		{
			"Status&",
			"Microsoft.Win32.SafeHandles.SafeGssContextHandle",
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"GssBuffer&"
		}, ReturnType = "Interop.NetSecurityNative.Status")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetSubjectNameHash", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "ExportAsPEM", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
			typeof(global::System.IO.Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Disconnect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.LinkedList`1.Enumerator", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.LinkedList`1.Enumerator", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.LinkedList`1.Enumerator", Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.ThrowStub", Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XName", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.ThrowStub", Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Unity.ThrowStub", Member = "ThrowNotSupportedException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 226)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PlatformNotSupportedException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C452EC", Offset = "0x1C452EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionSelectorDelegate", MemberParameters = new object[] { "System.Net.HttpListener.ExtendedProtectionSelector" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { "System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "QueryContextClientSpecifiedSpn", MemberParameters = new object[] { "System.Net.Security.SafeDeleteContext" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "InitializeSecurityContext", MemberParameters = new object[]
		{
			"System.Net.Security.SafeFreeCredentials",
			"System.Net.Security.SafeDeleteContext&",
			typeof(string),
			"System.Net.ContextFlagsPal",
			"System.Net.Security.SecurityBuffer[]",
			"System.Net.Security.SecurityBuffer",
			"System.Net.ContextFlagsPal&"
		}, ReturnType = "System.Net.SecurityStatusPal")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "AcceptSecurityContext", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials", "System.Net.Security.SafeDeleteContext&", "System.Net.ContextFlagsPal", "System.Net.Security.SecurityBuffer[]", "System.Net.Security.SecurityBuffer", "System.Net.ContextFlagsPal&" }, ReturnType = "System.Net.SecurityStatusPal")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "AcquireCredentialsHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			"System.Net.NetworkCredential"
		}, ReturnType = "System.Net.Security.SafeFreeCredentials")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public PlatformNotSupportedException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45310", Offset = "0x1C45310", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected PlatformNotSupportedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
