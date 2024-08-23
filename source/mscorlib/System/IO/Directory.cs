using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.IO
{
	// Token: 0x0200047F RID: 1151
	[global::Cpp2ILInjected.Token(Token = "0x200054A")]
	public static class Directory
	{
		// Token: 0x06002563 RID: 9571 RVA: 0x0001AD32 File Offset: 0x00018F32
		[global::Cpp2ILInjected.Token(Token = "0x6002837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA08D0", Offset = "0x1BA08D0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static DirectoryInfo GetParent(string path)
		{
			throw null;
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0001AD35 File Offset: 0x00018F35
		[global::Cpp2ILInjected.Token(Token = "0x6002838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA0A88", Offset = "0x1BA0A88", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "WriteFile", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUnityRunner", Member = "GetNextScreenshotFilename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "TryCreatingDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = "GetFiles", ReturnType = "System.Collections.Generic.IEnumerable`1<String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ValidateOutput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "CheckStore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static DirectoryInfo CreateDirectory(string path)
		{
			throw null;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0001AD38 File Offset: 0x00018F38
		[global::Cpp2ILInjected.Token(Token = "0x6002839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA11DC", Offset = "0x1BA11DC", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystem), Member = "FileExists", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(ref global::Interop.ErrorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static bool Exists(string path)
		{
			throw null;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0001AD3B File Offset: 0x00018F3B
		[global::Cpp2ILInjected.Token(Token = "0x600283A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1378", Offset = "0x1BA1378", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "MoveToCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Ionic.Zip.AddOrUpdateAction",
			typeof(bool),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string[] GetFiles(string path)
		{
			throw null;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0001AD3E File Offset: 0x00018F3E
		[global::Cpp2ILInjected.Token(Token = "0x600283B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1488", Offset = "0x1BA1488", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = "GetFiles", ReturnType = "System.Collections.Generic.IEnumerable`1<String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string[] GetFiles(string path, string searchPattern)
		{
			throw null;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0001AD41 File Offset: 0x00018F41
		[global::Cpp2ILInjected.Token(Token = "0x600283C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1528", Offset = "0x1BA1528", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.FileSystemContentSource", Member = "BuildNameToAbsolutePathDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaContentSource", Member = "BuildFileMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.XnaDirectContentSource", Member = "BuildFileMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = "LoadDeviceProfilesFromPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EnumerationOptions), Member = "FromSearchOption", MemberParameters = new object[] { typeof(SearchOption) }, ReturnType = typeof(EnumerationOptions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			throw null;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0001AD44 File Offset: 0x00018F44
		[global::Cpp2ILInjected.Token(Token = "0x600283D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1420", Offset = "0x1BA1420", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchOption)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			throw null;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0001AD47 File Offset: 0x00018F47
		[global::Cpp2ILInjected.Token(Token = "0x600283E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1894", Offset = "0x1BA1894", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "GetFolders", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Ionic.Zip.AddOrUpdateAction",
			typeof(bool),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string[] GetDirectories(string path)
		{
			throw null;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0001AD4A File Offset: 0x00018F4A
		[global::Cpp2ILInjected.Token(Token = "0x600283F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA193C", Offset = "0x1BA193C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchTarget),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			throw null;
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x0001AD4D File Offset: 0x00018F4D
		[global::Cpp2ILInjected.Token(Token = "0x6002840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA16D4", Offset = "0x1BA16D4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "UserFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "UserDirectories", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerableFactory), Member = "UserEntries", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static global::System.Collections.Generic.IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			throw null;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0001AD50 File Offset: 0x00018F50
		[global::Cpp2ILInjected.Token(Token = "0x6002841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA19A4", Offset = "0x1BA19A4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "GetRootLength", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string InternalGetDirectoryRoot(string path)
		{
			throw null;
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x0001AD53 File Offset: 0x00018F53
		[global::Cpp2ILInjected.Token(Token = "0x6002842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1A5C", Offset = "0x1BA1A5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
		public static string GetCurrentDirectory()
		{
			throw null;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x0001AD56 File Offset: 0x00018F56
		[global::Cpp2ILInjected.Token(Token = "0x6002843")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1A64", Offset = "0x1BA1A64", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoIO), Member = "GetCurrentDirectory", MemberParameters = new object[] { typeof(ref MonoIOError) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new object[] { typeof(MonoIOError) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static string InsecureGetCurrentDirectory()
		{
			throw null;
		}
	}
}
