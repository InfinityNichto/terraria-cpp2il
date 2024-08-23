using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000375 RID: 885
	[global::Cpp2ILInjected.Token(Token = "0x200041D")]
	internal sealed class TypeInformation
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00019A45 File Offset: 0x00017C45
		[global::Cpp2ILInjected.Token(Token = "0x17000447")]
		internal string FullTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653E0", Offset = "0x1B653E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00019A48 File Offset: 0x00017C48
		[global::Cpp2ILInjected.Token(Token = "0x17000448")]
		internal string AssemblyString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653E8", Offset = "0x1B653E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x00019A4B File Offset: 0x00017C4B
		[global::Cpp2ILInjected.Token(Token = "0x17000449")]
		internal bool HasTypeForwardedFrom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B653F0", Offset = "0x1B653F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00019A4E File Offset: 0x00017C4E
		[global::Cpp2ILInjected.Token(Token = "0x60020AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B653F8", Offset = "0x1B653F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
		{
			throw null;
		}

		// Token: 0x04000E46 RID: 3654
		[global::Cpp2ILInjected.Token(Token = "0x4001138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string fullTypeName;

		// Token: 0x04000E47 RID: 3655
		[global::Cpp2ILInjected.Token(Token = "0x4001139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string assemblyString;

		// Token: 0x04000E48 RID: 3656
		[global::Cpp2ILInjected.Token(Token = "0x400113A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool hasTypeForwardedFrom;
	}
}
