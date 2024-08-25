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
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._AssemblyName))]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000501")]
	[global::System.Serializable]
	[StructLayout(0)]
	public sealed class AssemblyName : global::System.ICloneable, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback, global::System.Runtime.InteropServices._AssemblyName
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7ABBC", Offset = "0x1B7ABBC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B89474", Offset = "0x1B89474", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool ParseAssemblyName(global::System.IntPtr name, out global::Mono.MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined);

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

		[global::Cpp2ILInjected.Token(Token = "0x600253E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A040", Offset = "0x1B8A040", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600253F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A068", Offset = "0x1B8A068", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] GetPublicKey()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A170", Offset = "0x1B8A170", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void get_public_token(byte* token, byte* pubkey, int len);

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

		[global::Cpp2ILInjected.Token(Token = "0x6002545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7AC00", Offset = "0x1B7AC00", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPublicKey(byte[] publicKey)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002547")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A4A0", Offset = "0x1B8A4A0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002548")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A548", Offset = "0x1B8A548", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "set_Version", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		public void OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8A550", Offset = "0x1B8A550", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::Mono.MonoAssemblyName* GetNativeName(global::System.IntPtr assembly_ptr);

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

		[global::Cpp2ILInjected.Token(Token = "0x40014AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		[global::Cpp2ILInjected.Token(Token = "0x40014AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string codebase;

		[global::Cpp2ILInjected.Token(Token = "0x40014AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int major;

		[global::Cpp2ILInjected.Token(Token = "0x40014AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int minor;

		[global::Cpp2ILInjected.Token(Token = "0x40014B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int build;

		[global::Cpp2ILInjected.Token(Token = "0x40014B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int revision;

		[global::Cpp2ILInjected.Token(Token = "0x40014B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Globalization.CultureInfo cultureinfo;

		[global::Cpp2ILInjected.Token(Token = "0x40014B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AssemblyNameFlags flags;

		[global::Cpp2ILInjected.Token(Token = "0x40014B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private global::System.Configuration.Assemblies.AssemblyHashAlgorithm hashalg;

		[global::Cpp2ILInjected.Token(Token = "0x40014B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private StrongNameKeyPair keypair;

		[global::Cpp2ILInjected.Token(Token = "0x40014B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] publicKey;

		[global::Cpp2ILInjected.Token(Token = "0x40014B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] keyToken;

		[global::Cpp2ILInjected.Token(Token = "0x40014B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Configuration.Assemblies.AssemblyVersionCompatibility versioncompat;

		[global::Cpp2ILInjected.Token(Token = "0x40014B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Version version;

		[global::Cpp2ILInjected.Token(Token = "0x40014BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ProcessorArchitecture processor_architecture;

		[global::Cpp2ILInjected.Token(Token = "0x40014BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private AssemblyContentType contentType;
	}
}
