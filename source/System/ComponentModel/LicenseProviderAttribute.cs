using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200029F RID: 671
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000397")]
	public sealed class LicenseProviderAttribute : Attribute
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00006B09 File Offset: 0x00004D09
		[global::Cpp2ILInjected.Token(Token = "0x60017E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F3E8", Offset = "0x1E4F3E8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LicenseProviderAttribute()
		{
			throw null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00006B0C File Offset: 0x00004D0C
		[global::Cpp2ILInjected.Token(Token = "0x60017EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F404", Offset = "0x1E4F404", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LicenseProviderAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00006B0F File Offset: 0x00004D0F
		[global::Cpp2ILInjected.Token(Token = "0x60017EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F42C", Offset = "0x1E4F42C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LicenseProviderAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00006B12 File Offset: 0x00004D12
		[global::Cpp2ILInjected.Token(Token = "0x17000571")]
		public Type LicenseProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F114", Offset = "0x1E4F114", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "ValidateInternalRecursive", MemberParameters = new object[]
			{
				typeof(LicenseContext),
				typeof(Type),
				typeof(object),
				typeof(bool),
				typeof(ref License),
				typeof(ref string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseProviderAttribute), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00006B15 File Offset: 0x00004D15
		[global::Cpp2ILInjected.Token(Token = "0x17000572")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F454", Offset = "0x1E4F454", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00006B18 File Offset: 0x00004D18
		[global::Cpp2ILInjected.Token(Token = "0x60017EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F504", Offset = "0x1E4F504", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseProviderAttribute), Member = "get_LicenseProvider", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00006B1B File Offset: 0x00004D1B
		[global::Cpp2ILInjected.Token(Token = "0x60017EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F610", Offset = "0x1E4F610", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00006B1E File Offset: 0x00004D1E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F618", Offset = "0x1E4F618", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static LicenseProviderAttribute()
		{
			throw null;
		}

		// Token: 0x04000E2B RID: 3627
		[global::Cpp2ILInjected.Token(Token = "0x4001235")]
		public static readonly LicenseProviderAttribute Default;

		// Token: 0x04000E2C RID: 3628
		[global::Cpp2ILInjected.Token(Token = "0x4001236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type _licenseProviderType;

		// Token: 0x04000E2D RID: 3629
		[global::Cpp2ILInjected.Token(Token = "0x4001237")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _licenseProviderName;
	}
}
