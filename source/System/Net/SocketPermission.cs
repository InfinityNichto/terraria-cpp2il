using System;
using System.Collections;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001B0 RID: 432
	[global::Cpp2ILInjected.Token(Token = "0x2000278")]
	[Serializable]
	public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x00005AFE File Offset: 0x00003CFE
		[global::Cpp2ILInjected.Token(Token = "0x600115E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BA2C", Offset = "0x1E0BA2C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Copy", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Union", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SocketPermission(PermissionState state)
		{
			throw null;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00005B01 File Offset: 0x00003D01
		[global::Cpp2ILInjected.Token(Token = "0x600115F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BAC0", Offset = "0x1E0BAC0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
		{
			throw null;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00005B04 File Offset: 0x00003D04
		[global::Cpp2ILInjected.Token(Token = "0x170003F7")]
		public IEnumerator AcceptList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001160")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0BC34", Offset = "0x1E0BC34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00005B07 File Offset: 0x00003D07
		[global::Cpp2ILInjected.Token(Token = "0x170003F8")]
		public IEnumerator ConnectList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001161")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0BC48", Offset = "0x1E0BC48", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00005B0A File Offset: 0x00003D0A
		[global::Cpp2ILInjected.Token(Token = "0x6001162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BB74", Offset = "0x1E0BB74", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "FromXml", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(NetworkAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(TransportType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
		{
			throw null;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00005B0D File Offset: 0x00003D0D
		[global::Cpp2ILInjected.Token(Token = "0x6001163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BC5C", Offset = "0x1E0BC5C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IPermission Copy()
		{
			throw null;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00005B10 File Offset: 0x00003D10
		[global::Cpp2ILInjected.Token(Token = "0x6001164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BDB4", Offset = "0x1E0BDB4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "IntersectEmpty", MemberParameters = new object[] { typeof(SocketPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00005B13 File Offset: 0x00003D13
		[global::Cpp2ILInjected.Token(Token = "0x6001165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BEE8", Offset = "0x1E0BEE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		private bool IntersectEmpty(SocketPermission permission)
		{
			throw null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00005B16 File Offset: 0x00003D16
		[global::Cpp2ILInjected.Token(Token = "0x6001166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0BF3C", Offset = "0x1E0BF3C", Length = "0x62C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "Intersect", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "Intersect", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(EndpointPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void Intersect(ArrayList list1, ArrayList list2, ArrayList result)
		{
			throw null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00005B19 File Offset: 0x00003D19
		[global::Cpp2ILInjected.Token(Token = "0x6001167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0C568", Offset = "0x1E0C568", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "IsSubsetOf", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00005B1C File Offset: 0x00003D1C
		[global::Cpp2ILInjected.Token(Token = "0x6001168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0C6E8", Offset = "0x1E0C6E8", Length = "0x584")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(IPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndpointPermission), Member = "IsSubsetOf", MemberParameters = new object[] { typeof(EndpointPermission) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private bool IsSubsetOf(ArrayList list1, ArrayList list2)
		{
			throw null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00005B1F File Offset: 0x00003D1F
		[global::Cpp2ILInjected.Token(Token = "0x6001169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0CC6C", Offset = "0x1E0CC6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00005B22 File Offset: 0x00003D22
		[global::Cpp2ILInjected.Token(Token = "0x600116A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0CC74", Offset = "0x1E0CC74", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "ToXml", MemberParameters = new object[]
		{
			typeof(SecurityElement),
			typeof(string),
			typeof(IEnumerator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00005B25 File Offset: 0x00003D25
		[global::Cpp2ILInjected.Token(Token = "0x600116B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0CE64", Offset = "0x1E0CE64", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "ToXml", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ToXml(SecurityElement root, string childName, IEnumerator enumerator)
		{
			throw null;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00005B28 File Offset: 0x00003D28
		[global::Cpp2ILInjected.Token(Token = "0x600116C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0D148", Offset = "0x1E0D148", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "FromXml", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(NetworkAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public override void FromXml(SecurityElement securityElement)
		{
			throw null;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00005B2B File Offset: 0x00003D2B
		[global::Cpp2ILInjected.Token(Token = "0x600116D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0D5C8", Offset = "0x1E0D5C8", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermission), Member = "FromXml", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "Attribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(TransportType),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void FromXml(ArrayList endpoints, NetworkAccess access)
		{
			throw null;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00005B2E File Offset: 0x00003D2E
		[global::Cpp2ILInjected.Token(Token = "0x600116E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0DA60", Offset = "0x1E0DA60", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override IPermission Union(IPermission target)
		{
			throw null;
		}

		// Token: 0x04000A60 RID: 2656
		[global::Cpp2ILInjected.Token(Token = "0x4000D7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList m_acceptList;

		// Token: 0x04000A61 RID: 2657
		[global::Cpp2ILInjected.Token(Token = "0x4000D7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList m_connectList;

		// Token: 0x04000A62 RID: 2658
		[global::Cpp2ILInjected.Token(Token = "0x4000D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_noRestriction;

		// Token: 0x04000A63 RID: 2659
		[global::Cpp2ILInjected.Token(Token = "0x4000D81")]
		public const int AllPorts = -1;
	}
}
