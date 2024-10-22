﻿using System;
using System.Buffers;
using System.Collections;
using System.Globalization;
using System.IO.Enumeration;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.IO
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200056D")]
	public static class Path
	{
		[global::Cpp2ILInjected.Token(Token = "0x60029C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE544", Offset = "0x1BCE544", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "findExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string ChangeExtension(string path, string extension)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE7D0", Offset = "0x1BCE7D0", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CacheFileManager", Member = "FileSyncInternal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "get_WorldPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "get_PlayerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "get_DumpPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "GetContentSource", ReturnType = "ReLogic.Content.Sources.IContentSource")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "HasFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.PathService", Member = "GetStoragePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Base.PathService", Member = "GetStoragePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaDirectContentSource", Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaDirectContentSource", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryGetLocalTzFile", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneIdUsingReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ReadXdgUserDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "UnixGetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FileBasedResourceGroveler), Member = "FindResourceFile", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Version),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "LoadCertificateAndKey", MemberParameters = new object[]
		{
			"System.Net.IPAddress",
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MibIPGlobalProperties", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "CreateAndOpenUniqueTempFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Stream),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ValidateOutput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddFiles", MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<String>",
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Ionic.Zip.AddOrUpdateAction",
			typeof(bool),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "ForUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Import", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Import", MemberParameters = new object[] { "Mono.Security.X509.X509Crl" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Remove", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Remove", MemberParameters = new object[] { "Mono.Security.X509.X509Crl" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "ImportNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "RemoveNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "get_Personal", ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "get_OtherPeople", ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "get_IntermediateCA", ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "get_TrustedRoot", ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "get_Untrusted", ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Stores", Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Mono.Security.X509.X509Store")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 87)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static string Combine(string path1, string path2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCEB54", Offset = "0x1BCEB54", Length = "0x404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static string CleanPath(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCA5E0", Offset = "0x1BCA5E0", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "WriteFile", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "GetTitleLocationPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Version),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetParent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "LinkOrCopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.LicFileLicenseProvider", Member = "GetLicense", MemberParameters = new object[]
		{
			"System.ComponentModel.LicenseContext",
			typeof(global::System.Type),
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.License")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddFiles", MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<String>",
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "get_WriteStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "ForWriting", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipSegmentedStream")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "ForUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static string GetDirectoryName(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF374", Offset = "0x1BCF374", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.ReadOnlySpan<char> GetDirectoryName(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF444", Offset = "0x1BCF444", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.FileSystemContentSource", Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.FileSystemContentSource", Member = "BuildNameToAbsolutePathDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "BuildExtensionFreeEntryList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "findExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string GetExtension(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC62D8", Offset = "0x1BC62D8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IServiceProvider),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "GetDisplayablePath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref FileStream),
			"System.Byte[]&",
			"System.Byte[]&",
			"System.Byte[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ValidateOutput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = "set_FileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string GetFileName(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF56C", Offset = "0x1BCF56C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "ForUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "ChangeExtension", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetFileNameWithoutExtension(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCA928", Offset = "0x1BCA928", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.FileSystemContentSource", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.FileSystemContentSource", Member = "BuildNameToAbsolutePathDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetParent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref FileStream),
			"System.Byte[]&",
			"System.Byte[]&",
			"System.Byte[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Uri")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.IntSecurity", Member = "UnsafeGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlResolver", Member = "ResolveUri", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(string)
		}, ReturnType = "System.Uri")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			"Ionic.Zip.ZipEntrySource",
			typeof(object),
			typeof(object)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddFiles", MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<String>",
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityManager), Member = "EnsureElevatedPermissions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetFullPath(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF5C8", Offset = "0x1BCF5C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetFullPathInternal(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC9F08", Offset = "0x1BC9F08", Length = "0x630")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFullPathInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfUnchecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		internal static string InsecureGetFullPath(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC624C", Offset = "0x1BC624C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "GetDisplayablePath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsDirectorySeparator(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCEF58", Offset = "0x1BCEF58", Length = "0x41C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static string GetPathRoot(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF9B8", Offset = "0x1BCF9B8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityManager), Member = "EnsureElevatedPermissions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string GetTempPath()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFA98", Offset = "0x1BCFA98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string get_temp_path();

		[global::Cpp2ILInjected.Token(Token = "0x60029D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFA9C", Offset = "0x1BCFA9C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsPathRooted(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCEA30", Offset = "0x1BCEA30", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "Combine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SyntaxCheck", Member = "CheckRootedPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool IsPathRooted(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFBA0", Offset = "0x1BCFBA0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "GetWorldPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static char[] GetInvalidFileNameChars()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFC38", Offset = "0x1BCFC38", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static char[] GetInvalidPathChars()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCE73C", Offset = "0x1BCE73C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "ChangeExtension", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int findExtension(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFCCC", Offset = "0x1BCFCCC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static Path()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCF61C", Offset = "0x1BCF61C", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static string CanonicalizePath(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BCFE50", Offset = "0x1BCFE50", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static string Combine(params string[] paths)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0118", Offset = "0x1BD0118", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "UnixGetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static string Combine(string path1, string path2, string path3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0288", Offset = "0x1BD0288", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void Validate(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD02F4", Offset = "0x1BD02F4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void Validate(string path, string parameterName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0410", Offset = "0x1BD0410", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.ReadOnlySpan<char> GetFileName(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0548", Offset = "0x1BD0548", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDirectoryEntryFullPath", MemberParameters = new object[]
		{
			typeof(ref global::Interop.Sys.DirectoryEntry),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string Join(global::System.ReadOnlySpan<char> path1, global::System.ReadOnlySpan<char> path2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD086C", Offset = "0x1BD086C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string Join(global::System.ReadOnlySpan<char> path1, global::System.ReadOnlySpan<char> path2, global::System.ReadOnlySpan<char> path3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0CCC", Offset = "0x1BD0CCC", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "get_FullPath", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "StartsWithDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool TryJoin(global::System.ReadOnlySpan<char> path1, global::System.ReadOnlySpan<char> path2, global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD0600", Offset = "0x1BD0600", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2", "T3", "T4", "T5" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool>>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string[]), Member = "Create", MemberTypeParameters = new object[] { typeof(global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool>) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool>),
			typeof(global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool>>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe static string JoinInternal(global::System.ReadOnlySpan<char> first, global::System.ReadOnlySpan<char> second)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60029E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD097C", Offset = "0x1BD097C", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "IsDirectorySeparator", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2", "T3", "T4", "T5", "T6", "T7", "TRest" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>>>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string[]), Member = "Create", MemberTypeParameters = new object[] { typeof(global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>>) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>>),
			typeof(global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>>>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private unsafe static string JoinInternal(global::System.ReadOnlySpan<char> first, global::System.ReadOnlySpan<char> second, global::System.ReadOnlySpan<char> third)
		{
			throw null;
		}

		[global::System.Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
		[global::Cpp2ILInjected.Token(Token = "0x400167A")]
		public static readonly char[] InvalidPathChars;

		[global::Cpp2ILInjected.Token(Token = "0x400167B")]
		public static readonly char AltDirectorySeparatorChar;

		[global::Cpp2ILInjected.Token(Token = "0x400167C")]
		public static readonly char DirectorySeparatorChar;

		[global::Cpp2ILInjected.Token(Token = "0x400167D")]
		public static readonly char PathSeparator;

		[global::Cpp2ILInjected.Token(Token = "0x400167E")]
		internal static readonly string DirectorySeparatorStr;

		[global::Cpp2ILInjected.Token(Token = "0x400167F")]
		public static readonly char VolumeSeparatorChar;

		[global::Cpp2ILInjected.Token(Token = "0x4001680")]
		internal static readonly char[] PathSeparatorChars;

		[global::Cpp2ILInjected.Token(Token = "0x4001681")]
		private static readonly bool dirEqualsVolume;

		[global::Cpp2ILInjected.Token(Token = "0x4001682")]
		internal static readonly char[] trimEndCharsWindows;

		[global::Cpp2ILInjected.Token(Token = "0x4001683")]
		internal static readonly char[] trimEndCharsUnix;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200056E")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60029E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD0EF4", Offset = "0x1BD0EF4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60029E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD0F50", Offset = "0x1BD0F50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60029E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD0F58", Offset = "0x1BD0F58", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal unsafe void <JoinInternal>b__56_0(global::System.Span<char> destination, [global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "HasSeparator" })] global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool> state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60029EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD10EC", Offset = "0x1BD10EC", Length = "0x254")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal unsafe void <JoinInternal>b__57_0(global::System.Span<char> destination, [global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null })] global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>> state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001684")]
			public static readonly Path.<>c <>9;

			[global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "HasSeparator" })]
			[global::Cpp2ILInjected.Token(Token = "0x4001685")]
			public static global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, bool>> <>9__56_0;

			[global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null })]
			[global::Cpp2ILInjected.Token(Token = "0x4001686")]
			public static global::System.Buffers.SpanAction<char, global::System.ValueTuple<global::System.IntPtr, int, global::System.IntPtr, int, global::System.IntPtr, int, bool, global::System.ValueTuple<bool>>> <>9__57_0;
		}
	}
}
