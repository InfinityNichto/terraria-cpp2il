using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	// Token: 0x02000218 RID: 536
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002B0")]
	[global::System.Serializable]
	public sealed class SecurityPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x000180EC File Offset: 0x000162EC
		[global::Cpp2ILInjected.Token(Token = "0x600175F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1550", Offset = "0x1AF1550", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_FullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "CheckPermissionState", MemberParameters = new object[]
		{
			typeof(PermissionState),
			typeof(bool)
		}, ReturnType = typeof(PermissionState))]
		public SecurityPermission(PermissionState state)
		{
			throw null;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000180EF File Offset: 0x000162EF
		[global::Cpp2ILInjected.Token(Token = "0x6001760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1590", Offset = "0x1AF1590", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecurityPermission(SecurityPermissionFlag flag)
		{
			throw null;
		}

		// Token: 0x1700020B RID: 523
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x000180F2 File Offset: 0x000162F2
		[global::Cpp2ILInjected.Token(Token = "0x17000261")]
		public SecurityPermissionFlag Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001761")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF15BC", Offset = "0x1AF15BC", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "Copy", ReturnType = typeof(IPermission))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000180F5 File Offset: 0x000162F5
		[global::Cpp2ILInjected.Token(Token = "0x6001762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1670", Offset = "0x1AF1670", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000180F8 File Offset: 0x000162F8
		[global::Cpp2ILInjected.Token(Token = "0x6001763")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1684", Offset = "0x1AF1684", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(SecurityPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Copy()
		{
			throw null;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000180FB File Offset: 0x000162FB
		[global::Cpp2ILInjected.Token(Token = "0x6001764")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF16EC", Offset = "0x1AF16EC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(SecurityPermission))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(SecurityPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000180FE File Offset: 0x000162FE
		[global::Cpp2ILInjected.Token(Token = "0x6001765")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1890", Offset = "0x1AF1890", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(SecurityPermission))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(SecurityPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IPermission Union(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00018101 File Offset: 0x00016301
		[global::Cpp2ILInjected.Token(Token = "0x6001766")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1964", Offset = "0x1AF1964", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(SecurityPermission))]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00018104 File Offset: 0x00016304
		[global::Cpp2ILInjected.Token(Token = "0x6001767")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF19BC", Offset = "0x1AF19BC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "CheckSecurityElement", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "IsUnrestricted", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void FromXml(SecurityElement esd)
		{
			throw null;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00018107 File Offset: 0x00016307
		[global::Cpp2ILInjected.Token(Token = "0x6001768")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1B20", Offset = "0x1AF1B20", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "Element", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0001810A File Offset: 0x0001630A
		[global::Cpp2ILInjected.Token(Token = "0x6001769")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1880", Offset = "0x1AF1880", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsEmpty()
		{
			throw null;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0001810D File Offset: 0x0001630D
		[global::Cpp2ILInjected.Token(Token = "0x600176A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF17DC", Offset = "0x1AF17DC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "ThrowInvalidPermission", MemberParameters = new object[]
		{
			typeof(IPermission),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private SecurityPermission Cast(IPermission target)
		{
			throw null;
		}

		// Token: 0x04000955 RID: 2389
		[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SecurityPermissionFlag flags;
	}
}
