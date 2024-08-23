using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000051 RID: 81
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	public struct Resolution
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002341 File Offset: 0x00000541
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002344 File Offset: 0x00000544
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public int width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A2C", Offset = "0x1F73A2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "WriteJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000178")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A34", Offset = "0x1F73A34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "ReadJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				typeof(Type),
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002347 File Offset: 0x00000547
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000234A File Offset: 0x0000054A
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public int height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000179")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A3C", Offset = "0x1F73A3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "WriteJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600017A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A44", Offset = "0x1F73A44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "ReadJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				typeof(Type),
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000234D File Offset: 0x0000054D
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002350 File Offset: 0x00000550
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public int refreshRate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A4C", Offset = "0x1F73A4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "WriteJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600017C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F73A54", Offset = "0x1F73A54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.ResolutionConverter", Member = "ReadJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				typeof(Type),
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002353 File Offset: 0x00000553
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73A5C", Offset = "0x1F73A5C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Width;

		// Token: 0x04000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int m_Height;

		// Token: 0x04000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int m_RefreshRate;
	}
}
