using System;
using System.Collections.Generic;
using System.Security.Claims;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	[global::Cpp2ILInjected.Token(Token = "0x2000325")]
	[global::System.Serializable]
	public class GenericIdentity : global::System.Security.Claims.ClaimsIdentity
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EAF0", Offset = "0x1B1EAF0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Claims.ClaimsIdentity) }, ReturnType = typeof(void))]
		protected GenericIdentity(GenericIdentity identity)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly string m_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly string m_type;
	}
}
