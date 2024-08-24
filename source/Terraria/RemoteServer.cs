using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;

namespace Terraria
{
	// Token: 0x02000337 RID: 823
	[global::Cpp2ILInjected.Token(Token = "0x200044B")]
	public class RemoteServer
	{
		// Token: 0x060026C5 RID: 9925 RVA: 0x00028E86 File Offset: 0x00027086
		[global::Cpp2ILInjected.Token(Token = "0x6002965")]
		[global::Cpp2ILInjected.Address(RVA = "0x115ADB0", Offset = "0x115ADB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RemoteServer()
		{
			throw null;
		}

		// Token: 0x04002EB3 RID: 11955
		[global::Cpp2ILInjected.Token(Token = "0x4003678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Server Client;

		// Token: 0x04002EB4 RID: 11956
		[global::Cpp2ILInjected.Token(Token = "0x4003679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsActive;

		// Token: 0x04002EB5 RID: 11957
		[global::Cpp2ILInjected.Token(Token = "0x400367A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int State;

		// Token: 0x04002EB6 RID: 11958
		[global::Cpp2ILInjected.Token(Token = "0x400367B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int TimeOutTimer;

		// Token: 0x04002EB7 RID: 11959
		[global::Cpp2ILInjected.Token(Token = "0x400367C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string StatusText;

		// Token: 0x04002EB8 RID: 11960
		[global::Cpp2ILInjected.Token(Token = "0x400367D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int StatusCount;

		// Token: 0x04002EB9 RID: 11961
		[global::Cpp2ILInjected.Token(Token = "0x400367E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int StatusMax;
	}
}
