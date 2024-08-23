using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001B1 RID: 433
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000279")]
	[Serializable]
	public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x00005B31 File Offset: 0x00003D31
		[global::Cpp2ILInjected.Token(Token = "0x600116F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0DBBC", Offset = "0x1E0DBBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessSecurityAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(SecurityAction) }, ReturnType = typeof(void))]
		public SocketPermissionAttribute(SecurityAction action)
		{
			throw null;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00005B34 File Offset: 0x00003D34
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00005B37 File Offset: 0x00003D37
		[global::Cpp2ILInjected.Token(Token = "0x170003F9")]
		public string Access
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001170")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DBC4", Offset = "0x1E0DBC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001171")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DBCC", Offset = "0x1E0DBCC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermissionAttribute), Member = "AlreadySet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00005B3A File Offset: 0x00003D3A
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00005B3D File Offset: 0x00003D3D
		[global::Cpp2ILInjected.Token(Token = "0x170003FA")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001172")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DC90", Offset = "0x1E0DC90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001173")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DC98", Offset = "0x1E0DC98", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermissionAttribute), Member = "AlreadySet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00005B40 File Offset: 0x00003D40
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00005B43 File Offset: 0x00003D43
		[global::Cpp2ILInjected.Token(Token = "0x170003FB")]
		public string Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001174")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DCF0", Offset = "0x1E0DCF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001175")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DCF8", Offset = "0x1E0DCF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermissionAttribute), Member = "AlreadySet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00005B46 File Offset: 0x00003D46
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00005B49 File Offset: 0x00003D49
		[global::Cpp2ILInjected.Token(Token = "0x170003FC")]
		public string Transport
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001176")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DD50", Offset = "0x1E0DD50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0DD58", Offset = "0x1E0DD58", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermissionAttribute), Member = "AlreadySet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00005B4C File Offset: 0x00003D4C
		[global::Cpp2ILInjected.Token(Token = "0x6001178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0DDB0", Offset = "0x1E0DDB0", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(TransportType),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public override IPermission CreatePermission()
		{
			throw null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00005B4F File Offset: 0x00003D4F
		[global::Cpp2ILInjected.Token(Token = "0x6001179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0DC24", Offset = "0x1E0DC24", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "set_Access", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "set_Transport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void AlreadySet(string property)
		{
			throw null;
		}

		// Token: 0x04000A64 RID: 2660
		[global::Cpp2ILInjected.Token(Token = "0x4000D82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_access;

		// Token: 0x04000A65 RID: 2661
		[global::Cpp2ILInjected.Token(Token = "0x4000D83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_host;

		// Token: 0x04000A66 RID: 2662
		[global::Cpp2ILInjected.Token(Token = "0x4000D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_port;

		// Token: 0x04000A67 RID: 2663
		[global::Cpp2ILInjected.Token(Token = "0x4000D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string m_transport;
	}
}
