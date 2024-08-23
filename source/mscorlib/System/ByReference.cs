using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000103 RID: 259
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x200013B")]
	internal ref struct ByReference<T>
	{
		// Token: 0x06000BDA RID: 3034 RVA: 0x00016763 File Offset: 0x00014963
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x6000CA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB348", Offset = "0x18EB348", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ByReference(ref T value)
		{
			throw null;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00016766 File Offset: 0x00014966
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public ref T Value
		{
			[global::System.Runtime.CompilerServices.Intrinsic]
			[global::Cpp2ILInjected.Token(Token = "0x6000CA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EB380", Offset = "0x18EB380", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400037F RID: 895
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr _value;
	}
}
