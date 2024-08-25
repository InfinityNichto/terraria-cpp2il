using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._Module))]
	[global::Cpp2ILInjected.Token(Token = "0x2000510")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeModule : Module
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700055D")]
		public override Assembly Assembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002626")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91550", Offset = "0x1B91550", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700055E")]
		public override string ScopeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002627")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91558", Offset = "0x1B91558", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700055F")]
		public override global::System.Guid ModuleVersionId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002628")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91560", Offset = "0x1B91560", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000560")]
		public override string FullyQualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002629")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91570", Offset = "0x1B91570", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600262A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91578", Offset = "0x1B91578", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsResource()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600262B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91580", Offset = "0x1B91580", Length = "0x68")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600262C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B915E8", Offset = "0x1B915E8", Length = "0x70")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600262D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91658", Offset = "0x1B91658", Length = "0x70")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600262E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B916C8", Offset = "0x1B916C8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeModule), Member = "GetRuntimeAssembly", ReturnType = typeof(RuntimeAssembly))]
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

		[global::Cpp2ILInjected.Token(Token = "0x600262F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9175C", Offset = "0x1B9175C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeModule), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B917D4", Offset = "0x1B917D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override global::System.Guid GetModuleVersionId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91854", Offset = "0x1B91854", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void GetGuidInternal(global::System.IntPtr module, byte[] guid);

		[global::Cpp2ILInjected.Token(Token = "0x6002632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91858", Offset = "0x1B91858", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Module), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RuntimeModule()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr _impl;

		[global::Cpp2ILInjected.Token(Token = "0x40014F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Assembly assembly;

		[global::Cpp2ILInjected.Token(Token = "0x40014FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string fqname;

		[global::Cpp2ILInjected.Token(Token = "0x40014FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string name;

		[global::Cpp2ILInjected.Token(Token = "0x40014FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string scopename;

		[global::Cpp2ILInjected.Token(Token = "0x40014FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool is_resource;

		[global::Cpp2ILInjected.Token(Token = "0x40014FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal int token;
	}
}
