﻿using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	internal static class DependencyInjector
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		internal static ISystemDependencyProvider SystemProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAA854", Offset = "0x1AAA854", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(ISystemDependencyProvider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAB90", Offset = "0x1AAAB90", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.SystemDependencyProvider", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static void Register(ISystemDependencyProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAA50", Offset = "0x1AAAA50", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.PropertyInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Reflection.PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.PropertyInfo), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static ISystemDependencyProvider ReflectionLoad()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAD2C", Offset = "0x1AAAD2C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DependencyInjector()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		private static object locker;

		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		private static ISystemDependencyProvider systemDependency;
	}
}
