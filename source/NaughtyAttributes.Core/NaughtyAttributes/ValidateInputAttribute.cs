using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	public class ValidateInputAttribute : ValidatorAttribute
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000217F File Offset: 0x0000037F
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002182 File Offset: 0x00000382
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public string CallbackName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000066")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5A98", Offset = "0x1CB5A98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000067")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5AA0", Offset = "0x1CB5AA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002185 File Offset: 0x00000385
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002188 File Offset: 0x00000388
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public string Message
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000068")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5AA8", Offset = "0x1CB5AA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000069")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5AB0", Offset = "0x1CB5AB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000218B File Offset: 0x0000038B
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5AB8", Offset = "0x1CB5AB8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ValidateInputAttribute(string callbackName, string message = null)
		{
			throw null;
		}

		// Token: 0x04000031 RID: 49
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <CallbackName>k__BackingField;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Message>k__BackingField;
	}
}
