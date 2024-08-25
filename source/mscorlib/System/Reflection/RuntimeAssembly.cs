using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Globalization.Unicode;

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._Assembly))]
	[global::Cpp2ILInjected.Token(Token = "0x2000507")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeAssembly : Assembly
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BBF0", Offset = "0x1B8BBF0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected RuntimeAssembly()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BC54", Offset = "0x1B8BC54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int),
			typeof(string),
			typeof(RuntimeAssembly)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002568")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BCDC", Offset = "0x1B8BCDC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new object[] { typeof(AssemblyName) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new object[]
		{
			typeof(AssemblyName),
			typeof(global::System.Security.Policy.Evidence),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(bool)
		}, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, global::System.Security.Policy.Evidence securityEvidence, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002569")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BD64", Offset = "0x1B8BD64", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new object[] { typeof(AssemblyName) }, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(RuntimeAssembly))]
		internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, global::System.Security.Policy.Evidence securityEvidence, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BD88", Offset = "0x1B8BD88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssemblyName), Member = "Create", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(bool)
		}, ReturnType = typeof(AssemblyName))]
		public override AssemblyName GetName(bool copiedName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BD90", Offset = "0x1B8BD90", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override global::System.Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BE48", Offset = "0x1B8BE48", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override Module GetModule(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BF58", Offset = "0x1B8BF58", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Module[] GetModules(bool getResourceModules)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C0CC", Offset = "0x1B8C0CC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static byte[] GetAotId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600256F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C128", Offset = "0x1B8C128", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string get_code_base(Assembly a, bool escaped);

		[global::Cpp2ILInjected.Token(Token = "0x6002570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C130", Offset = "0x1B8C130", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern string get_location();

		[global::Cpp2ILInjected.Token(Token = "0x6002571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C134", Offset = "0x1B8C134", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string get_fullname(Assembly a);

		[global::Cpp2ILInjected.Token(Token = "0x6002572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C124", Offset = "0x1B8C124", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool GetAotIdInternal(byte[] aotid);

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700052A")]
		public override extern bool ReflectionOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002573")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C138", Offset = "0x1B8C138", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C13C", Offset = "0x1B8C13C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string GetCodeBase(Assembly a, bool escaped)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052B")]
		public override string CodeBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002575")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C144", Offset = "0x1B8C144", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052C")]
		public override string EscapedCodeBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002576")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C14C", Offset = "0x1B8C14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052D")]
		public override string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002577")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C154", Offset = "0x1B8C154", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052E")]
		internal override global::System.IntPtr MonoAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002578")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C158", Offset = "0x1B8C158", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700052F")]
		public override string Location
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002579")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8C160", Offset = "0x1B8C160", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600257A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C1C4", Offset = "0x1B8C1C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x600257B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C1C8", Offset = "0x1B8C1C8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600257C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C2C8", Offset = "0x1B8C2C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public override extern string[] GetManifestResourceNames();

		[global::Cpp2ILInjected.Token(Token = "0x600257D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C2CC", Offset = "0x1B8C2CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Globalization.Unicode.MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern global::System.IntPtr GetManifestResourceInternal(string name, out int size, out Module module);

		[global::Cpp2ILInjected.Token(Token = "0x600257E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C2D0", Offset = "0x1B8C2D0", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(global::System.AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AppDomain), Member = "DoResourceResolve", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Assembly)
		}, ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeAssembly.UnmanagedMemoryStreamForModule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(Module)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode),
			typeof(global::System.IO.FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public unsafe override global::System.IO.Stream GetManifestResourceStream(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600257F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C618", Offset = "0x1B8C618", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C688", Offset = "0x1B8C688", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C6F0", Offset = "0x1B8C6F0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C760", Offset = "0x1B8C760", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal override extern Module[] GetModulesInternal();

		[global::Cpp2ILInjected.Token(Token = "0x6002583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C764", Offset = "0x1B8C764", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C76C", Offset = "0x1B8C76C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8C80C", Offset = "0x1B8C80C", Length = "0x102C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr _mono_assembly;

		[global::Cpp2ILInjected.Token(Token = "0x40014D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _evidence;

		[global::Cpp2ILInjected.Token(Token = "0x40014D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Assembly.ResolveEventHolder resolve_event_holder;

		[global::Cpp2ILInjected.Token(Token = "0x40014D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _minimum;

		[global::Cpp2ILInjected.Token(Token = "0x40014D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object _optional;

		[global::Cpp2ILInjected.Token(Token = "0x40014D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _refuse;

		[global::Cpp2ILInjected.Token(Token = "0x40014D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object _granted;

		[global::Cpp2ILInjected.Token(Token = "0x40014DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private object _denied;

		[global::Cpp2ILInjected.Token(Token = "0x40014DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool fromByteArray;

		[global::Cpp2ILInjected.Token(Token = "0x40014DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string assemblyName;

		[global::Cpp2ILInjected.Token(Token = "0x2000508")]
		internal class UnmanagedMemoryStreamForModule : global::System.IO.UnmanagedMemoryStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002586")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8D838", Offset = "0x1B8D838", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(long)
			}, ReturnType = typeof(void))]
			public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002587")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8D8DC", Offset = "0x1B8D8DC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40014DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Module module;
		}
	}
}
