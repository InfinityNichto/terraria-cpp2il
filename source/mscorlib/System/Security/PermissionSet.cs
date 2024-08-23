using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x02000205 RID: 517
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.MonoTODO("CAS support is experimental (and unsupported).")]
	[global::Cpp2ILInjected.Token(Token = "0x2000297")]
	[global::System.Serializable]
	public class PermissionSet : ISecurityEncodable, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x00017FB1 File Offset: 0x000161B1
		[global::Cpp2ILInjected.Token(Token = "0x60016E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB2AC", Offset = "0x1AEB2AC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Permissions.PermissionState)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = ".ctor", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal PermissionSet()
		{
			throw null;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00017FB4 File Offset: 0x000161B4
		[global::Cpp2ILInjected.Token(Token = "0x60016E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB390", Offset = "0x1AEB390", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "CheckPermissionState", MemberParameters = new object[]
		{
			typeof(global::System.Security.Permissions.PermissionState),
			typeof(bool)
		}, ReturnType = typeof(global::System.Security.Permissions.PermissionState))]
		public PermissionSet(global::System.Security.Permissions.PermissionState state)
		{
			throw null;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00017FB7 File Offset: 0x000161B7
		[global::Cpp2ILInjected.Token(Token = "0x60016E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA988", Offset = "0x1AEA988", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal PermissionSet(IPermission perm)
		{
			throw null;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00017FBA File Offset: 0x000161BA
		[global::Cpp2ILInjected.Token(Token = "0x60016E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEBBF8", Offset = "0x1AEBBF8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00017FBD File Offset: 0x000161BD
		[global::Cpp2ILInjected.Token(Token = "0x60016E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEBD54", Offset = "0x1AEBD54", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "set_XmlResolver", MemberParameters = new object[] { "System.Xml.XmlResolver" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = "IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Demand()
		{
			throw null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00017FC0 File Offset: 0x000161C0
		[global::Cpp2ILInjected.Token(Token = "0x60016EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA9CC", Offset = "0x1AEA9CC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void CasOnlyDemand(int skip)
		{
			throw null;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00017FC3 File Offset: 0x000161C3
		[global::Cpp2ILInjected.Token(Token = "0x60016EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC300", Offset = "0x1AEC300", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00017FC6 File Offset: 0x000161C6
		[global::Cpp2ILInjected.Token(Token = "0x60016EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEBF60", Offset = "0x1AEBF60", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionSet), Member = "Demand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public bool IsEmpty()
		{
			throw null;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00017FC9 File Offset: 0x000161C9
		[global::Cpp2ILInjected.Token(Token = "0x60016ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC2F0", Offset = "0x1AEC2F0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00017FCC File Offset: 0x000161CC
		[global::Cpp2ILInjected.Token(Token = "0x60016EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC314", Offset = "0x1AEC314", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00017FCF File Offset: 0x000161CF
		[global::Cpp2ILInjected.Token(Token = "0x60016EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB514", Offset = "0x1AEB514", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public virtual SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00017FD2 File Offset: 0x000161D2
		[global::Cpp2ILInjected.Token(Token = "0x1700024D")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEC338", Offset = "0x1AEC338", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00017FD5 File Offset: 0x000161D5
		[global::Cpp2ILInjected.Token(Token = "0x1700024E")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEC34C", Offset = "0x1AEC34C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00017FD8 File Offset: 0x000161D8
		[global::Cpp2ILInjected.Token(Token = "0x1700024F")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEC360", Offset = "0x1AEC360", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00017FDB File Offset: 0x000161DB
		[global::System.MonoTODO("may not be required")]
		[global::Cpp2ILInjected.Token(Token = "0x60016F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC364", Offset = "0x1AEC364", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00017FDE File Offset: 0x000161DE
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEB9D4", Offset = "0x1AEB9D4", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00017FE1 File Offset: 0x000161E1
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEBBBC", Offset = "0x1AEBBBC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NamedPermissionSet), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00017FE4 File Offset: 0x000161E4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC368", Offset = "0x1AEC368", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static PermissionSet()
		{
			throw null;
		}

		// Token: 0x04000906 RID: 2310
		[global::Cpp2ILInjected.Token(Token = "0x4000B99")]
		private static object[] psUnrestricted;

		// Token: 0x04000907 RID: 2311
		[global::Cpp2ILInjected.Token(Token = "0x4000B9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Security.Permissions.PermissionState state;

		// Token: 0x04000908 RID: 2312
		[global::Cpp2ILInjected.Token(Token = "0x4000B9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.ArrayList list;

		// Token: 0x04000909 RID: 2313
		[global::Cpp2ILInjected.Token(Token = "0x4000B9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _declsec;

		// Token: 0x0400090A RID: 2314
		[global::Cpp2ILInjected.Token(Token = "0x4000B9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool[] _ignored;

		// Token: 0x0400090B RID: 2315
		[global::Cpp2ILInjected.Token(Token = "0x4000B9E")]
		private static object[] action;
	}
}
