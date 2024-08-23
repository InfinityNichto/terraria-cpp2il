using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000064 RID: 100
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable
	{
		// Token: 0x06000359 RID: 857 RVA: 0x000037BB File Offset: 0x000019BB
		[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB5F4", Offset = "0x1EBB5F4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "DoCheckTimeout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeoutException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000037BE File Offset: 0x000019BE
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB6C0", Offset = "0x1EBB6C0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeoutException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RegexMatchTimeoutException()
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000037C1 File Offset: 0x000019C1
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB754", Offset = "0x1EBB754", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeoutException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000037C4 File Offset: 0x000019C4
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBB884", Offset = "0x1EBB884", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000037C7 File Offset: 0x000019C7
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public string Input
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EBB960", Offset = "0x1EBB960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000037CA File Offset: 0x000019CA
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public string Pattern
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EBB968", Offset = "0x1EBB968", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000037CD File Offset: 0x000019CD
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public TimeSpan MatchTimeout
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EBB970", Offset = "0x1EBB970", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly string <Input>k__BackingField;

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000337")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly string <Pattern>k__BackingField;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private readonly TimeSpan <MatchTimeout>k__BackingField;
	}
}
