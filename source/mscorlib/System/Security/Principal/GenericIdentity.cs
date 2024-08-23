using System;
using System.Collections.Generic;
using System.Security.Claims;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	// Token: 0x02000288 RID: 648
	[global::Cpp2ILInjected.Token(Token = "0x2000325")]
	[global::System.Serializable]
	public class GenericIdentity : global::System.Security.Claims.ClaimsIdentity
	{
		// Token: 0x06001934 RID: 6452 RVA: 0x00018BE4 File Offset: 0x00016DE4
		[global::Cpp2ILInjected.Token(Token = "0x6001B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E934", Offset = "0x1B1E934", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerBasicIdentity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenericIdentity), Member = "AddNameClaim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public GenericIdentity(string name, string type)
		{
			throw null;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00018BE7 File Offset: 0x00016DE7
		[global::Cpp2ILInjected.Token(Token = "0x6001B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EAD4", Offset = "0x1B1EAD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private GenericIdentity()
		{
			throw null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00018BEA File Offset: 0x00016DEA
		[global::Cpp2ILInjected.Token(Token = "0x6001B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EAF0", Offset = "0x1B1EAF0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Claims.ClaimsIdentity) }, ReturnType = typeof(void))]
		protected GenericIdentity(GenericIdentity identity)
		{
			throw null;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00018BED File Offset: 0x00016DED
		[global::Cpp2ILInjected.Token(Token = "0x6001B51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1ED08", Offset = "0x1B1ED08", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Claims.ClaimsIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.Security.Claims.ClaimsIdentity Clone()
		{
			throw null;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00018BF0 File Offset: 0x00016DF0
		[global::Cpp2ILInjected.Token(Token = "0x1700030F")]
		public override global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1ED68", Offset = "0x1B1ED68", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00018BF3 File Offset: 0x00016DF3
		[global::Cpp2ILInjected.Token(Token = "0x17000310")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1EDDC", Offset = "0x1B1EDDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00018BF6 File Offset: 0x00016DF6
		[global::Cpp2ILInjected.Token(Token = "0x17000311")]
		public override string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1EDE4", Offset = "0x1B1EDE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00018BF9 File Offset: 0x00016DF9
		[global::Cpp2ILInjected.Token(Token = "0x6001B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EA04", Offset = "0x1B1EA04", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GenericIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.Claim), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.Security.Claims.ClaimsIdentity),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "AddClaim", MemberParameters = new object[] { typeof(global::System.Security.Claims.Claim) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AddNameClaim()
		{
			throw null;
		}

		// Token: 0x04000B05 RID: 2821
		[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly string m_name;

		// Token: 0x04000B06 RID: 2822
		[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly string m_type;
	}
}
