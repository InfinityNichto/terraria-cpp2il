using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200002E RID: 46
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	internal class KeyPairPersistence
	{
		// Token: 0x060000ED RID: 237 RVA: 0x0001488E File Offset: 0x00012A8E
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB8C88", Offset = "0x1AB8C88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "ImportCspBlob", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public KeyPairPersistence(global::System.Security.Cryptography.CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00014891 File Offset: 0x00012A91
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB8C90", Offset = "0x1AB8C90", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "Copy", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(global::System.Security.Cryptography.CspParameters))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public KeyPairPersistence(global::System.Security.Cryptography.CspParameters parameters, string keyPair)
		{
			throw null;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00014894 File Offset: 0x00012A94
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public string Filename
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000131")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB8D9C", Offset = "0x1AB8D9C", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Remove", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00014897 File Offset: 0x00012A97
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0001489A File Offset: 0x00012A9A
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public string KeyValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000132")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB9A6C", Offset = "0x1AB9A6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000133")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB9A74", Offset = "0x1AB9A74", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.EventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.EventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0001489D File Offset: 0x00012A9D
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public global::System.Security.Cryptography.CspParameters Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000134")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB9A98", Offset = "0x1AB9A98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "get_CspKeyContainerInfo", ReturnType = typeof(global::System.Security.Cryptography.CspKeyContainerInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "ExportCspBlob", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "Copy", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(global::System.Security.Cryptography.CspParameters))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000148A0 File Offset: 0x00012AA0
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB9AA0", Offset = "0x1AB9AA0", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "OpenText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.StreamReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "FromXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool Load()
		{
			throw null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000148A3 File Offset: 0x00012AA3
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB9D40", Offset = "0x1AB9D40", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode)
		}, ReturnType = typeof(global::System.IO.FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Save()
		{
			throw null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000148A6 File Offset: 0x00012AA6
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA2A0", Offset = "0x1ABA2A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void Remove()
		{
			throw null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000148A9 File Offset: 0x00012AA9
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		private static string UserPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000138")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB9544", Offset = "0x1AB9544", Length = "0x528")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(global::System.Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.DirectoryInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000148AC File Offset: 0x00012AAC
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		private static string MachinePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000139")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB901C", Offset = "0x1AB901C", Length = "0x528")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(global::System.Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.DirectoryInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3D4", Offset = "0x1ABA3D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool _CanSecure(char* root);

		// Token: 0x060000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3D8", Offset = "0x1ABA3D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool _ProtectUser(char* path);

		// Token: 0x060000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3DC", Offset = "0x1ABA3DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool _ProtectMachine(char* path);

		// Token: 0x060000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3E0", Offset = "0x1ABA3E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool _IsUserProtected(char* path);

		// Token: 0x060000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3E4", Offset = "0x1ABA3E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern bool _IsMachineProtected(char* path);

		// Token: 0x060000FD RID: 253 RVA: 0x000148AF File Offset: 0x00012AAF
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA3E8", Offset = "0x1ABA3E8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_OSVersion", ReturnType = typeof(global::System.OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CanSecure(string path)
		{
			throw null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000148B2 File Offset: 0x00012AB2
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA210", Offset = "0x1ABA210", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool ProtectUser(string path)
		{
			throw null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000148B5 File Offset: 0x00012AB5
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA180", Offset = "0x1ABA180", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool ProtectMachine(string path)
		{
			throw null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000148B8 File Offset: 0x00012AB8
		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA2B4", Offset = "0x1ABA2B4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool IsUserProtected(string path)
		{
			throw null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000148BB File Offset: 0x00012ABB
		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA344", Offset = "0x1ABA344", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool IsMachineProtected(string path)
		{
			throw null;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000148BE File Offset: 0x00012ABE
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		private bool CanChange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000144")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB9A88", Offset = "0x1AB9A88", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000148C1 File Offset: 0x00012AC1
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		private bool UseDefaultKeyContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000145")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABA480", Offset = "0x1ABA480", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000148C4 File Offset: 0x00012AC4
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		private bool UseMachineKeyStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000146")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB900C", Offset = "0x1AB900C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000148C7 File Offset: 0x00012AC7
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		private string ContainerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000147")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB8F20", Offset = "0x1AB8F20", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.MD5), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.MD5))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "NewGuid", ReturnType = typeof(global::System.Guid))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000148CA File Offset: 0x00012ACA
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB8D10", Offset = "0x1AB8D10", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.CspParameters),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "get_Parameters", ReturnType = typeof(global::System.Security.Cryptography.CspParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CspParameters), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.CspProviderFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Security.Cryptography.CspParameters Copy(global::System.Security.Cryptography.CspParameters p)
		{
			throw null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000148CD File Offset: 0x00012ACD
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB9C40", Offset = "0x1AB9C40", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Xml.SecurityParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Xml.SecurityParser), Member = "LoadXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "SearchForChildByTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void FromXml(string xml)
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000148D0 File Offset: 0x00012AD0
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB9F78", Offset = "0x1AB9F78", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private string ToXml()
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000148D3 File Offset: 0x00012AD3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABA490", Offset = "0x1ABA490", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static KeyPairPersistence()
		{
			throw null;
		}

		// Token: 0x04000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		private static bool _userPathExists;

		// Token: 0x04000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		private static string _userPath;

		// Token: 0x04000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		private static bool _machinePathExists;

		// Token: 0x04000095 RID: 149
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		private static string _machinePath;

		// Token: 0x04000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Security.Cryptography.CspParameters _params;

		// Token: 0x04000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _keyvalue;

		// Token: 0x04000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _filename;

		// Token: 0x04000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _container;

		// Token: 0x0400009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		private static object lockobj;
	}
}
