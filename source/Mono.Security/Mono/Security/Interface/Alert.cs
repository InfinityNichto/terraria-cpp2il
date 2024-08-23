using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	// Token: 0x02000029 RID: 41
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public class Alert
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000033F0 File Offset: 0x000015F0
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		public AlertLevel Level
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B1FC", Offset = "0x1A9B1FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000033F3 File Offset: 0x000015F3
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public AlertDescription Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B204", Offset = "0x1A9B204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000033F6 File Offset: 0x000015F6
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B20C", Offset = "0x1A9B20C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Alert(AlertDescription description)
		{
			throw null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000033F9 File Offset: 0x000015F9
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B278", Offset = "0x1A9B278", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void inferAlertLevel()
		{
			throw null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000033FC File Offset: 0x000015FC
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B2B8", Offset = "0x1A9B2B8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AlertLevel level;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private AlertDescription description;
	}
}
