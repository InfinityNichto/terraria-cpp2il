using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002B2 RID: 690
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000352")]
	public class TypeEntry
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x00018EFF File Offset: 0x000170FF
		[global::Cpp2ILInjected.Token(Token = "0x6001C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32AD0", Offset = "0x1B32AD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TypeEntry()
		{
			throw null;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00018F02 File Offset: 0x00017102
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x00018F05 File Offset: 0x00017105
		[global::Cpp2ILInjected.Token(Token = "0x17000345")]
		public string AssemblyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AD8", Offset = "0x1B32AD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AE0", Offset = "0x1B32AE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00018F08 File Offset: 0x00017108
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x00018F0B File Offset: 0x0001710B
		[global::Cpp2ILInjected.Token(Token = "0x17000346")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AE8", Offset = "0x1B32AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B32AF0", Offset = "0x1B32AF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000B88 RID: 2952
		[global::Cpp2ILInjected.Token(Token = "0x4000E6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string assembly_name;

		// Token: 0x04000B89 RID: 2953
		[global::Cpp2ILInjected.Token(Token = "0x4000E6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string type_name;
	}
}
