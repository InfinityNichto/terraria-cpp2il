using System;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200024B")]
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DE58", Offset = "0x1F4DE58", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerContext), Member = "ParseBasicAuthentication", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPrincipal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenericIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public HttpListenerBasicIdentity(string username, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031C")]
		public virtual string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4DEC0", Offset = "0x1F4DEC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string password;
	}
}
