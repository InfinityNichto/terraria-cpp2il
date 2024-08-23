using System;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000196 RID: 406
	[global::Cpp2ILInjected.Token(Token = "0x200024B")]
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00005492 File Offset: 0x00003692
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00005495 File Offset: 0x00003695
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

		// Token: 0x04000971 RID: 2417
		[global::Cpp2ILInjected.Token(Token = "0x4000C28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string password;
	}
}
