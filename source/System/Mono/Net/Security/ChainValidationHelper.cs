﻿using System;
using System.Collections;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	internal class ChainValidationHelper : ICertificateValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D497DC", Offset = "0x1D497DC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(MonoSslAuthenticationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings),
			typeof(bool),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49B1C", Offset = "0x1D49B1C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(NetworkStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings),
			typeof(bool),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D498BC", Offset = "0x1D498BC", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "GetInternalValidator", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(ChainValidationHelper))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "Create", MemberParameters = new object[]
		{
			typeof(MobileTlsProvider),
			typeof(ref MonoTlsSettings),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(ChainValidationHelper))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "CloneWithValidator", MemberParameters = new object[] { typeof(ICertificateValidator) }, ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "GetValidationCallback", MemberParameters = new object[] { typeof(MonoTlsSettings) }, ReturnType = typeof(ServerCertValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallbackHelpers), Member = "MonoToInternal", MemberParameters = new object[] { typeof(MonoLocalCertificateSelectionCallback) }, ReturnType = typeof(LocalCertSelectionCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalCertSelectionCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49CBC", Offset = "0x1D49CBC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings),
			typeof(bool),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerCertValidationCallback), Member = ".ctor", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49E4C", Offset = "0x1D49E4C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public MonoTlsSettings Settings
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D49E88", Offset = "0x1D49E88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49E90", Offset = "0x1D49E90", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49ECC", Offset = "0x1D49ECC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Chain)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49FA0", Offset = "0x1D49FA0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(X509Chain)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(ref X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A07C", Offset = "0x1D4A07C", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "UpdateServerCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "InvokeCallback", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(MonoSslPolicyErrors?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A46C", Offset = "0x1D4A46C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(ref X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference<>), Member = "TryGetTarget", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerCertValidationCallback), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly WeakReference<SslStream> owner;

		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly MonoTlsSettings settings;

		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly MobileTlsProvider provider;

		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly ServerCertValidationCallback certValidationCallback;

		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly LocalCertSelectionCallback certSelectionCallback;

		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly MonoTlsStream tlsStream;

		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly HttpWebRequest request;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000056")]
		private sealed class <>c__DisplayClass11_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D49E44", Offset = "0x1D49E44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass11_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A520", Offset = "0x1D4A520", Length = "0x150")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "get_InternalTargetHost", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MonoTlsSettings settings;
		}
	}
}
