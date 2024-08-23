using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	internal struct RuntimeClassHandle
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00014627 File Offset: 0x00012827
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAE0C", Offset = "0x1AAAE0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0001462A File Offset: 0x0001282A
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAE14", Offset = "0x1AAAE14", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe RuntimeClassHandle(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0001462D File Offset: 0x0001282D
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		internal unsafe RuntimeStructs.MonoClass* Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAAE34", Offset = "0x1AAAE34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00014630 File Offset: 0x00012830
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAE3C", Offset = "0x1AAAE3C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00014633 File Offset: 0x00012833
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAF40", Offset = "0x1AAAF40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public unsafe override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAF68", Offset = "0x1AAAF68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern global::System.IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass);

		// Token: 0x06000021 RID: 33 RVA: 0x00014636 File Offset: 0x00012836
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAF6C", Offset = "0x1AAAF6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "GetProxyType", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal global::System.RuntimeTypeHandle GetTypeHandle()
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.MonoClass* value;
	}
}
