using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200044E RID: 1102
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._Module))]
	[global::Cpp2ILInjected.Token(Token = "0x2000510")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeModule : Module
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0001A7B0 File Offset: 0x000189B0
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0001A7B3 File Offset: 0x000189B3
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x0001A7B6 File Offset: 0x000189B6
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0001A7B9 File Offset: 0x000189B9
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

		// Token: 0x0600238C RID: 9100 RVA: 0x0001A7BC File Offset: 0x000189BC
		[global::Cpp2ILInjected.Token(Token = "0x600262A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91578", Offset = "0x1B91578", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsResource()
		{
			throw null;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0001A7BF File Offset: 0x000189BF
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

		// Token: 0x0600238E RID: 9102 RVA: 0x0001A7C2 File Offset: 0x000189C2
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

		// Token: 0x0600238F RID: 9103 RVA: 0x0001A7C5 File Offset: 0x000189C5
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

		// Token: 0x06002390 RID: 9104 RVA: 0x0001A7C8 File Offset: 0x000189C8
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

		// Token: 0x06002391 RID: 9105 RVA: 0x0001A7CB File Offset: 0x000189CB
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

		// Token: 0x06002392 RID: 9106 RVA: 0x0001A7CE File Offset: 0x000189CE
		[global::Cpp2ILInjected.Token(Token = "0x6002630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B917D4", Offset = "0x1B917D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override global::System.Guid GetModuleVersionId()
		{
			throw null;
		}

		// Token: 0x06002393 RID: 9107
		[global::Cpp2ILInjected.Token(Token = "0x6002631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91854", Offset = "0x1B91854", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void GetGuidInternal(global::System.IntPtr module, byte[] guid);

		// Token: 0x06002394 RID: 9108 RVA: 0x0001A7D1 File Offset: 0x000189D1
		[global::Cpp2ILInjected.Token(Token = "0x6002632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91858", Offset = "0x1B91858", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Module), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RuntimeModule()
		{
			throw null;
		}

		// Token: 0x040011DA RID: 4570
		[global::Cpp2ILInjected.Token(Token = "0x40014F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr _impl;

		// Token: 0x040011DB RID: 4571
		[global::Cpp2ILInjected.Token(Token = "0x40014F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Assembly assembly;

		// Token: 0x040011DC RID: 4572
		[global::Cpp2ILInjected.Token(Token = "0x40014FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string fqname;

		// Token: 0x040011DD RID: 4573
		[global::Cpp2ILInjected.Token(Token = "0x40014FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string name;

		// Token: 0x040011DE RID: 4574
		[global::Cpp2ILInjected.Token(Token = "0x40014FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string scopename;

		// Token: 0x040011DF RID: 4575
		[global::Cpp2ILInjected.Token(Token = "0x40014FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool is_resource;

		// Token: 0x040011E0 RID: 4576
		[global::Cpp2ILInjected.Token(Token = "0x40014FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal int token;
	}
}
