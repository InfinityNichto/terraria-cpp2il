using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002B0")]
	[global::System.Serializable]
	public sealed class SecurityPermission : CodeAccessPermission, IUnrestrictedPermission
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1590", Offset = "0x1AF1590", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecurityPermission(SecurityPermissionFlag flag)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1670", Offset = "0x1AF1670", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001766")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1964", Offset = "0x1AF1964", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(SecurityPermission))]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001769")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1880", Offset = "0x1AF1880", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsEmpty()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SecurityPermissionFlag flags;
	}
}
