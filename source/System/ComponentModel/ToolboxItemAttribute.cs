using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000279 RID: 633
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200036F")]
	public class ToolboxItemAttribute : Attribute
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x00006917 File Offset: 0x00004B17
		[global::Cpp2ILInjected.Token(Token = "0x60016E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49F20", Offset = "0x1E49F20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0000691A File Offset: 0x00004B1A
		[global::Cpp2ILInjected.Token(Token = "0x60016EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49F88", Offset = "0x1E49F88", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ToolboxItemAttribute(bool defaultType)
		{
			throw null;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0000691D File Offset: 0x00004B1D
		[global::Cpp2ILInjected.Token(Token = "0x60016EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E49FE4", Offset = "0x1E49FE4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToolboxItemAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
			throw null;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00006920 File Offset: 0x00004B20
		[global::Cpp2ILInjected.Token(Token = "0x60016EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A068", Offset = "0x1E4A068", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ToolboxItemAttribute(Type toolboxItemType)
		{
			throw null;
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00006923 File Offset: 0x00004B23
		[global::Cpp2ILInjected.Token(Token = "0x17000532")]
		public Type ToolboxItemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A0A8", Offset = "0x1E4A0A8", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00006926 File Offset: 0x00004B26
		[global::Cpp2ILInjected.Token(Token = "0x17000533")]
		public string ToolboxItemTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A23C", Offset = "0x1E4A23C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00006929 File Offset: 0x00004B29
		[global::Cpp2ILInjected.Token(Token = "0x60016EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A290", Offset = "0x1E4A290", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0000692C File Offset: 0x00004B2C
		[global::Cpp2ILInjected.Token(Token = "0x60016F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A37C", Offset = "0x1E4A37C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0000692F File Offset: 0x00004B2F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A3A0", Offset = "0x1E4A3A0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToolboxItemAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ToolboxItemAttribute()
		{
			throw null;
		}

		// Token: 0x04000E0B RID: 3595
		[global::Cpp2ILInjected.Token(Token = "0x4001210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type _toolboxItemType;

		// Token: 0x04000E0C RID: 3596
		[global::Cpp2ILInjected.Token(Token = "0x4001211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _toolboxItemTypeName;

		// Token: 0x04000E0D RID: 3597
		[global::Cpp2ILInjected.Token(Token = "0x4001212")]
		public static readonly ToolboxItemAttribute Default;

		// Token: 0x04000E0E RID: 3598
		[global::Cpp2ILInjected.Token(Token = "0x4001213")]
		public static readonly ToolboxItemAttribute None;
	}
}
