using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000294 RID: 660
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x200038B")]
	public class InstallerTypeAttribute : Attribute
	{
		// Token: 0x0600155E RID: 5470 RVA: 0x00006A5E File Offset: 0x00004C5E
		[global::Cpp2ILInjected.Token(Token = "0x60017A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CF48", Offset = "0x1E4CF48", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InstallerTypeAttribute(Type installerType)
		{
			throw null;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00006A61 File Offset: 0x00004C61
		[global::Cpp2ILInjected.Token(Token = "0x60017AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CF84", Offset = "0x1E4CF84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InstallerTypeAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00006A64 File Offset: 0x00004C64
		[global::Cpp2ILInjected.Token(Token = "0x17000567")]
		public virtual Type InstallerType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CFAC", Offset = "0x1E4CFAC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00006A67 File Offset: 0x00004C67
		[global::Cpp2ILInjected.Token(Token = "0x60017AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D034", Offset = "0x1E4D034", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00006A6A File Offset: 0x00004C6A
		[global::Cpp2ILInjected.Token(Token = "0x60017AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D0D4", Offset = "0x1E4D0D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000E24 RID: 3620
		[global::Cpp2ILInjected.Token(Token = "0x400122C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeName;
	}
}
