using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000441 RID: 1089
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._AssemblyName))]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000501")]
	[global::System.Serializable]
	[StructLayout(0)]
	public sealed class AssemblyName : global::System.ICloneable, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback, global::System.Runtime.InteropServices._AssemblyName
	{
		// Token: 0x06002296 RID: 8854 RVA: 0x0001A55E File Offset: 0x0001875E
		[global::Cpp2ILInjected.Token(Token = "0x6002531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7ABBC", Offset = "0x1B7ABBC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyName()
		{
			throw null;
		}

		// Token: 0x06002297 RID: 8855
		[global::Cpp2ILInjected.Token(Token = "0x6002532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89474", Offset = "0x1B89474", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool ParseAssemblyName(global::System.IntPtr name, out global::Mono.MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined);

		// Token: 0x06002298 RID: 8856 RVA: 0x0001A561 File Offset: 0x00018761
		[global::Cpp2ILInjected.Token(Token = "0x6002533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7A704", Offset = "0x1B7A704", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<AssemblyName, Assembly>),
			typeof(global::System.Func<Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "CanUseDefaultResourceClasses", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "CompareNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AssemblyName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "MarshalString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::Mono.SafeStringMarshal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new object[]
		{
			typeof(global::Mono.MonoAssemblyName*),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "FreeAssemblyName", MemberParameters = new object[]
		{
			typeof(ref global::Mono.MonoAssemblyName),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public unsafe AssemblyName(string assemblyName)
		{
			throw null;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0001A564 File Offset: 0x00018764
		[global::Cpp2ILInjected.Token(Token = "0x6002534")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89704", Offset = "0x1B89704", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		internal AssemblyName(global::System.Runtime.Serialization.SerializationInfo si, global::System.Runtime.Serialization.StreamingContext sc)
		{
			throw null;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0001A567 File Offset: 0x00018767
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0001A56A File Offset: 0x0001876A
		[global::Cpp2ILInjected.Token(Token = "0x17000520")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89BF4", Offset = "0x1B89BF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002536")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89BFC", Offset = "0x1B89BFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0001A56D File Offset: 0x0001876D
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0001A570 File Offset: 0x00018770
		[global::Cpp2ILInjected.Token(Token = "0x17000521")]
		public global::System.Globalization.CultureInfo CultureInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002537")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89C04", Offset = "0x1B89C04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002538")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89C0C", Offset = "0x1B89C0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x0001A573 File Offset: 0x00018773
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x0001A576 File Offset: 0x00018776
		[global::Cpp2ILInjected.Token(Token = "0x17000522")]
		public AssemblyNameFlags Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002539")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89C14", Offset = "0x1B89C14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600253A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89C1C", Offset = "0x1B89C1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0001A579 File Offset: 0x00018779
		[global::Cpp2ILInjected.Token(Token = "0x17000523")]
		public string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600253B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B89C24", Offset = "0x1B89C24", Length = "0x330")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "LoadSatellite", MemberParameters = new object[]
			{
				typeof(AssemblyName),
				typeof(bool),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(Assembly))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Version),
				typeof(global::System.Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0001A57C File Offset: 0x0001877C
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0001A57F File Offset: 0x0001877F
		[global::Cpp2ILInjected.Token(Token = "0x17000524")]
		public global::System.Version Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x600253C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A038", Offset = "0x1B8A038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600253D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8911C", Offset = "0x1B8911C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Globalization.CultureInfo),
				typeof(global::System.Version),
				typeof(bool),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(RuntimeAssembly))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Version),
				typeof(global::System.Version)
			}, ReturnType = typeof(bool))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0001A582 File Offset: 0x00018782
		[global::Cpp2ILInjected.Token(Token = "0x600253E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A040", Offset = "0x1B8A040", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0001A585 File Offset: 0x00018785
		[global::Cpp2ILInjected.Token(Token = "0x600253F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A068", Offset = "0x1B8A068", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] GetPublicKey()
		{
			throw null;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0001A588 File Offset: 0x00018788
		[global::Cpp2ILInjected.Token(Token = "0x6002540")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AC20", Offset = "0x1B7AC20", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "CompareNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AssemblyName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public byte[] GetPublicKeyToken()
		{
			throw null;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x0001A58B File Offset: 0x0001878B
		[global::Cpp2ILInjected.Token(Token = "0x17000525")]
		private bool IsPublicKeyValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002541")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8A070", Offset = "0x1B8A070", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0001A58E File Offset: 0x0001878E
		[global::Cpp2ILInjected.Token(Token = "0x6002542")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89F54", Offset = "0x1B89F54", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private byte[] InternalGetPublicKeyToken()
		{
			throw null;
		}

		// Token: 0x060022A8 RID: 8872
		[global::Cpp2ILInjected.Token(Token = "0x6002543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A170", Offset = "0x1B8A170", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void get_public_token(byte* token, byte* pubkey, int len);

		// Token: 0x060022A9 RID: 8873 RVA: 0x0001A591 File Offset: 0x00018791
		[global::Cpp2ILInjected.Token(Token = "0x6002544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A0DC", Offset = "0x1B8A0DC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private byte[] ComputePublicKeyToken()
		{
			throw null;
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0001A594 File Offset: 0x00018794
		[global::Cpp2ILInjected.Token(Token = "0x6002545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AC00", Offset = "0x1B7AC00", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPublicKey(byte[] publicKey)
		{
			throw null;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x0001A597 File Offset: 0x00018797
		[global::Cpp2ILInjected.Token(Token = "0x6002546")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A174", Offset = "0x1B8A174", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0001A59A File Offset: 0x0001879A
		[global::Cpp2ILInjected.Token(Token = "0x6002547")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A4A0", Offset = "0x1B8A4A0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0001A59D File Offset: 0x0001879D
		[global::Cpp2ILInjected.Token(Token = "0x6002548")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A548", Offset = "0x1B8A548", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "set_Version", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		public void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x060022AE RID: 8878
		[global::Cpp2ILInjected.Token(Token = "0x6002549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A550", Offset = "0x1B8A550", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::Mono.MonoAssemblyName* GetNativeName(global::System.IntPtr assembly_ptr);

		// Token: 0x060022AF RID: 8879 RVA: 0x0001A5A0 File Offset: 0x000187A0
		[global::Cpp2ILInjected.Token(Token = "0x600254A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89478", Offset = "0x1B89478", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssemblyName), Member = "Create", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(AssemblyName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "PtrToUtf8String", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "CreateCulture", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "DecodeBlobArray", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "AsciHexDigitValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal unsafe void FillName(global::Mono.MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			throw null;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0001A5A3 File Offset: 0x000187A3
		[global::Cpp2ILInjected.Token(Token = "0x600254B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A554", Offset = "0x1B8A554", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeAssembly), Member = "GetName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(AssemblyName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new object[]
		{
			typeof(global::Mono.MonoAssemblyName*),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			throw null;
		}

		// Token: 0x04001192 RID: 4498
		[global::Cpp2ILInjected.Token(Token = "0x40014AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04001193 RID: 4499
		[global::Cpp2ILInjected.Token(Token = "0x40014AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string codebase;

		// Token: 0x04001194 RID: 4500
		[global::Cpp2ILInjected.Token(Token = "0x40014AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int major;

		// Token: 0x04001195 RID: 4501
		[global::Cpp2ILInjected.Token(Token = "0x40014AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int minor;

		// Token: 0x04001196 RID: 4502
		[global::Cpp2ILInjected.Token(Token = "0x40014B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int build;

		// Token: 0x04001197 RID: 4503
		[global::Cpp2ILInjected.Token(Token = "0x40014B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int revision;

		// Token: 0x04001198 RID: 4504
		[global::Cpp2ILInjected.Token(Token = "0x40014B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Globalization.CultureInfo cultureinfo;

		// Token: 0x04001199 RID: 4505
		[global::Cpp2ILInjected.Token(Token = "0x40014B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AssemblyNameFlags flags;

		// Token: 0x0400119A RID: 4506
		[global::Cpp2ILInjected.Token(Token = "0x40014B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private global::System.Configuration.Assemblies.AssemblyHashAlgorithm hashalg;

		// Token: 0x0400119B RID: 4507
		[global::Cpp2ILInjected.Token(Token = "0x40014B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private StrongNameKeyPair keypair;

		// Token: 0x0400119C RID: 4508
		[global::Cpp2ILInjected.Token(Token = "0x40014B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] publicKey;

		// Token: 0x0400119D RID: 4509
		[global::Cpp2ILInjected.Token(Token = "0x40014B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] keyToken;

		// Token: 0x0400119E RID: 4510
		[global::Cpp2ILInjected.Token(Token = "0x40014B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Configuration.Assemblies.AssemblyVersionCompatibility versioncompat;

		// Token: 0x0400119F RID: 4511
		[global::Cpp2ILInjected.Token(Token = "0x40014B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Version version;

		// Token: 0x040011A0 RID: 4512
		[global::Cpp2ILInjected.Token(Token = "0x40014BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ProcessorArchitecture processor_architecture;

		// Token: 0x040011A1 RID: 4513
		[global::Cpp2ILInjected.Token(Token = "0x40014BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private AssemblyContentType contentType;
	}
}
