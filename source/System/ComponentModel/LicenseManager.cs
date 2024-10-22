﻿using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000395")]
	public sealed class LicenseManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD20", Offset = "0x1E4DD20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private LicenseManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700056F")]
		public static LicenseContext CurrentContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4DD28", Offset = "0x1E4DD28", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "CreateWithContext", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(LicenseContext),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object),
				typeof(bool),
				typeof(ref License)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeLicenseContext), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4DEE0", Offset = "0x1E4DEE0", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "CreateWithContext", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(LicenseContext),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000570")]
		public static LicenseUsageMode UsageMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4E06C", Offset = "0x1E4E06C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E108", Offset = "0x1E4E108", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void CacheProvider(Type type, LicenseProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E2B4", Offset = "0x1E4E2B4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E374", Offset = "0x1E4E374", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "get_CurrentContext", ReturnType = typeof(LicenseContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "set_CurrentContext", MemberParameters = new object[] { typeof(LicenseContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "LockContext", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "UnlockContext", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E7C4", Offset = "0x1E4E7C4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool GetCachedNoLicenseProvider(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E86C", Offset = "0x1E4E86C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static LicenseProvider GetCachedProvider(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E934", Offset = "0x1E4E934", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static LicenseProvider GetCachedProviderInstance(Type providerType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E9FC", Offset = "0x1E4E9FC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsLicensed(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4EB2C", Offset = "0x1E4EB2C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValid(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4EBCC", Offset = "0x1E4EBCC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValid(Type type, object instance, out License license)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4E63C", Offset = "0x1E4E63C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "CreateWithContext", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(LicenseContext),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void LockContext(object contextUser)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4EC3C", Offset = "0x1E4EC3C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "CreateWithContext", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(LicenseContext),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void UnlockContext(object contextUser)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4EA9C", Offset = "0x1E4EA9C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "IsLicensed", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "IsValid", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "Validate", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "Validate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(License))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "get_CurrentContext", ReturnType = typeof(LicenseContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4EDC8", Offset = "0x1E4EDC8", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "GetCachedProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(LicenseProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "GetCachedNoLicenseProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseProviderAttribute), Member = "get_LicenseProvider", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "GetCachedProviderInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(LicenseProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "CacheProvider", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(LicenseProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			typeof(LicenseContext),
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F1DC", Offset = "0x1E4F1DC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseException), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Validate(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F2A0", Offset = "0x1E4F2A0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseManager), Member = "ValidateInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(bool),
			typeof(ref License)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static License Validate(Type type, object instance)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F358", Offset = "0x1E4F358", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static LicenseManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400122F")]
		private static readonly object s_selfLock;

		[global::Cpp2ILInjected.Token(Token = "0x4001230")]
		private static LicenseContext s_context;

		[global::Cpp2ILInjected.Token(Token = "0x4001231")]
		private static object s_contextLockHolder;

		[global::Cpp2ILInjected.Token(Token = "0x4001232")]
		private static Hashtable s_providers;

		[global::Cpp2ILInjected.Token(Token = "0x4001233")]
		private static Hashtable s_providerInstances;

		[global::Cpp2ILInjected.Token(Token = "0x4001234")]
		private static readonly object s_internalSyncObject;
	}
}
