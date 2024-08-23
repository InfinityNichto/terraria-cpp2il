using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001E0 RID: 480
	[global::Cpp2ILInjected.Token(Token = "0x20002C2")]
	internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x060010C9 RID: 4297
		[global::Cpp2ILInjected.Token(Token = "0x60012C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20588", Offset = "0x1E20588", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonUnixIPGlobalProperties), Member = "get_DomainName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		private static extern int getdomainname(byte[] name, int len);

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00005E5B File Offset: 0x0000405B
		[global::Cpp2ILInjected.Token(Token = "0x17000450")]
		public override string DomainName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20614", Offset = "0x1E20614", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonUnixIPGlobalProperties), Member = "getdomainname", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "T" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkInformationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00005E5E File Offset: 0x0000405E
		[global::Cpp2ILInjected.Token(Token = "0x60012C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2077C", Offset = "0x1E2077C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CommonUnixIPGlobalProperties()
		{
			throw null;
		}
	}
}
