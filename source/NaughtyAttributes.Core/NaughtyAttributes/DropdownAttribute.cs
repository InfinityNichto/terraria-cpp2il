using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class DropdownAttribute : DrawerAttribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public string ValuesFieldName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000012")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5580", Offset = "0x1CB5580", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000013")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5588", Offset = "0x1CB5588", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5590", Offset = "0x1CB5590", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DropdownAttribute(string valuesFieldName)
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <ValuesFieldName>k__BackingField;
	}
}
