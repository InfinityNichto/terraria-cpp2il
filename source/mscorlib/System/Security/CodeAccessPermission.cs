using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x02000203 RID: 515
	[global::System.MonoTODO("CAS support is experimental (and unsupported).")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000295")]
	[global::System.Serializable]
	public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x00017F75 File Offset: 0x00016175
		[global::Cpp2ILInjected.Token(Token = "0x60016CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA94C", Offset = "0x1AEA94C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Text.RegularExpressions.Regex" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.NetworkAccess",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Uri" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.NetworkAccess",
			"System.Net.TransportType",
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CodeAccessPermission()
		{
			throw null;
		}

		// Token: 0x060014CE RID: 5326
		[global::Cpp2ILInjected.Token(Token = "0x60016CD")]
		public abstract IPermission Copy();

		// Token: 0x060014CF RID: 5327 RVA: 0x00017F78 File Offset: 0x00016178
		[global::System.Diagnostics.Conditional("MONO_FEATURE_CAS")]
		[global::Cpp2ILInjected.Token(Token = "0x60016CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA954", Offset = "0x1AEA954", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "get_FullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Demand()
		{
			throw null;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00017F7B File Offset: 0x0001617B
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEAA3C", Offset = "0x1AEAA3C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060014D1 RID: 5329
		[global::Cpp2ILInjected.Token(Token = "0x60016D0")]
		public abstract void FromXml(SecurityElement elem);

		// Token: 0x060014D2 RID: 5330 RVA: 0x00017F7E File Offset: 0x0001617E
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEAB58", Offset = "0x1AEAB58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060014D3 RID: 5331
		[global::Cpp2ILInjected.Token(Token = "0x60016D2")]
		public abstract IPermission Intersect(IPermission target);

		// Token: 0x060014D4 RID: 5332
		[global::Cpp2ILInjected.Token(Token = "0x60016D3")]
		public abstract bool IsSubsetOf(IPermission target);

		// Token: 0x060014D5 RID: 5333 RVA: 0x00017F81 File Offset: 0x00016181
		[global::Cpp2ILInjected.Token(Token = "0x60016D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEAB60", Offset = "0x1AEAB60", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060014D6 RID: 5334
		[global::Cpp2ILInjected.Token(Token = "0x60016D5")]
		public abstract SecurityElement ToXml();

		// Token: 0x060014D7 RID: 5335 RVA: 0x00017F84 File Offset: 0x00016184
		[global::Cpp2ILInjected.Token(Token = "0x60016D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEAB80", Offset = "0x1AEAB80", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IPermission Union(IPermission other)
		{
			throw null;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00017F87 File Offset: 0x00016187
		[global::Cpp2ILInjected.Token(Token = "0x60016D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEABC4", Offset = "0x1AEABC4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SecurityElement Element(int version)
		{
			throw null;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00017F8A File Offset: 0x0001618A
		[global::Cpp2ILInjected.Token(Token = "0x60016D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEAD20", Offset = "0x1AEAD20", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Permissions.PermissionState)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
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
		internal static global::System.Security.Permissions.PermissionState CheckPermissionState(global::System.Security.Permissions.PermissionState state, bool allowUnrestricted)
		{
			throw null;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00017F8D File Offset: 0x0001618D
		[global::Cpp2ILInjected.Token(Token = "0x60016D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEADCC", Offset = "0x1AEADCC", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal static int CheckSecurityElement(SecurityElement se, string parameterName, int minimumVersion, int maximumVersion)
		{
			throw null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00017F90 File Offset: 0x00016190
		[global::Cpp2ILInjected.Token(Token = "0x60016DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB0E8", Offset = "0x1AEB0E8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool IsUnrestricted(SecurityElement se)
		{
			throw null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00017F93 File Offset: 0x00016193
		[global::Cpp2ILInjected.Token(Token = "0x60016DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB1BC", Offset = "0x1AEB1BC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.ReflectionPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(global::System.Security.Permissions.ReflectionPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Permissions.SecurityPermission), Member = "Cast", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(global::System.Security.Permissions.SecurityPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void ThrowInvalidPermission(IPermission target, global::System.Type expected)
		{
			throw null;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00017F96 File Offset: 0x00016196
		[global::Cpp2ILInjected.Token(Token = "0x60016DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB254", Offset = "0x1AEB254", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Security.IPermission.Demand()
		{
			throw null;
		}
	}
}
