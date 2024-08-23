using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000236 RID: 566
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D3")]
	public abstract class DeriveBytes : global::System.IDisposable
	{
		// Token: 0x06001647 RID: 5703
		[global::Cpp2ILInjected.Token(Token = "0x6001861")]
		public abstract byte[] GetBytes(int cb);

		// Token: 0x06001648 RID: 5704
		[global::Cpp2ILInjected.Token(Token = "0x6001862")]
		public abstract void Reset();

		// Token: 0x06001649 RID: 5705 RVA: 0x00018395 File Offset: 0x00016595
		[global::Cpp2ILInjected.Token(Token = "0x6001863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA994", Offset = "0x1AFA994", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00018398 File Offset: 0x00016598
		[global::Cpp2ILInjected.Token(Token = "0x6001864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFAA00", Offset = "0x1AFAA00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0001839B File Offset: 0x0001659B
		[global::Cpp2ILInjected.Token(Token = "0x6001865")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFAA04", Offset = "0x1AFAA04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected DeriveBytes()
		{
			throw null;
		}
	}
}
