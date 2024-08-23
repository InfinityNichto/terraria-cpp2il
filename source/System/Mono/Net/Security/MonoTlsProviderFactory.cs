using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;
using Mono.Unity;

namespace Mono.Net.Security
{
	// Token: 0x02000021 RID: 33
	[global::Cpp2ILInjected.Token(Token = "0x2000064")]
	internal static class MonoTlsProviderFactory
	{
		// Token: 0x06000108 RID: 264 RVA: 0x000030F2 File Offset: 0x000012F2
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49BA0", Offset = "0x1D49BA0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings),
			typeof(bool),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(NetworkStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static MobileTlsProvider GetProviderInternal()
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000030F5 File Offset: 0x000012F5
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D674", Offset = "0x1D4D674", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "InitializeProviderRegistration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "CreateDefaultProviderImpl", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Guid, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Guid, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		internal static void InitializeInternal()
		{
			throw null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000030F8 File Offset: 0x000012F8
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4DD78", Offset = "0x1D4DD78", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "InitializeProviderRegistration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Guid, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Guid, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private static MobileTlsProvider LookupProvider(string name, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000030FB File Offset: 0x000012FB
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D9FC", Offset = "0x1D4D9FC", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "LookupProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Guid, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "PopulateUnityProviders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "PopulateProviders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void InitializeProviderRegistration()
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000030FE File Offset: 0x000012FE
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E290", Offset = "0x1D4E290", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeProviderRegistration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<Guid, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void PopulateUnityProviders()
		{
			throw null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003101 File Offset: 0x00001301
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E3CC", Offset = "0x1D4E3CC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeProviderRegistration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void PopulateProviders()
		{
			throw null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003104 File Offset: 0x00001304
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4DBF0", Offset = "0x1D4DBF0", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static MobileTlsProvider CreateDefaultProviderImpl()
		{
			throw null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003107 File Offset: 0x00001307
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E41C", Offset = "0x1D4E41C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NoReflectionHelper), Member = "GetProvider", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static MobileTlsProvider GetProvider()
		{
			throw null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000310A File Offset: 0x0000130A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E468", Offset = "0x1D4E468", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static MonoTlsProviderFactory()
		{
			throw null;
		}

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		private static object locker;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		private static bool initialized;

		// Token: 0x0400005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x4000118")]
		private static MobileTlsProvider defaultProvider;

		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		private static Dictionary<string, Tuple<Guid, string>> providerRegistration;

		// Token: 0x0400005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		private static Dictionary<Guid, MobileTlsProvider> providerCache;

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		internal static readonly Guid UnityTlsId;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		internal static readonly Guid AppleTlsId;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		internal static readonly Guid BtlsId;
	}
}
