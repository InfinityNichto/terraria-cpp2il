using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x02000204 RID: 516
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000296")]
	[global::System.Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x060014DE RID: 5342 RVA: 0x00017F99 File Offset: 0x00016199
		[global::Cpp2ILInjected.Token(Token = "0x60016DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB258", Offset = "0x1AEB258", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal NamedPermissionSet()
		{
			throw null;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00017F9C File Offset: 0x0001619C
		[global::Cpp2ILInjected.Token(Token = "0x60016DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB310", Offset = "0x1AEB310", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "CheckPermissionState", MemberParameters = new object[]
		{
			typeof(global::System.Security.Permissions.PermissionState),
			typeof(bool)
		}, ReturnType = typeof(global::System.Security.Permissions.PermissionState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamedPermissionSet), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NamedPermissionSet(string name, global::System.Security.Permissions.PermissionState state)
		{
			throw null;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00017F9F File Offset: 0x0001619F
		[global::Cpp2ILInjected.Token(Token = "0x60016DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB478", Offset = "0x1AEB478", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "set_XmlResolver", MemberParameters = new object[] { "System.Xml.XmlResolver" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Permissions.PermissionState)
		}, ReturnType = typeof(void))]
		public NamedPermissionSet(string name)
		{
			throw null;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00017FA2 File Offset: 0x000161A2
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00017FA5 File Offset: 0x000161A5
		[global::Cpp2ILInjected.Token(Token = "0x1700024C")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEB480", Offset = "0x1AEB480", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60016E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEB3C0", Offset = "0x1AEB3C0", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Security.Permissions.PermissionState)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00017FA8 File Offset: 0x000161A8
		[global::Cpp2ILInjected.Token(Token = "0x60016E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB488", Offset = "0x1AEB488", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00017FAB File Offset: 0x000161AB
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB950", Offset = "0x1AEB950", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00017FAE File Offset: 0x000161AE
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEBB84", Offset = "0x1AEBB84", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000904 RID: 2308
		[global::Cpp2ILInjected.Token(Token = "0x4000B97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string name;

		// Token: 0x04000905 RID: 2309
		[global::Cpp2ILInjected.Token(Token = "0x4000B98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string description;
	}
}
