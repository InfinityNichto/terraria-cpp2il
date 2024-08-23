using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027D RID: 637
	[global::Cpp2ILInjected.Token(Token = "0x2000373")]
	public abstract class EventDescriptor : MemberDescriptor
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x00006974 File Offset: 0x00004B74
		[global::Cpp2ILInjected.Token(Token = "0x6001708")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC14", Offset = "0x1E4AC14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected EventDescriptor(string name, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00006977 File Offset: 0x00004B77
		[global::Cpp2ILInjected.Token(Token = "0x6001709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC1C", Offset = "0x1E4AC1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		protected EventDescriptor(MemberDescriptor descr)
		{
			throw null;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0000697A File Offset: 0x00004B7A
		[global::Cpp2ILInjected.Token(Token = "0x600170A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC24", Offset = "0x1E4AC24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060014C4 RID: 5316
		[global::Cpp2ILInjected.Token(Token = "0x1700053A")]
		public abstract Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170B")]
			get;
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060014C5 RID: 5317
		[global::Cpp2ILInjected.Token(Token = "0x1700053B")]
		public abstract Type EventType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170C")]
			get;
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060014C6 RID: 5318
		[global::Cpp2ILInjected.Token(Token = "0x1700053C")]
		public abstract bool IsMulticast
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170D")]
			get;
		}

		// Token: 0x060014C7 RID: 5319
		[global::Cpp2ILInjected.Token(Token = "0x600170E")]
		public abstract void AddEventHandler(object component, Delegate value);

		// Token: 0x060014C8 RID: 5320
		[global::Cpp2ILInjected.Token(Token = "0x600170F")]
		public abstract void RemoveEventHandler(object component, Delegate value);
	}
}
