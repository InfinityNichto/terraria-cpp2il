using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x20002E5")]
	internal class RequestCacheBinding
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21734", Offset = "0x1E21734", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_DefaultCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000F73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RequestCache m_RequestCache;

		[global::Cpp2ILInjected.Token(Token = "0x4000F74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RequestCacheValidator m_CacheValidator;

		[global::Cpp2ILInjected.Token(Token = "0x4000F75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RequestCachePolicy m_Policy;
	}
}
