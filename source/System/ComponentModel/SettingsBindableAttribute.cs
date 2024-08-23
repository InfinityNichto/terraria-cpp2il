using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002BA RID: 698
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B8")]
	public sealed class SettingsBindableAttribute : Attribute
	{
		// Token: 0x06001700 RID: 5888 RVA: 0x00006F08 File Offset: 0x00005108
		[global::Cpp2ILInjected.Token(Token = "0x6001961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D8B0", Offset = "0x1E5D8B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SettingsBindableAttribute(bool bindable)
		{
			throw null;
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00006F0B File Offset: 0x0000510B
		[global::Cpp2ILInjected.Token(Token = "0x170005CF")]
		public bool Bindable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001962")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D8D8", Offset = "0x1E5D8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00006F0E File Offset: 0x0000510E
		[global::Cpp2ILInjected.Token(Token = "0x6001963")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D8E0", Offset = "0x1E5D8E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00006F11 File Offset: 0x00005111
		[global::Cpp2ILInjected.Token(Token = "0x6001964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D96C", Offset = "0x1E5D96C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00006F14 File Offset: 0x00005114
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D98C", Offset = "0x1E5D98C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SettingsBindableAttribute()
		{
			throw null;
		}

		// Token: 0x04000EAA RID: 3754
		[global::Cpp2ILInjected.Token(Token = "0x40012C8")]
		public static readonly SettingsBindableAttribute Yes;

		// Token: 0x04000EAB RID: 3755
		[global::Cpp2ILInjected.Token(Token = "0x40012C9")]
		public static readonly SettingsBindableAttribute No;

		// Token: 0x04000EAC RID: 3756
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Bindable>k__BackingField;
	}
}
