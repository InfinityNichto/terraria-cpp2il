using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Permissions
{
	// Token: 0x02000215 RID: 533
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002AD")]
	[global::System.Serializable]
	public sealed class ReflectionPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x000180BF File Offset: 0x000162BF
		[global::Cpp2ILInjected.Token(Token = "0x600174F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0DA4", Offset = "0x1AF0DA4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "CheckPermissionState", MemberParameters = new object[]
		{
			typeof(PermissionState),
			typeof(bool)
		}, ReturnType = typeof(PermissionState))]
		public ReflectionPermission(PermissionState state)
		{
			throw null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x000180C2 File Offset: 0x000162C2
		[global::Cpp2ILInjected.Token(Token = "0x6001750")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0DE4", Offset = "0x1AF0DE4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ReflectionPermission(ReflectionPermissionFlag flag)
		{
			throw null;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000180C5 File Offset: 0x000162C5
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x000180C8 File Offset: 0x000162C8
		[global::Cpp2ILInjected.Token(Token = "0x1700025E")]
		public ReflectionPermissionFlag Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001751")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0EC4", Offset = "0x1AF0EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001752")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0E10", Offset = "0x1AF0E10", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "Copy", ReturnType = typeof(IPermission))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
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

		// Token: 0x06001544 RID: 5444 RVA: 0x000180CB File Offset: 0x000162CB
		[global::Cpp2ILInjected.Token(Token = "0x6001753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0ECC", Offset = "0x1AF0ECC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(ReflectionPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Copy()
		{
			throw null;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000180CE File Offset: 0x000162CE
		[global::Cpp2ILInjected.Token(Token = "0x6001754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0F34", Offset = "0x1AF0F34", Length = "0x174")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "get_Attributes", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void FromXml(SecurityElement esd)
		{
			throw null;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000180D1 File Offset: 0x000162D1
		[global::Cpp2ILInjected.Token(Token = "0x6001755")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF10A8", Offset = "0x1AF10A8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(ReflectionPermission))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(ReflectionPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000180D4 File Offset: 0x000162D4
		[global::Cpp2ILInjected.Token(Token = "0x6001756")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1240", Offset = "0x1AF1240", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(ReflectionPermission))]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000180D7 File Offset: 0x000162D7
		[global::Cpp2ILInjected.Token(Token = "0x6001757")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1230", Offset = "0x1AF1230", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000180DA File Offset: 0x000162DA
		[global::Cpp2ILInjected.Token(Token = "0x6001758")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1290", Offset = "0x1AF1290", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "Element", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000180DD File Offset: 0x000162DD
		[global::Cpp2ILInjected.Token(Token = "0x6001759")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF145C", Offset = "0x1AF145C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(ReflectionPermission))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = "set_Flags", MemberParameters = new object[] { typeof(ReflectionPermissionFlag) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IPermission Union(IPermission other)
		{
			throw null;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000180E0 File Offset: 0x000162E0
		[global::Cpp2ILInjected.Token(Token = "0x600175A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF118C", Offset = "0x1AF118C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "ThrowInvalidPermission", MemberParameters = new object[]
		{
			typeof(IPermission),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private ReflectionPermission Cast(IPermission target)
		{
			throw null;
		}

		// Token: 0x04000948 RID: 2376
		[global::Cpp2ILInjected.Token(Token = "0x4000BF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ReflectionPermissionFlag flags;
	}
}
