using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000149 RID: 329
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20001D2")]
	[Serializable]
	public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x00004B38 File Offset: 0x00002D38
		[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17358", Offset = "0x1F17358", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessSecurityAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(SecurityAction) }, ReturnType = typeof(void))]
		public WebPermissionAttribute(SecurityAction action)
		{
			throw null;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00004B3B File Offset: 0x00002D3B
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00004B3E File Offset: 0x00002D3E
		[global::Cpp2ILInjected.Token(Token = "0x1700024D")]
		public string Connect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F17360", Offset = "0x1F17360", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F173C0", Offset = "0x1F173C0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00004B41 File Offset: 0x00002D41
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00004B44 File Offset: 0x00002D44
		[global::Cpp2ILInjected.Token(Token = "0x1700024E")]
		public string Accept
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1749C", Offset = "0x1F1749C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F174FC", Offset = "0x1F174FC", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00004B47 File Offset: 0x00002D47
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00004B4A File Offset: 0x00002D4A
		[global::Cpp2ILInjected.Token(Token = "0x1700024F")]
		public string ConnectPattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F175D8", Offset = "0x1F175D8", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F176AC", Offset = "0x1F176AC", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00004B4D File Offset: 0x00002D4D
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00004B50 File Offset: 0x00002D50
		[global::Cpp2ILInjected.Token(Token = "0x17000250")]
		public string AcceptPattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1789C", Offset = "0x1F1789C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F17970", Offset = "0x1F17970", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelayedRegex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00004B53 File Offset: 0x00002D53
		[global::Cpp2ILInjected.Token(Token = "0x6000B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17AEC", Offset = "0x1F17AEC", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = ".ctor", MemberParameters = new object[] { typeof(NetworkAccess) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebPermission), Member = "AddAsPattern", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(DelayedRegex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override IPermission CreatePermission()
		{
			throw null;
		}

		// Token: 0x040007C9 RID: 1993
		[global::Cpp2ILInjected.Token(Token = "0x40009EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object m_accept;

		// Token: 0x040007CA RID: 1994
		[global::Cpp2ILInjected.Token(Token = "0x40009EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object m_connect;
	}
}
