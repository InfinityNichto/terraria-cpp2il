using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	// Token: 0x02000200 RID: 512
	[global::Cpp2ILInjected.Token(Token = "0x20002E5")]
	internal class RequestCacheBinding
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x00005EF7 File Offset: 0x000040F7
		[global::Cpp2ILInjected.Token(Token = "0x60012F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21734", Offset = "0x1E21734", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_DefaultCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy)
		{
			throw null;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00005EFA File Offset: 0x000040FA
		[global::Cpp2ILInjected.Token(Token = "0x17000461")]
		internal RequestCache Cache
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E217A8", Offset = "0x1E217A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00005EFD File Offset: 0x000040FD
		[global::Cpp2ILInjected.Token(Token = "0x17000462")]
		internal RequestCacheValidator Validator
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E217B0", Offset = "0x1E217B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00005F00 File Offset: 0x00004100
		[global::Cpp2ILInjected.Token(Token = "0x17000463")]
		internal RequestCachePolicy Policy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E217B8", Offset = "0x1E217B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000B9F RID: 2975
		[global::Cpp2ILInjected.Token(Token = "0x4000F73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RequestCache m_RequestCache;

		// Token: 0x04000BA0 RID: 2976
		[global::Cpp2ILInjected.Token(Token = "0x4000F74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RequestCacheValidator m_CacheValidator;

		// Token: 0x04000BA1 RID: 2977
		[global::Cpp2ILInjected.Token(Token = "0x4000F75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RequestCachePolicy m_Policy;
	}
}
