using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000027 RID: 39
	[global::Cpp2ILInjected.Token(Token = "0x2000028")]
	[Serializable]
	public class InControlException : Exception
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000259A File Offset: 0x0000079A
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987A14", Offset = "0x1987A14", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InControlException()
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000259D File Offset: 0x0000079D
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B81C", Offset = "0x197B81C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyCombo), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "InsertBindingAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "RemoveBindingAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "AddPlayerAction", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InControlException(string message)
		{
			throw null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000025A0 File Offset: 0x000007A0
		[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987A6C", Offset = "0x1987A6C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InControlException(string message, Exception inner)
		{
			throw null;
		}
	}
}
