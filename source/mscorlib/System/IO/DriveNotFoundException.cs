using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200047E RID: 1150
	[global::Cpp2ILInjected.Token(Token = "0x2000549")]
	[global::System.Serializable]
	public class DriveNotFoundException : IOException
	{
		// Token: 0x06002560 RID: 9568 RVA: 0x0001AD29 File Offset: 0x00018F29
		[global::Cpp2ILInjected.Token(Token = "0x6002834")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA0848", Offset = "0x1BA0848", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DriveNotFoundException()
		{
			throw null;
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0001AD2C File Offset: 0x00018F2C
		[global::Cpp2ILInjected.Token(Token = "0x6002835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA08A4", Offset = "0x1BA08A4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public DriveNotFoundException(string message)
		{
			throw null;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0001AD2F File Offset: 0x00018F2F
		[global::Cpp2ILInjected.Token(Token = "0x6002836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA08C8", Offset = "0x1BA08C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected DriveNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
